﻿namespace GoryPiatTranscription
{
    partial class Ftranscription
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
            this.tcTranscription = new System.Windows.Forms.TabControl();
            this.tpEncrypt = new System.Windows.Forms.TabPage();
            this.btResetEncrypt = new System.Windows.Forms.Button();
            this.btValidationEncrypt = new System.Windows.Forms.Button();
            this.tbTextEncrypt = new System.Windows.Forms.TextBox();
            this.lbPassword2 = new System.Windows.Forms.Label();
            this.lbText2 = new System.Windows.Forms.Label();
            this.tbPasswordEncrypt = new System.Windows.Forms.TextBox();
            this.tpDecrypt = new System.Windows.Forms.TabPage();
            this.btResetDecrypt = new System.Windows.Forms.Button();
            this.btValidationDecrypt = new System.Windows.Forms.Button();
            this.tbTextDecrypt = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTexte = new System.Windows.Forms.Label();
            this.tbPasswordDecrypt = new System.Windows.Forms.TextBox();
            this.tcTranscription.SuspendLayout();
            this.tpEncrypt.SuspendLayout();
            this.tpDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTranscription
            // 
            this.tcTranscription.Controls.Add(this.tpEncrypt);
            this.tcTranscription.Controls.Add(this.tpDecrypt);
            this.tcTranscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTranscription.Location = new System.Drawing.Point(0, 0);
            this.tcTranscription.Name = "tcTranscription";
            this.tcTranscription.SelectedIndex = 0;
            this.tcTranscription.Size = new System.Drawing.Size(756, 419);
            this.tcTranscription.TabIndex = 0;
            // 
            // tpEncrypt
            // 
            this.tpEncrypt.Controls.Add(this.btResetEncrypt);
            this.tpEncrypt.Controls.Add(this.btValidationEncrypt);
            this.tpEncrypt.Controls.Add(this.tbTextEncrypt);
            this.tpEncrypt.Controls.Add(this.lbPassword2);
            this.tpEncrypt.Controls.Add(this.lbText2);
            this.tpEncrypt.Controls.Add(this.tbPasswordEncrypt);
            this.tpEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tpEncrypt.Name = "tpEncrypt";
            this.tpEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncrypt.Size = new System.Drawing.Size(748, 393);
            this.tpEncrypt.TabIndex = 0;
            this.tpEncrypt.Text = "Encryptage";
            this.tpEncrypt.UseVisualStyleBackColor = true;
            // 
            // btResetEncrypt
            // 
            this.btResetEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResetEncrypt.Location = new System.Drawing.Point(448, 356);
            this.btResetEncrypt.Name = "btResetEncrypt";
            this.btResetEncrypt.Size = new System.Drawing.Size(143, 29);
            this.btResetEncrypt.TabIndex = 4;
            this.btResetEncrypt.Text = "Reset";
            this.btResetEncrypt.UseVisualStyleBackColor = true;
            this.btResetEncrypt.Click += new System.EventHandler(this.btResetEncrypt_Click);
            // 
            // btValidationEncrypt
            // 
            this.btValidationEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btValidationEncrypt.Location = new System.Drawing.Point(597, 356);
            this.btValidationEncrypt.Name = "btValidationEncrypt";
            this.btValidationEncrypt.Size = new System.Drawing.Size(143, 29);
            this.btValidationEncrypt.TabIndex = 3;
            this.btValidationEncrypt.Text = "Valider";
            this.btValidationEncrypt.UseVisualStyleBackColor = true;
            this.btValidationEncrypt.Click += new System.EventHandler(this.btValidationEncrypt_Click);
            // 
            // tbTextEncrypt
            // 
            this.tbTextEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextEncrypt.Location = new System.Drawing.Point(6, 33);
            this.tbTextEncrypt.Multiline = true;
            this.tbTextEncrypt.Name = "tbTextEncrypt";
            this.tbTextEncrypt.Size = new System.Drawing.Size(675, 282);
            this.tbTextEncrypt.TabIndex = 1;
            // 
            // lbPassword2
            // 
            this.lbPassword2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPassword2.AutoSize = true;
            this.lbPassword2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword2.Location = new System.Drawing.Point(1, 317);
            this.lbPassword2.Name = "lbPassword2";
            this.lbPassword2.Size = new System.Drawing.Size(120, 25);
            this.lbPassword2.TabIndex = 4;
            this.lbPassword2.Text = "Mot de passe";
            // 
            // lbText2
            // 
            this.lbText2.AutoSize = true;
            this.lbText2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText2.Location = new System.Drawing.Point(8, 5);
            this.lbText2.Name = "lbText2";
            this.lbText2.Size = new System.Drawing.Size(51, 25);
            this.lbText2.TabIndex = 5;
            this.lbText2.Text = "Texte";
            // 
            // tbPasswordEncrypt
            // 
            this.tbPasswordEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordEncrypt.Location = new System.Drawing.Point(129, 321);
            this.tbPasswordEncrypt.Name = "tbPasswordEncrypt";
            this.tbPasswordEncrypt.Size = new System.Drawing.Size(552, 20);
            this.tbPasswordEncrypt.TabIndex = 2;
            // 
            // tpDecrypt
            // 
            this.tpDecrypt.Controls.Add(this.btResetDecrypt);
            this.tpDecrypt.Controls.Add(this.btValidationDecrypt);
            this.tpDecrypt.Controls.Add(this.tbTextDecrypt);
            this.tpDecrypt.Controls.Add(this.lbPassword);
            this.tpDecrypt.Controls.Add(this.lbTexte);
            this.tpDecrypt.Controls.Add(this.tbPasswordDecrypt);
            this.tpDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tpDecrypt.Name = "tpDecrypt";
            this.tpDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecrypt.Size = new System.Drawing.Size(748, 393);
            this.tpDecrypt.TabIndex = 1;
            this.tpDecrypt.Text = "Decryptage";
            this.tpDecrypt.UseVisualStyleBackColor = true;
            // 
            // btResetDecrypt
            // 
            this.btResetDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResetDecrypt.Location = new System.Drawing.Point(448, 356);
            this.btResetDecrypt.Name = "btResetDecrypt";
            this.btResetDecrypt.Size = new System.Drawing.Size(143, 29);
            this.btResetDecrypt.TabIndex = 4;
            this.btResetDecrypt.Text = "Reset";
            this.btResetDecrypt.UseVisualStyleBackColor = true;
            this.btResetDecrypt.Click += new System.EventHandler(this.btResetDecrypt_Click);
            // 
            // btValidationDecrypt
            // 
            this.btValidationDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btValidationDecrypt.Location = new System.Drawing.Point(597, 356);
            this.btValidationDecrypt.Name = "btValidationDecrypt";
            this.btValidationDecrypt.Size = new System.Drawing.Size(143, 29);
            this.btValidationDecrypt.TabIndex = 3;
            this.btValidationDecrypt.Text = "Valider";
            this.btValidationDecrypt.UseVisualStyleBackColor = true;
            this.btValidationDecrypt.Click += new System.EventHandler(this.btValidationDecrypt_Click);
            // 
            // tbTextDecrypt
            // 
            this.tbTextDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextDecrypt.Location = new System.Drawing.Point(8, 33);
            this.tbTextDecrypt.Multiline = true;
            this.tbTextDecrypt.Name = "tbTextDecrypt";
            this.tbTextDecrypt.Size = new System.Drawing.Size(691, 281);
            this.tbTextDecrypt.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(-1, 316);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(120, 25);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mot de passe";
            // 
            // lbTexte
            // 
            this.lbTexte.AutoSize = true;
            this.lbTexte.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexte.Location = new System.Drawing.Point(8, 5);
            this.lbTexte.Name = "lbTexte";
            this.lbTexte.Size = new System.Drawing.Size(51, 25);
            this.lbTexte.TabIndex = 1;
            this.lbTexte.Text = "Texte";
            // 
            // tbPasswordDecrypt
            // 
            this.tbPasswordDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordDecrypt.Location = new System.Drawing.Point(127, 320);
            this.tbPasswordDecrypt.Name = "tbPasswordDecrypt";
            this.tbPasswordDecrypt.Size = new System.Drawing.Size(570, 20);
            this.tbPasswordDecrypt.TabIndex = 2;
            // 
            // Ftranscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 419);
            this.Controls.Add(this.tcTranscription);
            this.Name = "Ftranscription";
            this.Text = "Transcription";
            this.tcTranscription.ResumeLayout(false);
            this.tpEncrypt.ResumeLayout(false);
            this.tpEncrypt.PerformLayout();
            this.tpDecrypt.ResumeLayout(false);
            this.tpDecrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTranscription;
        private System.Windows.Forms.TabPage tpEncrypt;
        private System.Windows.Forms.TabPage tpDecrypt;
        private System.Windows.Forms.TextBox tbTextDecrypt;
        private System.Windows.Forms.Label lbTexte;
        private System.Windows.Forms.TextBox tbPasswordDecrypt;
        private System.Windows.Forms.TextBox tbTextEncrypt;
        private System.Windows.Forms.Label lbPassword2;
        private System.Windows.Forms.Label lbText2;
        private System.Windows.Forms.TextBox tbPasswordEncrypt;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btResetEncrypt;
        private System.Windows.Forms.Button btValidationEncrypt;
        private System.Windows.Forms.Button btResetDecrypt;
        private System.Windows.Forms.Button btValidationDecrypt;
    }
}

