namespace CdoSysMailer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessageType = new System.Windows.Forms.Label();
            this.cmboBodyType = new System.Windows.Forms.ComboBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtBCC = new System.Windows.Forms.TextBox();
            this.lblBCC = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.grpMessageOptions = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmboImportance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRequestReturnReceipt = new System.Windows.Forms.CheckBox();
            this.cmboPriority = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpSmtpSettings = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmboAuthentication = new System.Windows.Forms.ComboBox();
            this.txtPickupFolder = new System.Windows.Forms.TextBox();
            this.chkSpecifyPickupFolder = new System.Windows.Forms.CheckBox();
            this.rdoSendByPickupFolder = new System.Windows.Forms.RadioButton();
            this.chkSendByPort = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnableSSL = new System.Windows.Forms.CheckBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.grpUserCreds = new System.Windows.Forms.GroupBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserSmtp = new System.Windows.Forms.Label();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMailHeaderName1 = new System.Windows.Forms.TextBox();
            this.txtMailHeaderValue1 = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Label();
            this.grpMailHeaders = new System.Windows.Forms.GroupBox();
            this.chkHeader5 = new System.Windows.Forms.CheckBox();
            this.txtMailHeaderValue5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMailHeaderName5 = new System.Windows.Forms.TextBox();
            this.chkHeader4 = new System.Windows.Forms.CheckBox();
            this.txtMailHeaderValue4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMailHeaderName4 = new System.Windows.Forms.TextBox();
            this.chkHeader3 = new System.Windows.Forms.CheckBox();
            this.chkHeader2 = new System.Windows.Forms.CheckBox();
            this.chkHeader1 = new System.Windows.Forms.CheckBox();
            this.txtMailHeaderValue3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMailHeaderName3 = new System.Windows.Forms.TextBox();
            this.txtMailHeaderValue2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMailHeaderName2 = new System.Windows.Forms.TextBox();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.grpAttachments = new System.Windows.Forms.GroupBox();
            this.cmboAttachmentContentTransferEncoding = new System.Windows.Forms.ComboBox();
            this.cmboAttachmentContentClass = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmboAttachmentCharset = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmboAttachmentContentMediaType = new System.Windows.Forms.ComboBox();
            this.chkAddAttachment = new System.Windows.Forms.CheckBox();
            this.cmboContentMediaType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmboCharset = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmboContentTransferEncoding = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmboContentClass = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpMessageBodyPartSettings = new System.Windows.Forms.GroupBox();
            this.grpRecipients = new System.Windows.Forms.GroupBox();
            this.grpMessageOptions.SuspendLayout();
            this.grpSmtpSettings.SuspendLayout();
            this.grpUserCreds.SuspendLayout();
            this.grpMailHeaders.SuspendLayout();
            this.grpAttachments.SuspendLayout();
            this.grpMessageBodyPartSettings.SuspendLayout();
            this.grpRecipients.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Location = new System.Drawing.Point(68, 22);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(592, 22);
            this.txtFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // lblMessageType
            // 
            this.lblMessageType.AutoSize = true;
            this.lblMessageType.Location = new System.Drawing.Point(19, 207);
            this.lblMessageType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageType.Name = "lblMessageType";
            this.lblMessageType.Size = new System.Drawing.Size(80, 17);
            this.lblMessageType.TabIndex = 4;
            this.lblMessageType.Text = "Body Type:";
            // 
            // cmboBodyType
            // 
            this.cmboBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBodyType.FormattingEnabled = true;
            this.cmboBodyType.Items.AddRange(new object[] {
            "Text",
            "HTML"});
            this.cmboBodyType.Location = new System.Drawing.Point(107, 204);
            this.cmboBodyType.Margin = new System.Windows.Forms.Padding(4);
            this.cmboBodyType.Name = "cmboBodyType";
            this.cmboBodyType.Size = new System.Drawing.Size(145, 24);
            this.cmboBodyType.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(89, 165);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(590, 22);
            this.txtSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(18, 168);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 17);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject:";
            // 
            // txtBCC
            // 
            this.txtBCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBCC.Location = new System.Drawing.Point(68, 117);
            this.txtBCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBCC.Name = "txtBCC";
            this.txtBCC.Size = new System.Drawing.Size(592, 22);
            this.txtBCC.TabIndex = 7;
            // 
            // lblBCC
            // 
            this.lblBCC.AutoSize = true;
            this.lblBCC.Location = new System.Drawing.Point(6, 126);
            this.lblBCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBCC.Name = "lblBCC";
            this.lblBCC.Size = new System.Drawing.Size(39, 17);
            this.lblBCC.TabIndex = 6;
            this.lblBCC.Text = "BCC:";
            // 
            // txtCC
            // 
            this.txtCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCC.Location = new System.Drawing.Point(68, 85);
            this.txtCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(592, 22);
            this.txtCC.TabIndex = 5;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(6, 94);
            this.lblCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(30, 17);
            this.lblCC.TabIndex = 4;
            this.lblCC.Text = "CC:";
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Location = new System.Drawing.Point(68, 53);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(592, 22);
            this.txtTo.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(6, 62);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 17);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(16, 245);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.MaxLength = 0;
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBody.Size = new System.Drawing.Size(1354, 203);
            this.txtBody.TabIndex = 6;
            // 
            // grpMessageOptions
            // 
            this.grpMessageOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMessageOptions.Controls.Add(this.label15);
            this.grpMessageOptions.Controls.Add(this.cmboImportance);
            this.grpMessageOptions.Controls.Add(this.label4);
            this.grpMessageOptions.Controls.Add(this.chkRequestReturnReceipt);
            this.grpMessageOptions.Controls.Add(this.cmboPriority);
            this.grpMessageOptions.Location = new System.Drawing.Point(12, 456);
            this.grpMessageOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpMessageOptions.Name = "grpMessageOptions";
            this.grpMessageOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpMessageOptions.Size = new System.Drawing.Size(1332, 57);
            this.grpMessageOptions.TabIndex = 7;
            this.grpMessageOptions.TabStop = false;
            this.grpMessageOptions.Text = "Message Options";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(449, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Importance:";
            // 
            // cmboImportance
            // 
            this.cmboImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboImportance.FormattingEnabled = true;
            this.cmboImportance.Items.AddRange(new object[] {
            "(Default)",
            "High",
            "Low",
            "Normal"});
            this.cmboImportance.Location = new System.Drawing.Point(545, 23);
            this.cmboImportance.Margin = new System.Windows.Forms.Padding(4);
            this.cmboImportance.Name = "cmboImportance";
            this.cmboImportance.Size = new System.Drawing.Size(145, 24);
            this.cmboImportance.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Priority:";
            // 
            // chkRequestReturnReceipt
            // 
            this.chkRequestReturnReceipt.AutoSize = true;
            this.chkRequestReturnReceipt.Location = new System.Drawing.Point(17, 23);
            this.chkRequestReturnReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.chkRequestReturnReceipt.Name = "chkRequestReturnReceipt";
            this.chkRequestReturnReceipt.Size = new System.Drawing.Size(182, 21);
            this.chkRequestReturnReceipt.TabIndex = 0;
            this.chkRequestReturnReceipt.Text = "Request Return Receipt";
            this.chkRequestReturnReceipt.UseVisualStyleBackColor = true;
            this.chkRequestReturnReceipt.CheckedChanged += new System.EventHandler(this.chkRequestReturnReceipt_CheckedChanged);
            // 
            // cmboPriority
            // 
            this.cmboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboPriority.FormattingEnabled = true;
            this.cmboPriority.Items.AddRange(new object[] {
            "(Default)",
            "Non Urgent",
            "Normal",
            "Urgent"});
            this.cmboPriority.Location = new System.Drawing.Point(289, 25);
            this.cmboPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cmboPriority.Name = "cmboPriority";
            this.cmboPriority.Size = new System.Drawing.Size(145, 24);
            this.cmboPriority.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(1164, 860);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(209, 28);
            this.btnSend.TabIndex = 11;
            this.btnSend.Tag = "";
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // grpSmtpSettings
            // 
            this.grpSmtpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSmtpSettings.Controls.Add(this.label16);
            this.grpSmtpSettings.Controls.Add(this.cmboAuthentication);
            this.grpSmtpSettings.Controls.Add(this.txtPickupFolder);
            this.grpSmtpSettings.Controls.Add(this.chkSpecifyPickupFolder);
            this.grpSmtpSettings.Controls.Add(this.rdoSendByPickupFolder);
            this.grpSmtpSettings.Controls.Add(this.chkSendByPort);
            this.grpSmtpSettings.Controls.Add(this.label2);
            this.grpSmtpSettings.Controls.Add(this.chkEnableSSL);
            this.grpSmtpSettings.Controls.Add(this.cboPort);
            this.grpSmtpSettings.Controls.Add(this.grpUserCreds);
            this.grpSmtpSettings.Controls.Add(this.cboServer);
            this.grpSmtpSettings.Controls.Add(this.label3);
            this.grpSmtpSettings.Location = new System.Drawing.Point(690, 15);
            this.grpSmtpSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSmtpSettings.Name = "grpSmtpSettings";
            this.grpSmtpSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSmtpSettings.Size = new System.Drawing.Size(680, 209);
            this.grpSmtpSettings.TabIndex = 1;
            this.grpSmtpSettings.TabStop = false;
            this.grpSmtpSettings.Text = "SMTP Settings";
            this.grpSmtpSettings.Enter += new System.EventHandler(this.grpSmtpSettings_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Auth Type:";
            // 
            // cmboAuthentication
            // 
            this.cmboAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboAuthentication.FormattingEnabled = true;
            this.cmboAuthentication.Items.AddRange(new object[] {
            "(Default)",
            "Anonymous",
            "Basic",
            "NTLM"});
            this.cmboAuthentication.Location = new System.Drawing.Point(125, 121);
            this.cmboAuthentication.Margin = new System.Windows.Forms.Padding(4);
            this.cmboAuthentication.Name = "cmboAuthentication";
            this.cmboAuthentication.Size = new System.Drawing.Size(182, 24);
            this.cmboAuthentication.TabIndex = 10;
            // 
            // txtPickupFolder
            // 
            this.txtPickupFolder.Location = new System.Drawing.Point(209, 174);
            this.txtPickupFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPickupFolder.Name = "txtPickupFolder";
            this.txtPickupFolder.Size = new System.Drawing.Size(465, 22);
            this.txtPickupFolder.TabIndex = 8;
            // 
            // chkSpecifyPickupFolder
            // 
            this.chkSpecifyPickupFolder.AutoSize = true;
            this.chkSpecifyPickupFolder.Location = new System.Drawing.Point(32, 179);
            this.chkSpecifyPickupFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSpecifyPickupFolder.Name = "chkSpecifyPickupFolder";
            this.chkSpecifyPickupFolder.Size = new System.Drawing.Size(170, 21);
            this.chkSpecifyPickupFolder.TabIndex = 7;
            this.chkSpecifyPickupFolder.Text = "Specify Pickup Folder:";
            this.chkSpecifyPickupFolder.UseVisualStyleBackColor = true;
            this.chkSpecifyPickupFolder.CheckedChanged += new System.EventHandler(this.chkSpecifyPickupFolder_CheckedChanged);
            // 
            // rdoSendByPickupFolder
            // 
            this.rdoSendByPickupFolder.AutoSize = true;
            this.rdoSendByPickupFolder.Location = new System.Drawing.Point(12, 153);
            this.rdoSendByPickupFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSendByPickupFolder.Name = "rdoSendByPickupFolder";
            this.rdoSendByPickupFolder.Size = new System.Drawing.Size(166, 21);
            this.rdoSendByPickupFolder.TabIndex = 6;
            this.rdoSendByPickupFolder.Text = "Send by pickup folder";
            this.rdoSendByPickupFolder.UseVisualStyleBackColor = true;
            this.rdoSendByPickupFolder.CheckedChanged += new System.EventHandler(this.rdoSendByPickupFolder_CheckedChanged);
            // 
            // chkSendByPort
            // 
            this.chkSendByPort.AutoSize = true;
            this.chkSendByPort.Checked = true;
            this.chkSendByPort.Location = new System.Drawing.Point(9, 18);
            this.chkSendByPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSendByPort.Name = "chkSendByPort";
            this.chkSendByPort.Size = new System.Drawing.Size(108, 21);
            this.chkSendByPort.TabIndex = 0;
            this.chkSendByPort.TabStop = true;
            this.chkSendByPort.Text = "SendByPort:";
            this.chkSendByPort.UseVisualStyleBackColor = true;
            this.chkSendByPort.CheckedChanged += new System.EventHandler(this.chkSendByPort_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.AutoSize = true;
            this.chkEnableSSL.Checked = true;
            this.chkEnableSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSSL.Location = new System.Drawing.Point(203, 76);
            this.chkEnableSSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEnableSSL.Name = "chkEnableSSL";
            this.chkEnableSSL.Size = new System.Drawing.Size(104, 21);
            this.chkEnableSSL.TabIndex = 5;
            this.chkEnableSSL.Text = "Enable SSL";
            this.chkEnableSSL.UseVisualStyleBackColor = true;
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Items.AddRange(new object[] {
            "25",
            "465",
            "587"});
            this.cboPort.Location = new System.Drawing.Point(88, 73);
            this.cboPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(73, 24);
            this.cboPort.TabIndex = 4;
            this.cboPort.Text = "587";
            // 
            // grpUserCreds
            // 
            this.grpUserCreds.Controls.Add(this.txtDomain);
            this.grpUserCreds.Controls.Add(this.label8);
            this.grpUserCreds.Controls.Add(this.txtUser);
            this.grpUserCreds.Controls.Add(this.txtPassword);
            this.grpUserCreds.Controls.Add(this.lblPassword);
            this.grpUserCreds.Controls.Add(this.lblUserSmtp);
            this.grpUserCreds.Location = new System.Drawing.Point(329, 18);
            this.grpUserCreds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserCreds.Name = "grpUserCreds";
            this.grpUserCreds.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserCreds.Size = new System.Drawing.Size(347, 122);
            this.grpUserCreds.TabIndex = 9;
            this.grpUserCreds.TabStop = false;
            this.grpUserCreds.Text = "User Credentials";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(105, 82);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(236, 22);
            this.txtDomain.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Domain:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(105, 22);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(236, 22);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 55);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 55);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserSmtp
            // 
            this.lblUserSmtp.AutoSize = true;
            this.lblUserSmtp.Location = new System.Drawing.Point(25, 24);
            this.lblUserSmtp.Name = "lblUserSmtp";
            this.lblUserSmtp.Size = new System.Drawing.Size(42, 17);
            this.lblUserSmtp.TabIndex = 0;
            this.lblUserSmtp.Text = "User:";
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Items.AddRange(new object[] {
            "smtp.live.com",
            "smtp.gmail.com",
            "smtp.mail.yahoo.com"});
            this.cboServer.Location = new System.Drawing.Point(88, 46);
            this.cboServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(235, 24);
            this.cboServer.TabIndex = 2;
            this.cboServer.Text = "smtp.live.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server:";
            // 
            // txtMailHeaderName1
            // 
            this.txtMailHeaderName1.Enabled = false;
            this.txtMailHeaderName1.Location = new System.Drawing.Point(117, 22);
            this.txtMailHeaderName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderName1.Name = "txtMailHeaderName1";
            this.txtMailHeaderName1.Size = new System.Drawing.Size(357, 22);
            this.txtMailHeaderName1.TabIndex = 1;
            // 
            // txtMailHeaderValue1
            // 
            this.txtMailHeaderValue1.Enabled = false;
            this.txtMailHeaderValue1.Location = new System.Drawing.Point(556, 21);
            this.txtMailHeaderValue1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderValue1.Name = "txtMailHeaderValue1";
            this.txtMailHeaderValue1.Size = new System.Drawing.Size(655, 22);
            this.txtMailHeaderValue1.TabIndex = 3;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Location = new System.Drawing.Point(504, 26);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(48, 17);
            this.Header.TabIndex = 2;
            this.Header.Text = "Value:";
            // 
            // grpMailHeaders
            // 
            this.grpMailHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMailHeaders.Controls.Add(this.chkHeader5);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderValue5);
            this.grpMailHeaders.Controls.Add(this.label10);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderName5);
            this.grpMailHeaders.Controls.Add(this.chkHeader4);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderValue4);
            this.grpMailHeaders.Controls.Add(this.label7);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderName4);
            this.grpMailHeaders.Controls.Add(this.chkHeader3);
            this.grpMailHeaders.Controls.Add(this.chkHeader2);
            this.grpMailHeaders.Controls.Add(this.chkHeader1);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderValue3);
            this.grpMailHeaders.Controls.Add(this.label9);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderName3);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderValue2);
            this.grpMailHeaders.Controls.Add(this.label6);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderName2);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderValue1);
            this.grpMailHeaders.Controls.Add(this.Header);
            this.grpMailHeaders.Controls.Add(this.txtMailHeaderName1);
            this.grpMailHeaders.Location = new System.Drawing.Point(16, 520);
            this.grpMailHeaders.Name = "grpMailHeaders";
            this.grpMailHeaders.Size = new System.Drawing.Size(1328, 174);
            this.grpMailHeaders.TabIndex = 8;
            this.grpMailHeaders.TabStop = false;
            this.grpMailHeaders.Text = "Mail Headers";
            // 
            // chkHeader5
            // 
            this.chkHeader5.AutoSize = true;
            this.chkHeader5.Location = new System.Drawing.Point(11, 143);
            this.chkHeader5.Margin = new System.Windows.Forms.Padding(4);
            this.chkHeader5.Name = "chkHeader5";
            this.chkHeader5.Size = new System.Drawing.Size(93, 21);
            this.chkHeader5.TabIndex = 16;
            this.chkHeader5.Text = "Header 5:";
            this.chkHeader5.UseVisualStyleBackColor = true;
            this.chkHeader5.CheckedChanged += new System.EventHandler(this.chkHeader5_CheckedChanged);
            // 
            // txtMailHeaderValue5
            // 
            this.txtMailHeaderValue5.Enabled = false;
            this.txtMailHeaderValue5.Location = new System.Drawing.Point(556, 141);
            this.txtMailHeaderValue5.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderValue5.Name = "txtMailHeaderValue5";
            this.txtMailHeaderValue5.Size = new System.Drawing.Size(655, 22);
            this.txtMailHeaderValue5.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(504, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Value:";
            // 
            // txtMailHeaderName5
            // 
            this.txtMailHeaderName5.Enabled = false;
            this.txtMailHeaderName5.Location = new System.Drawing.Point(117, 142);
            this.txtMailHeaderName5.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderName5.Name = "txtMailHeaderName5";
            this.txtMailHeaderName5.Size = new System.Drawing.Size(357, 22);
            this.txtMailHeaderName5.TabIndex = 17;
            // 
            // chkHeader4
            // 
            this.chkHeader4.AutoSize = true;
            this.chkHeader4.Location = new System.Drawing.Point(11, 113);
            this.chkHeader4.Margin = new System.Windows.Forms.Padding(4);
            this.chkHeader4.Name = "chkHeader4";
            this.chkHeader4.Size = new System.Drawing.Size(93, 21);
            this.chkHeader4.TabIndex = 12;
            this.chkHeader4.Text = "Header 4:";
            this.chkHeader4.UseVisualStyleBackColor = true;
            this.chkHeader4.CheckedChanged += new System.EventHandler(this.chkHeader4_CheckedChanged);
            // 
            // txtMailHeaderValue4
            // 
            this.txtMailHeaderValue4.Enabled = false;
            this.txtMailHeaderValue4.Location = new System.Drawing.Point(556, 111);
            this.txtMailHeaderValue4.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderValue4.Name = "txtMailHeaderValue4";
            this.txtMailHeaderValue4.Size = new System.Drawing.Size(655, 22);
            this.txtMailHeaderValue4.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Value:";
            // 
            // txtMailHeaderName4
            // 
            this.txtMailHeaderName4.Enabled = false;
            this.txtMailHeaderName4.Location = new System.Drawing.Point(117, 112);
            this.txtMailHeaderName4.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderName4.Name = "txtMailHeaderName4";
            this.txtMailHeaderName4.Size = new System.Drawing.Size(357, 22);
            this.txtMailHeaderName4.TabIndex = 13;
            // 
            // chkHeader3
            // 
            this.chkHeader3.AutoSize = true;
            this.chkHeader3.Location = new System.Drawing.Point(11, 83);
            this.chkHeader3.Margin = new System.Windows.Forms.Padding(4);
            this.chkHeader3.Name = "chkHeader3";
            this.chkHeader3.Size = new System.Drawing.Size(93, 21);
            this.chkHeader3.TabIndex = 8;
            this.chkHeader3.Text = "Header 3:";
            this.chkHeader3.UseVisualStyleBackColor = true;
            this.chkHeader3.CheckedChanged += new System.EventHandler(this.chkHeader3_CheckedChanged);
            // 
            // chkHeader2
            // 
            this.chkHeader2.AutoSize = true;
            this.chkHeader2.Location = new System.Drawing.Point(11, 55);
            this.chkHeader2.Margin = new System.Windows.Forms.Padding(4);
            this.chkHeader2.Name = "chkHeader2";
            this.chkHeader2.Size = new System.Drawing.Size(93, 21);
            this.chkHeader2.TabIndex = 4;
            this.chkHeader2.Text = "Header 2:";
            this.chkHeader2.UseVisualStyleBackColor = true;
            this.chkHeader2.CheckedChanged += new System.EventHandler(this.chkHeader2_CheckedChanged);
            // 
            // chkHeader1
            // 
            this.chkHeader1.AutoSize = true;
            this.chkHeader1.Location = new System.Drawing.Point(11, 24);
            this.chkHeader1.Margin = new System.Windows.Forms.Padding(4);
            this.chkHeader1.Name = "chkHeader1";
            this.chkHeader1.Size = new System.Drawing.Size(93, 21);
            this.chkHeader1.TabIndex = 0;
            this.chkHeader1.Text = "Header 1:";
            this.chkHeader1.UseVisualStyleBackColor = true;
            this.chkHeader1.CheckedChanged += new System.EventHandler(this.chkHeader1_CheckedChanged);
            // 
            // txtMailHeaderValue3
            // 
            this.txtMailHeaderValue3.Enabled = false;
            this.txtMailHeaderValue3.Location = new System.Drawing.Point(556, 81);
            this.txtMailHeaderValue3.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderValue3.Name = "txtMailHeaderValue3";
            this.txtMailHeaderValue3.Size = new System.Drawing.Size(655, 22);
            this.txtMailHeaderValue3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Value:";
            // 
            // txtMailHeaderName3
            // 
            this.txtMailHeaderName3.Enabled = false;
            this.txtMailHeaderName3.Location = new System.Drawing.Point(117, 82);
            this.txtMailHeaderName3.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderName3.Name = "txtMailHeaderName3";
            this.txtMailHeaderName3.Size = new System.Drawing.Size(357, 22);
            this.txtMailHeaderName3.TabIndex = 9;
            // 
            // txtMailHeaderValue2
            // 
            this.txtMailHeaderValue2.Enabled = false;
            this.txtMailHeaderValue2.Location = new System.Drawing.Point(556, 51);
            this.txtMailHeaderValue2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderValue2.Name = "txtMailHeaderValue2";
            this.txtMailHeaderValue2.Size = new System.Drawing.Size(655, 22);
            this.txtMailHeaderValue2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Value:";
            // 
            // txtMailHeaderName2
            // 
            this.txtMailHeaderName2.Enabled = false;
            this.txtMailHeaderName2.Location = new System.Drawing.Point(117, 52);
            this.txtMailHeaderName2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailHeaderName2.Name = "txtMailHeaderName2";
            this.txtMailHeaderName2.Size = new System.Drawing.Size(357, 22);
            this.txtMailHeaderName2.TabIndex = 5;
            // 
            // txtAttachment
            // 
            this.txtAttachment.Location = new System.Drawing.Point(157, 20);
            this.txtAttachment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.Size = new System.Drawing.Size(465, 22);
            this.txtAttachment.TabIndex = 1;
            // 
            // grpAttachments
            // 
            this.grpAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAttachments.Controls.Add(this.cmboAttachmentContentTransferEncoding);
            this.grpAttachments.Controls.Add(this.cmboAttachmentContentClass);
            this.grpAttachments.Controls.Add(this.label17);
            this.grpAttachments.Controls.Add(this.label18);
            this.grpAttachments.Controls.Add(this.cmboAttachmentCharset);
            this.grpAttachments.Controls.Add(this.label19);
            this.grpAttachments.Controls.Add(this.label5);
            this.grpAttachments.Controls.Add(this.cmboAttachmentContentMediaType);
            this.grpAttachments.Controls.Add(this.chkAddAttachment);
            this.grpAttachments.Controls.Add(this.txtAttachment);
            this.grpAttachments.Location = new System.Drawing.Point(16, 763);
            this.grpAttachments.Name = "grpAttachments";
            this.grpAttachments.Size = new System.Drawing.Size(1341, 90);
            this.grpAttachments.TabIndex = 10;
            this.grpAttachments.TabStop = false;
            this.grpAttachments.Text = "Attachments";
            // 
            // cmboAttachmentContentTransferEncoding
            // 
            this.cmboAttachmentContentTransferEncoding.FormattingEnabled = true;
            this.cmboAttachmentContentTransferEncoding.Items.AddRange(new object[] {
            "(Default)",
            "7bit",
            "8bit",
            "base64",
            "mac-binhex40",
            "quoted-printable",
            "uuencode"});
            this.cmboAttachmentContentTransferEncoding.Location = new System.Drawing.Point(780, 61);
            this.cmboAttachmentContentTransferEncoding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboAttachmentContentTransferEncoding.Name = "cmboAttachmentContentTransferEncoding";
            this.cmboAttachmentContentTransferEncoding.Size = new System.Drawing.Size(181, 24);
            this.cmboAttachmentContentTransferEncoding.TabIndex = 7;
            this.cmboAttachmentContentTransferEncoding.Text = "(Default)";
            // 
            // cmboAttachmentContentClass
            // 
            this.cmboAttachmentContentClass.FormattingEnabled = true;
            this.cmboAttachmentContentClass.Items.AddRange(new object[] {
            "(Default)",
            "urn:content-classes:message",
            "urn:content-classes:calendarmessage",
            "urn:content-classes:reportmessage",
            "urn:content-classes:dsn",
            "urn:content-classes:mdn",
            "urn:content-classes:recallmessage",
            "urn:content-classes:recallreport"});
            this.cmboAttachmentContentClass.Location = new System.Drawing.Point(1068, 57);
            this.cmboAttachmentContentClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboAttachmentContentClass.Name = "cmboAttachmentContentClass";
            this.cmboAttachmentContentClass.Size = new System.Drawing.Size(246, 24);
            this.cmboAttachmentContentClass.TabIndex = 9;
            this.cmboAttachmentContentClass.Text = "(Default)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(967, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 17);
            this.label17.TabIndex = 8;
            this.label17.Text = "Content Class:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(357, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Charset:";
            // 
            // cmboAttachmentCharset
            // 
            this.cmboAttachmentCharset.FormattingEnabled = true;
            this.cmboAttachmentCharset.Items.AddRange(new object[] {
            "(Default)",
            "big5",
            "euc-jp",
            "euc-kr",
            "gb2312",
            "iso-2022-jp",
            "iso-2022-kr",
            "iso-8859-1",
            "iso-8859-2",
            "iso-8859-3",
            "iso-8859-4",
            "iso-8859-5",
            "iso-8859-6",
            "iso-8859-7",
            "iso-8859-8",
            "iso-8859-9",
            "koi8-r",
            "shift-jis",
            "us-ascii",
            "utf-7",
            "utf-8"});
            this.cmboAttachmentCharset.Location = new System.Drawing.Point(433, 57);
            this.cmboAttachmentCharset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboAttachmentCharset.Name = "cmboAttachmentCharset";
            this.cmboAttachmentCharset.Size = new System.Drawing.Size(125, 24);
            this.cmboAttachmentCharset.TabIndex = 5;
            this.cmboAttachmentCharset.Text = "(Default)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(590, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(174, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "ContentTransferEncoding:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Content Media Type:";
            // 
            // cmboAttachmentContentMediaType
            // 
            this.cmboAttachmentContentMediaType.FormattingEnabled = true;
            this.cmboAttachmentContentMediaType.Items.AddRange(new object[] {
            "(Default)",
            "image/gif ",
            "image/jpeg ",
            "message/external-body ",
            "message/partial ",
            "message/rfc822 ",
            "multipart/alternative ",
            "multipart/digest ",
            "multipart/mixed ",
            "multipart/related ",
            "text/html ",
            "text/plain "});
            this.cmboAttachmentContentMediaType.Location = new System.Drawing.Point(159, 58);
            this.cmboAttachmentContentMediaType.Margin = new System.Windows.Forms.Padding(4);
            this.cmboAttachmentContentMediaType.Name = "cmboAttachmentContentMediaType";
            this.cmboAttachmentContentMediaType.Size = new System.Drawing.Size(191, 24);
            this.cmboAttachmentContentMediaType.TabIndex = 3;
            // 
            // chkAddAttachment
            // 
            this.chkAddAttachment.AutoSize = true;
            this.chkAddAttachment.Location = new System.Drawing.Point(21, 22);
            this.chkAddAttachment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAddAttachment.Name = "chkAddAttachment";
            this.chkAddAttachment.Size = new System.Drawing.Size(130, 21);
            this.chkAddAttachment.TabIndex = 0;
            this.chkAddAttachment.Text = "Add Attachment";
            this.chkAddAttachment.UseVisualStyleBackColor = true;
            this.chkAddAttachment.CheckedChanged += new System.EventHandler(this.chkAddAttachment_CheckedChanged);
            // 
            // cmboContentMediaType
            // 
            this.cmboContentMediaType.FormattingEnabled = true;
            this.cmboContentMediaType.Items.AddRange(new object[] {
            "(Default)",
            "image/gif ",
            "image/jpeg ",
            "message/external-body ",
            "message/partial ",
            "message/rfc822 ",
            "multipart/alternative ",
            "multipart/digest ",
            "multipart/mixed ",
            "multipart/related ",
            "text/html ",
            "text/plain "});
            this.cmboContentMediaType.Location = new System.Drawing.Point(153, 20);
            this.cmboContentMediaType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboContentMediaType.Name = "cmboContentMediaType";
            this.cmboContentMediaType.Size = new System.Drawing.Size(191, 24);
            this.cmboContentMediaType.TabIndex = 1;
            this.cmboContentMediaType.Text = "(Default)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Content Media Type:";
            // 
            // cmboCharset
            // 
            this.cmboCharset.FormattingEnabled = true;
            this.cmboCharset.Items.AddRange(new object[] {
            "(Default)",
            "big5",
            "euc-jp",
            "euc-kr",
            "gb2312",
            "iso-2022-jp",
            "iso-2022-kr",
            "iso-8859-1",
            "iso-8859-2",
            "iso-8859-3",
            "iso-8859-4",
            "iso-8859-5",
            "iso-8859-6",
            "iso-8859-7",
            "iso-8859-8",
            "iso-8859-9",
            "koi8-r",
            "shift-jis",
            "us-ascii",
            "utf-7",
            "utf-8"});
            this.cmboCharset.Location = new System.Drawing.Point(427, 23);
            this.cmboCharset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboCharset.Name = "cmboCharset";
            this.cmboCharset.Size = new System.Drawing.Size(125, 24);
            this.cmboCharset.TabIndex = 3;
            this.cmboCharset.Text = "(Default)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(351, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Charset:";
            // 
            // cmboContentTransferEncoding
            // 
            this.cmboContentTransferEncoding.FormattingEnabled = true;
            this.cmboContentTransferEncoding.Items.AddRange(new object[] {
            "(Default)",
            "7bit",
            "8bit",
            "base64",
            "mac-binhex40",
            "quoted-printable",
            "uuencode"});
            this.cmboContentTransferEncoding.Location = new System.Drawing.Point(762, 25);
            this.cmboContentTransferEncoding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboContentTransferEncoding.Name = "cmboContentTransferEncoding";
            this.cmboContentTransferEncoding.Size = new System.Drawing.Size(181, 24);
            this.cmboContentTransferEncoding.TabIndex = 5;
            this.cmboContentTransferEncoding.Text = "(Default)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(575, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "ContentTransferEncoding:";
            // 
            // cmboContentClass
            // 
            this.cmboContentClass.FormattingEnabled = true;
            this.cmboContentClass.Items.AddRange(new object[] {
            "(Default)",
            "urn:content-classes:message",
            "urn:content-classes:calendarmessage",
            "urn:content-classes:reportmessage",
            "urn:content-classes:dsn",
            "urn:content-classes:mdn",
            "urn:content-classes:recallmessage",
            "urn:content-classes:recallreport"});
            this.cmboContentClass.Location = new System.Drawing.Point(1053, 23);
            this.cmboContentClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboContentClass.Name = "cmboContentClass";
            this.cmboContentClass.Size = new System.Drawing.Size(255, 24);
            this.cmboContentClass.TabIndex = 7;
            this.cmboContentClass.Text = "(Default)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(952, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Content Class:";
            // 
            // grpMessageBodyPartSettings
            // 
            this.grpMessageBodyPartSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMessageBodyPartSettings.Controls.Add(this.cmboContentTransferEncoding);
            this.grpMessageBodyPartSettings.Controls.Add(this.label11);
            this.grpMessageBodyPartSettings.Controls.Add(this.cmboContentClass);
            this.grpMessageBodyPartSettings.Controls.Add(this.cmboContentMediaType);
            this.grpMessageBodyPartSettings.Controls.Add(this.label14);
            this.grpMessageBodyPartSettings.Controls.Add(this.label12);
            this.grpMessageBodyPartSettings.Controls.Add(this.cmboCharset);
            this.grpMessageBodyPartSettings.Controls.Add(this.label13);
            this.grpMessageBodyPartSettings.Location = new System.Drawing.Point(16, 704);
            this.grpMessageBodyPartSettings.Name = "grpMessageBodyPartSettings";
            this.grpMessageBodyPartSettings.Size = new System.Drawing.Size(1328, 57);
            this.grpMessageBodyPartSettings.TabIndex = 9;
            this.grpMessageBodyPartSettings.TabStop = false;
            this.grpMessageBodyPartSettings.Text = "Message Body Part Settings";
            // 
            // grpRecipients
            // 
            this.grpRecipients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRecipients.Controls.Add(this.txtCC);
            this.grpRecipients.Controls.Add(this.lblTo);
            this.grpRecipients.Controls.Add(this.txtTo);
            this.grpRecipients.Controls.Add(this.lblCC);
            this.grpRecipients.Controls.Add(this.lblBCC);
            this.grpRecipients.Controls.Add(this.txtBCC);
            this.grpRecipients.Controls.Add(this.txtFrom);
            this.grpRecipients.Controls.Add(this.label1);
            this.grpRecipients.Location = new System.Drawing.Point(12, 7);
            this.grpRecipients.Name = "grpRecipients";
            this.grpRecipients.Size = new System.Drawing.Size(667, 148);
            this.grpRecipients.TabIndex = 0;
            this.grpRecipients.TabStop = false;
            this.grpRecipients.Text = "Recipients";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 891);
            this.Controls.Add(this.grpRecipients);
            this.Controls.Add(this.grpMessageBodyPartSettings);
            this.Controls.Add(this.grpAttachments);
            this.Controls.Add(this.grpMailHeaders);
            this.Controls.Add(this.grpSmtpSettings);
            this.Controls.Add(this.cmboBodyType);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblMessageType);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpMessageOptions);
            this.Controls.Add(this.txtBody);
            this.Name = "frmMain";
            this.Text = "CDOSSYS Mailer 1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMessageOptions.ResumeLayout(false);
            this.grpMessageOptions.PerformLayout();
            this.grpSmtpSettings.ResumeLayout(false);
            this.grpSmtpSettings.PerformLayout();
            this.grpUserCreds.ResumeLayout(false);
            this.grpUserCreds.PerformLayout();
            this.grpMailHeaders.ResumeLayout(false);
            this.grpMailHeaders.PerformLayout();
            this.grpAttachments.ResumeLayout(false);
            this.grpAttachments.PerformLayout();
            this.grpMessageBodyPartSettings.ResumeLayout(false);
            this.grpMessageBodyPartSettings.PerformLayout();
            this.grpRecipients.ResumeLayout(false);
            this.grpRecipients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.ComboBox cmboBodyType;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtBCC;
        private System.Windows.Forms.Label lblBCC;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.GroupBox grpMessageOptions;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox grpSmtpSettings;
        private System.Windows.Forms.TextBox txtPickupFolder;
        private System.Windows.Forms.CheckBox chkSpecifyPickupFolder;
        private System.Windows.Forms.RadioButton rdoSendByPickupFolder;
        private System.Windows.Forms.RadioButton chkSendByPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnableSSL;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.GroupBox grpUserCreds;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserSmtp;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRequestReturnReceipt;
        private System.Windows.Forms.TextBox txtMailHeaderName1;
        private System.Windows.Forms.TextBox txtMailHeaderValue1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.GroupBox grpMailHeaders;
        private System.Windows.Forms.TextBox txtMailHeaderValue3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMailHeaderName3;
        private System.Windows.Forms.TextBox txtMailHeaderValue2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMailHeaderName2;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.GroupBox grpAttachments;
        private System.Windows.Forms.CheckBox chkAddAttachment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboAttachmentContentMediaType;
        private System.Windows.Forms.ComboBox cmboContentMediaType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmboCharset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmboContentTransferEncoding;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmboContentClass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmboImportance;
        private System.Windows.Forms.CheckBox chkHeader3;
        private System.Windows.Forms.CheckBox chkHeader2;
        private System.Windows.Forms.CheckBox chkHeader1;
        private System.Windows.Forms.CheckBox chkHeader5;
        private System.Windows.Forms.TextBox txtMailHeaderValue5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMailHeaderName5;
        private System.Windows.Forms.CheckBox chkHeader4;
        private System.Windows.Forms.TextBox txtMailHeaderValue4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMailHeaderName4;
        private System.Windows.Forms.GroupBox grpMessageBodyPartSettings;
        private System.Windows.Forms.ComboBox cmboAttachmentContentTransferEncoding;
        private System.Windows.Forms.ComboBox cmboAttachmentContentClass;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmboAttachmentCharset;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmboAuthentication;
        private System.Windows.Forms.GroupBox grpRecipients;
    }
}

