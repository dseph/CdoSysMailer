using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CdoSysMailer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
 
            CDO.Message oMsg;
            CDO.Configuration oConfg;
           
            ADODB.Fields oFields;
 
            try
            { 
 
                 oMsg = new CDO.Message();
                 oConfg = new CDO.Configuration();
                 oFields = oConfg.Fields;
 
                 // Send by pickup folder?
                 if (chkSendByPort.Checked == true)
                 {

                      
                     //CDO.CdoProtocolsAuthentication.cdoNTLM
                     string sUser = txtUser.Text.Trim();
                     string sPassword = txtPassword.Text.Trim();
                     string sDomain = txtDomain.Text.Trim();

                     if (cmboAuthentication.Text == "Basic") oFields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"].Value = CDO.CdoProtocolsAuthentication.cdoBasic;  // 1
                     if (cmboAuthentication.Text == "Anonymous") oFields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"].Value = CDO.CdoProtocolsAuthentication.cdoAnonymous;  // 0
                     if (cmboAuthentication.Text == "NTLM") oFields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"].Value = CDO.CdoProtocolsAuthentication.cdoNTLM;  // 2

                     if (sUser.Length != 0)
                     {
 
                         oFields["http://schemas.microsoft.com/cdo/configuration/sendusername"].Value = sUser;  // user name
                         oFields["http://schemas.microsoft.com/cdo/configuration/sendpassword"].Value = sPassword;  // Password
                     }

                     
                     oFields["http://schemas.microsoft.com/cdo/configuration/sendusing"].Value = CDO.CdoSendUsing.cdoSendUsingPort;
                     oFields["http://schemas.microsoft.com/cdo/configuration/smtpserver"].Value = cboServer.Text;
                     oFields["http://schemas.microsoft.com/cdo/configuration/smtpconnectiontimeout"].Value = 10;
                     oFields["http://schemas.microsoft.com/cdo/configuration/smtpserverport"].Value = Int32.Parse(cboPort.Text.Trim());

                     if (chkEnableSSL.Checked)
                        oFields["http://schemas.microsoft.com/cdo/configuration/smtpusessl"].Value = 1;

                 }

 

                 // use pickup directory?
                 if (rdoSendByPickupFolder.Checked == true)
                 {
                     if (this.chkSpecifyPickupFolder.Checked)
                     {
                         oFields["http://schemas.microsoft.com/cdo/configuration/sendusing"].Value = CDO.CdoSendUsing.cdoSendUsingPickup;
                         oFields["http://schemas.microsoft.com/cdo/configuration/smtpserverpickupdirectory"].Value = txtPickupFolder.Text.Trim();
                     }
                     else
                     {
                         oFields["http://schemas.microsoft.com/cdo/configuration/sendusing"].Value = CDO.CdoSendUsing.cdoSendUsingPickup;
                     }
                 }


                 oFields.Update();   // This needs to be done after setting all the fields.
                 oMsg.Configuration = oConfg;
 
                // Set Recipients
                if (txtFrom.Text.Trim() != "")
                    oMsg.From = this.txtFrom.Text.Trim();
                if (txtTo.Text.Trim() != "")
                    oMsg.To = this.txtTo.Text.Trim();
                if (this.txtCC.Text.Trim() != "")
                    oMsg.CC = this.txtCC.Text.Trim();
                if (this.txtBCC.Text.Trim() != "")
                    oMsg.BCC = this.txtBCC.Text.Trim();

                oMsg.Subject = txtSubject.Text;

                if (cmboBodyType.Text == "Text")
                    oMsg.HTMLBody = txtBody.Text;
                if (cmboBodyType.Text == "HTML")
                    oMsg.TextBody = txtBody.Text;

                SetHeaders(ref oMsg);


                if (chkAddAttachment.Checked == true)
                {
                    CDO.IBodyPart oAttachment;

                    oAttachment = oMsg.AddAttachment(txtAttachment.Text.Trim(), "", "");

                    if (cmboAttachmentContentMediaType.Text.Trim() != "(Default)")
                        oAttachment.ContentMediaType = cmboAttachmentContentMediaType.Text.Trim();

                    if (this.cmboAttachmentContentTransferEncoding.Text.Trim() != "(Default)")
                        oAttachment.ContentTransferEncoding = this.cmboAttachmentContentTransferEncoding.Text.Trim();

                    if (this.cmboAttachmentCharset.Text.Trim() != "(Default)")
                        oAttachment.Charset = this.cmboAttachmentCharset.Text.Trim();

                    if (this.cmboAttachmentContentClass.Text.Trim() != "(Default)")
                        oAttachment.ContentClass = this.cmboAttachmentContentClass.Text.Trim();
                
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oAttachment); // Always release underlaying COM object.
                }
 
                oMsg.Send();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oMsg); // Always release underlaying COM object.

                MessageBox.Show("Message Sent.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
 
        }

        private void AddAttachmentAsBodyPart()
        {

            //Flds = oAttachment.Fields;

            //if (cmboAttachmentContentMediaType.Text.Trim() != "(Default)")
            //    oAttachment.ContentMediaType = cmboAttachmentContentMediaType.Text.Trim();

            //if (cmboAttachmentContentMediaType.Text.Trim() != "(Default)")
            //    oAttachFlds["urn:schemas:mailheader:Content-Type"].Value = "XXXXX";   // "application/octet-stream" -  for ics attachment as meeting request

            //if (cmboAttachmentContentMediaType.Text.Trim() != "(Default)")
            //    oAttachFlds["urn:schemas:mailheader:Content-Transfer-Encoding"].Value = "XXXXX"; // use  "base64" -  for ics attachment as meeting request

            //if (cmboAttachmentContentMediaType.Text.Trim() != "(Default)")

            //    oAttachFlds["urn:schemas:mailheader:Content-Disposition"].Value = "XXXXX"; // use  "attachment" -  for ics attachment as meeting request

            //oAttachFlds.Update();
        }
         

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmboBodyType.Text = "Text";
            SetCheckedAttachmentSelect();

            this.cmboAuthentication.Text = "(Default)";

            this.cmboAttachmentContentMediaType.Text = "(Default)";
            this.cmboBodyType.Text = "(Default)";
            this.cmboCharset.Text = "(Default)";
            this.cmboContentClass.Text = "(Default)";
            this.cmboContentMediaType.Text  = "(Default)";
            this.cmboContentTransferEncoding.Text = "(Default)";
            this.cmboPriority.Text = "(Default)";
            this.cmboImportance.Text = "(Default)";

            this.cmboAttachmentCharset.Text = "(Default)";
            this.cmboAttachmentContentClass.Text = "(Default)";
            this.cmboAttachmentContentMediaType.Text = "(Default)";
            this.cmboAttachmentContentTransferEncoding.Text = "(Default)";

            SetSendByEnablement();
        }

   
        void SetHeaders(ref CDO.Message oMsg)
        {

            if (this.cmboPriority.Text != "(Default)")
            {
                if (this.cmboPriority.Text == "Non Urgent")
                    oMsg.Fields["urn:schemas:mailheader:priority"].Value = CDO.cdoPriorityValues.cdoPriorityNonUrgent;  //"Low";   -1     
               
                if (this.cmboPriority.Text == "Normal")
                    oMsg.Fields["urn:schemas:mailheader:priority"].Value = CDO.cdoPriorityValues.cdoPriorityNormal;  //"Normal";  0
           
                if (this.cmboPriority.Text == "Urgent")
                    oMsg.Fields["urn:schemas:mailheader:priority"].Value = CDO.cdoPriorityValues.cdoPriorityUrgent;  //"High";   1
            }

            if (this.cmboImportance.Text != "(Default)")
            {
                if (this.cmboPriority.Text == "High")
                    oMsg.Fields["urn:schemas:mailheader:importance"].Value = CDO.cdoImportanceValues.cdoHigh;  
 
                if (this.cmboPriority.Text == "Low")
                    oMsg.Fields["urn:schemas:mailheader:importance"].Value = CDO.cdoImportanceValues.cdoLow;  

                if (this.cmboPriority.Text == "Normal")
                    oMsg.Fields["urn:schemas:mailheader:importance"].Value = CDO.cdoImportanceValues.cdoNormal;   
            }

 
            if (this.chkRequestReturnReceipt.Checked == true)
            {
                oMsg.Fields["urn:schemas:mailheader:return-receipt-to"].Value = this.txtFrom.Text;;
            }

            // https://msdn.microsoft.com/en-us/library/ms526451(v=exchg.10).aspx
            if (this.cmboContentMediaType.Text.Trim() != "(Default)")
                oMsg.BodyPart.ContentMediaType = this.cmboContentMediaType.Text.Trim();

            if (this.cmboContentTransferEncoding.Text.Trim() != "(Default)")
                oMsg.BodyPart.ContentTransferEncoding = this.cmboContentTransferEncoding.Text.Trim();

            if (this.cmboCharset.Text.Trim() != "(Default)")
                oMsg.BodyPart.Charset = this.cmboCharset.Text.Trim();

            if (this.cmboContentClass.Text.Trim() != "(Default)")
                oMsg.BodyPart.ContentClass = this.cmboContentClass.Text.Trim();

            // Other headers ----------------------------------------
            if (this.chkHeader1.Checked == true)
                oMsg.Fields["urn:schemas:mailheader:" + this.txtMailHeaderName1.Text.Trim()].Value = this.txtMailHeaderValue1.Text.Trim();

            if (this.chkHeader2.Checked == true)
                oMsg.Fields["urn:schemas:mailheader:" + this.txtMailHeaderName2.Text.Trim()].Value = this.txtMailHeaderValue2.Text.Trim();

            if (this.chkHeader3.Checked == true)
                oMsg.Fields["urn:schemas:mailheader:" + this.txtMailHeaderName3.Text.Trim()].Value = this.txtMailHeaderValue3.Text.Trim();

            if (this.chkHeader4.Checked == true)
                oMsg.Fields["urn:schemas:mailheader:" + this.txtMailHeaderName4.Text.Trim()].Value = this.txtMailHeaderValue4.Text.Trim();

            if (this.chkHeader5.Checked == true)
                oMsg.Fields["urn:schemas:mailheader:" + this.txtMailHeaderName5.Text.Trim()].Value = this.txtMailHeaderValue5.Text.Trim();

            oMsg.Fields.Update();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAddAttachment_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckedAttachmentSelect();
        }

        private void SetCheckedAttachmentSelect()
        {
            txtAttachment.Enabled = chkAddAttachment.Checked;
            cmboAttachmentContentMediaType.Enabled = chkAddAttachment.Checked;

            this.cmboAttachmentCharset.Enabled = chkAddAttachment.Checked;
            this.cmboAttachmentContentClass.Enabled = chkAddAttachment.Checked;
            this.cmboAttachmentContentMediaType.Enabled = chkAddAttachment.Checked;
            this.cmboAttachmentContentTransferEncoding.Enabled = chkAddAttachment.Checked;
        }

        private void chkRequestReadReceipt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRequestReturnReceipt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSendByPort_CheckedChanged(object sender, EventArgs e)
        {
            SetSendByEnablement();
        }

        private void rdoSendByPickupFolder_CheckedChanged(object sender, EventArgs e)
        {
            SetSendByEnablement();
        }

        private void chkSpecifyPickupFolder_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPickupFolder.Enabled = chkSpecifyPickupFolder.Checked;
        }

        private void SetSendByEnablement()
        {
            this.cboServer.Enabled = chkSendByPort.Checked;
            this.cboPort.Enabled = chkSendByPort.Checked;
            this.chkEnableSSL.Enabled = chkSendByPort.Checked;
            this.txtUser.Enabled = chkSendByPort.Checked;
            this.txtPassword.Enabled = chkSendByPort.Checked;
            this.txtDomain.Enabled = chkSendByPort.Checked;
            this.cmboAuthentication.Enabled = chkSendByPort.Checked;

            this.chkSpecifyPickupFolder.Enabled = rdoSendByPickupFolder.Checked;

            this.txtPickupFolder.Enabled = (rdoSendByPickupFolder.Checked && this.chkSpecifyPickupFolder.Checked);

        }

        private void SetExtraHeadersEnablement()
        {
 
  

        }

        private void chkHeader1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtMailHeaderName1.Enabled = this.chkHeader1.Checked;
            this.txtMailHeaderValue1.Enabled = this.chkHeader1.Checked;
 
        }

        private void chkHeader2_CheckedChanged(object sender, EventArgs e)
        {
            

            this.txtMailHeaderName2.Enabled = this.chkHeader2.Checked;
            this.txtMailHeaderValue2.Enabled = this.chkHeader2.Checked;

  
        }

        private void chkHeader3_CheckedChanged(object sender, EventArgs e)
        {
 

            this.txtMailHeaderName3.Enabled = this.chkHeader3.Checked;
            this.txtMailHeaderValue3.Enabled = this.chkHeader3.Checked;
 
        }

        private void chkHeader4_CheckedChanged(object sender, EventArgs e)
        {
 

            this.txtMailHeaderName4.Enabled = this.chkHeader4.Checked;
            this.txtMailHeaderValue4.Enabled = this.chkHeader4.Checked;

 
        }

        private void chkHeader5_CheckedChanged(object sender, EventArgs e)
        {


            this.txtMailHeaderName5.Enabled = this.chkHeader5.Checked;
            this.txtMailHeaderValue5.Enabled = this.chkHeader5.Checked;
        }

        private void grpSmtpSettings_Enter(object sender, EventArgs e)
        {
 
 
        }
    }
}
