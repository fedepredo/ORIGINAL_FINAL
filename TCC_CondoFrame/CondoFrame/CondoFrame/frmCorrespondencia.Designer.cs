namespace CondoFrame
{
    partial class frmCorrespondencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorrespondencia));
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupMessage = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radContentHtml = new System.Windows.Forms.RadioButton();
            this.radContentText = new System.Windows.Forms.RadioButton();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupSmtp = new System.Windows.Forms.GroupBox();
            this.chkSmtpSsl = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSmtpHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSmtpPassword = new System.Windows.Forms.TextBox();
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.txtSmtpUser = new System.Windows.Forms.TextBox();
            this.groupAddress = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.groupButtons.SuspendLayout();
            this.groupMessage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupSmtp.SuspendLayout();
            this.groupAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupButtons
            // 
            this.groupButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupButtons.Controls.Add(this.lblStatus);
            this.groupButtons.Controls.Add(this.btnSend);
            this.groupButtons.Location = new System.Drawing.Point(6, 598);
            this.groupButtons.Margin = new System.Windows.Forms.Padding(4);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Padding = new System.Windows.Forms.Padding(4);
            this.groupButtons.Size = new System.Drawing.Size(873, 66);
            this.groupButtons.TabIndex = 8;
            this.groupButtons.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(30, 25);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(634, 31);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "[status]";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(744, 22);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 34);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // groupMessage
            // 
            this.groupMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMessage.Controls.Add(this.label7);
            this.groupMessage.Controls.Add(this.label8);
            this.groupMessage.Controls.Add(this.groupBox4);
            this.groupMessage.Controls.Add(this.txtSubject);
            this.groupMessage.Controls.Add(this.txtMessage);
            this.groupMessage.Location = new System.Drawing.Point(6, 250);
            this.groupMessage.Margin = new System.Windows.Forms.Padding(4);
            this.groupMessage.Name = "groupMessage";
            this.groupMessage.Padding = new System.Windows.Forms.Padding(4);
            this.groupMessage.Size = new System.Drawing.Size(876, 340);
            this.groupMessage.TabIndex = 9;
            this.groupMessage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mensagem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Assunto";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.radContentHtml);
            this.groupBox4.Controls.Add(this.radContentText);
            this.groupBox4.Location = new System.Drawing.Point(650, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(199, 59);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Conteúdo";
            // 
            // radContentHtml
            // 
            this.radContentHtml.AutoSize = true;
            this.radContentHtml.Location = new System.Drawing.Point(95, 23);
            this.radContentHtml.Margin = new System.Windows.Forms.Padding(4);
            this.radContentHtml.Name = "radContentHtml";
            this.radContentHtml.Size = new System.Drawing.Size(67, 21);
            this.radContentHtml.TabIndex = 1;
            this.radContentHtml.TabStop = true;
            this.radContentHtml.Text = "HTML";
            this.radContentHtml.UseVisualStyleBackColor = true;
            // 
            // radContentText
            // 
            this.radContentText.AutoSize = true;
            this.radContentText.Checked = true;
            this.radContentText.Location = new System.Drawing.Point(25, 25);
            this.radContentText.Margin = new System.Windows.Forms.Padding(4);
            this.radContentText.Name = "radContentText";
            this.radContentText.Size = new System.Drawing.Size(64, 21);
            this.radContentText.TabIndex = 0;
            this.radContentText.TabStop = true;
            this.radContentText.Text = "Texto";
            this.radContentText.UseVisualStyleBackColor = true;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(80, 48);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(549, 22);
            this.txtSubject.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(19, 119);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(829, 212);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.WordWrap = false;
            // 
            // groupSmtp
            // 
            this.groupSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSmtp.Controls.Add(this.chkSmtpSsl);
            this.groupSmtp.Controls.Add(this.label5);
            this.groupSmtp.Controls.Add(this.label6);
            this.groupSmtp.Controls.Add(this.label4);
            this.groupSmtp.Controls.Add(this.txtSmtpHost);
            this.groupSmtp.Controls.Add(this.label3);
            this.groupSmtp.Controls.Add(this.txtSmtpPassword);
            this.groupSmtp.Controls.Add(this.txtSmtpPort);
            this.groupSmtp.Controls.Add(this.txtSmtpUser);
            this.groupSmtp.Location = new System.Drawing.Point(580, 20);
            this.groupSmtp.Margin = new System.Windows.Forms.Padding(4);
            this.groupSmtp.Name = "groupSmtp";
            this.groupSmtp.Padding = new System.Windows.Forms.Padding(4);
            this.groupSmtp.Size = new System.Drawing.Size(299, 222);
            this.groupSmtp.TabIndex = 7;
            this.groupSmtp.TabStop = false;
            this.groupSmtp.Text = "Servidor SMTP";
            // 
            // chkSmtpSsl
            // 
            this.chkSmtpSsl.AutoSize = true;
            this.chkSmtpSsl.Checked = true;
            this.chkSmtpSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSmtpSsl.Location = new System.Drawing.Point(101, 107);
            this.chkSmtpSsl.Margin = new System.Windows.Forms.Padding(4);
            this.chkSmtpSsl.Name = "chkSmtpSsl";
            this.chkSmtpSsl.Size = new System.Drawing.Size(90, 21);
            this.chkSmtpSsl.TabIndex = 4;
            this.chkSmtpSsl.Text = "Usar SSL";
            this.chkSmtpSsl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Porta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuário";
            // 
            // txtSmtpHost
            // 
            this.txtSmtpHost.Location = new System.Drawing.Point(101, 36);
            this.txtSmtpHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtpHost.Name = "txtSmtpHost";
            this.txtSmtpHost.Size = new System.Drawing.Size(169, 22);
            this.txtSmtpHost.TabIndex = 1;
            this.txtSmtpHost.Text = "smtp.gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Servidor";
            // 
            // txtSmtpPassword
            // 
            this.txtSmtpPassword.Location = new System.Drawing.Point(101, 177);
            this.txtSmtpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtpPassword.Name = "txtSmtpPassword";
            this.txtSmtpPassword.PasswordChar = '*';
            this.txtSmtpPassword.Size = new System.Drawing.Size(169, 22);
            this.txtSmtpPassword.TabIndex = 8;
            this.txtSmtpPassword.Text = "tcccondoframe";
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(101, 73);
            this.txtSmtpPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(71, 22);
            this.txtSmtpPort.TabIndex = 3;
            this.txtSmtpPort.Text = "587";
            // 
            // txtSmtpUser
            // 
            this.txtSmtpUser.Location = new System.Drawing.Point(101, 145);
            this.txtSmtpUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtpUser.Name = "txtSmtpUser";
            this.txtSmtpUser.Size = new System.Drawing.Size(169, 22);
            this.txtSmtpUser.TabIndex = 6;
            this.txtSmtpUser.Text = "condoframe@gmail.com";
            // 
            // groupAddress
            // 
            this.groupAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAddress.Controls.Add(this.label2);
            this.groupAddress.Controls.Add(this.label1);
            this.groupAddress.Controls.Add(this.txtTo);
            this.groupAddress.Controls.Add(this.txtFrom);
            this.groupAddress.Location = new System.Drawing.Point(6, 20);
            this.groupAddress.Margin = new System.Windows.Forms.Padding(4);
            this.groupAddress.Name = "groupAddress";
            this.groupAddress.Padding = new System.Windows.Forms.Padding(4);
            this.groupAddress.Size = new System.Drawing.Size(549, 222);
            this.groupAddress.TabIndex = 6;
            this.groupAddress.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destinatário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remetente";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(113, 73);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(379, 22);
            this.txtTo.TabIndex = 3;
            this.txtTo.Text = "condoframe@gmail.com";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(113, 41);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(379, 22);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.Text = "condoframe@gmail.com";
            // 
            // frmCorrespondencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 684);
            this.Controls.Add(this.groupButtons);
            this.Controls.Add(this.groupMessage);
            this.Controls.Add(this.groupSmtp);
            this.Controls.Add(this.groupAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCorrespondencia";
            this.Text = "Correspondência";
            this.Load += new System.EventHandler(this.frmCorrespondencia_Load);
            this.groupButtons.ResumeLayout(false);
            this.groupMessage.ResumeLayout(false);
            this.groupMessage.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupSmtp.ResumeLayout(false);
            this.groupSmtp.PerformLayout();
            this.groupAddress.ResumeLayout(false);
            this.groupAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupButtons;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radContentHtml;
        private System.Windows.Forms.RadioButton radContentText;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupSmtp;
        private System.Windows.Forms.CheckBox chkSmtpSsl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSmtpHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSmtpPassword;
        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.TextBox txtSmtpUser;
        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
    }
}