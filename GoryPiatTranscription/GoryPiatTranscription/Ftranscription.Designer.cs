namespace GoryPiatTranscription
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ftranscription));
            this.tcTranscription = new System.Windows.Forms.TabControl();
            this.tpEncrypt = new System.Windows.Forms.TabPage();
            this.btOpenEncrypt = new System.Windows.Forms.Button();
            this.btResetEncrypt = new System.Windows.Forms.Button();
            this.btValidationEncrypt = new System.Windows.Forms.Button();
            this.tbTextEncrypt = new System.Windows.Forms.TextBox();
            this.lbPasswordEncrypt = new System.Windows.Forms.Label();
            this.lbTextEncrypt = new System.Windows.Forms.Label();
            this.tbPasswordEncrypt = new System.Windows.Forms.TextBox();
            this.tpDecrypt = new System.Windows.Forms.TabPage();
            this.btOpenDecrypt = new System.Windows.Forms.Button();
            this.btResetDecrypt = new System.Windows.Forms.Button();
            this.btValidationDecrypt = new System.Windows.Forms.Button();
            this.tbTextDecrypt = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbTexte = new System.Windows.Forms.Label();
            this.tbPasswordDecrypt = new System.Windows.Forms.TextBox();
            this.ilTranscription = new System.Windows.Forms.ImageList(this.components);
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
            this.tcTranscription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcTranscription.ImageList = this.ilTranscription;
            this.tcTranscription.ItemSize = new System.Drawing.Size(150, 30);
            this.tcTranscription.Location = new System.Drawing.Point(0, 0);
            this.tcTranscription.Multiline = true;
            this.tcTranscription.Name = "tcTranscription";
            this.tcTranscription.SelectedIndex = 0;
            this.tcTranscription.Size = new System.Drawing.Size(603, 404);
            this.tcTranscription.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTranscription.TabIndex = 0;
            // 
            // tpEncrypt
            // 
            this.tpEncrypt.Controls.Add(this.btOpenEncrypt);
            this.tpEncrypt.Controls.Add(this.btResetEncrypt);
            this.tpEncrypt.Controls.Add(this.btValidationEncrypt);
            this.tpEncrypt.Controls.Add(this.tbTextEncrypt);
            this.tpEncrypt.Controls.Add(this.lbPasswordEncrypt);
            this.tpEncrypt.Controls.Add(this.lbTextEncrypt);
            this.tpEncrypt.Controls.Add(this.tbPasswordEncrypt);
            this.tpEncrypt.ImageIndex = 0;
            this.tpEncrypt.Location = new System.Drawing.Point(4, 34);
            this.tpEncrypt.Name = "tpEncrypt";
            this.tpEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpEncrypt.Size = new System.Drawing.Size(595, 366);
            this.tpEncrypt.TabIndex = 0;
            this.tpEncrypt.Text = "Encryptage";
            this.tpEncrypt.UseVisualStyleBackColor = true;
            // 
            // btOpenEncrypt
            // 
            this.btOpenEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btOpenEncrypt.Location = new System.Drawing.Point(67, 10);
            this.btOpenEncrypt.Name = "btOpenEncrypt";
            this.btOpenEncrypt.Size = new System.Drawing.Size(54, 20);
            this.btOpenEncrypt.TabIndex = 10;
            this.btOpenEncrypt.Text = "Ouvrir";
            this.btOpenEncrypt.UseVisualStyleBackColor = true;
            this.btOpenEncrypt.Click += new System.EventHandler(this.btOpenEncrypt_Click);
            // 
            // btResetEncrypt
            // 
            this.btResetEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResetEncrypt.Location = new System.Drawing.Point(295, 329);
            this.btResetEncrypt.Name = "btResetEncrypt";
            this.btResetEncrypt.Size = new System.Drawing.Size(143, 29);
            this.btResetEncrypt.TabIndex = 8;
            this.btResetEncrypt.Text = "Reset";
            this.btResetEncrypt.UseVisualStyleBackColor = true;
            this.btResetEncrypt.Click += new System.EventHandler(this.btResetEncrypt_Click);
            // 
            // btValidationEncrypt
            // 
            this.btValidationEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btValidationEncrypt.Location = new System.Drawing.Point(444, 329);
            this.btValidationEncrypt.Name = "btValidationEncrypt";
            this.btValidationEncrypt.Size = new System.Drawing.Size(143, 29);
            this.btValidationEncrypt.TabIndex = 9;
            this.btValidationEncrypt.Text = "Valider";
            this.btValidationEncrypt.UseVisualStyleBackColor = true;
            this.btValidationEncrypt.Click += new System.EventHandler(this.btValidationEncrypt_Click);
            // 
            // tbTextEncrypt
            // 
            this.tbTextEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextEncrypt.Location = new System.Drawing.Point(8, 33);
            this.tbTextEncrypt.Multiline = true;
            this.tbTextEncrypt.Name = "tbTextEncrypt";
            this.tbTextEncrypt.Size = new System.Drawing.Size(579, 254);
            this.tbTextEncrypt.TabIndex = 7;
            // 
            // lbPasswordEncrypt
            // 
            this.lbPasswordEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPasswordEncrypt.AutoSize = true;
            this.lbPasswordEncrypt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordEncrypt.Location = new System.Drawing.Point(1, 288);
            this.lbPasswordEncrypt.Name = "lbPasswordEncrypt";
            this.lbPasswordEncrypt.Size = new System.Drawing.Size(120, 25);
            this.lbPasswordEncrypt.TabIndex = 5;
            this.lbPasswordEncrypt.Text = "Mot de passe";
            // 
            // lbTextEncrypt
            // 
            this.lbTextEncrypt.AutoSize = true;
            this.lbTextEncrypt.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextEncrypt.Location = new System.Drawing.Point(8, 5);
            this.lbTextEncrypt.Name = "lbTextEncrypt";
            this.lbTextEncrypt.Size = new System.Drawing.Size(51, 25);
            this.lbTextEncrypt.TabIndex = 6;
            this.lbTextEncrypt.Text = "Texte";
            // 
            // tbPasswordEncrypt
            // 
            this.tbPasswordEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPasswordEncrypt.Location = new System.Drawing.Point(127, 293);
            this.tbPasswordEncrypt.Name = "tbPasswordEncrypt";
            this.tbPasswordEncrypt.Size = new System.Drawing.Size(460, 22);
            this.tbPasswordEncrypt.TabIndex = 4;
            // 
            // tpDecrypt
            // 
            this.tpDecrypt.Controls.Add(this.btOpenDecrypt);
            this.tpDecrypt.Controls.Add(this.btResetDecrypt);
            this.tpDecrypt.Controls.Add(this.btValidationDecrypt);
            this.tpDecrypt.Controls.Add(this.tbTextDecrypt);
            this.tpDecrypt.Controls.Add(this.lbPassword);
            this.tpDecrypt.Controls.Add(this.lbTexte);
            this.tpDecrypt.Controls.Add(this.tbPasswordDecrypt);
            this.tpDecrypt.ImageIndex = 1;
            this.tpDecrypt.Location = new System.Drawing.Point(4, 34);
            this.tpDecrypt.Name = "tpDecrypt";
            this.tpDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecrypt.Size = new System.Drawing.Size(595, 366);
            this.tpDecrypt.TabIndex = 1;
            this.tpDecrypt.Text = "Decryptage";
            this.tpDecrypt.UseVisualStyleBackColor = true;
            // 
            // btOpenDecrypt
            // 
            this.btOpenDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btOpenDecrypt.Location = new System.Drawing.Point(67, 10);
            this.btOpenDecrypt.Name = "btOpenDecrypt";
            this.btOpenDecrypt.Size = new System.Drawing.Size(54, 20);
            this.btOpenDecrypt.TabIndex = 11;
            this.btOpenDecrypt.Text = "Ouvrir";
            this.btOpenDecrypt.UseVisualStyleBackColor = true;
            this.btOpenDecrypt.Click += new System.EventHandler(this.btOpenDecrypt_Click);
            // 
            // btResetDecrypt
            // 
            this.btResetDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btResetDecrypt.Location = new System.Drawing.Point(295, 329);
            this.btResetDecrypt.Name = "btResetDecrypt";
            this.btResetDecrypt.Size = new System.Drawing.Size(143, 29);
            this.btResetDecrypt.TabIndex = 3;
            this.btResetDecrypt.Text = "Reset";
            this.btResetDecrypt.UseVisualStyleBackColor = true;
            this.btResetDecrypt.Click += new System.EventHandler(this.btResetDecrypt_Click);
            // 
            // btValidationDecrypt
            // 
            this.btValidationDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btValidationDecrypt.Location = new System.Drawing.Point(444, 329);
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
            this.tbTextDecrypt.Size = new System.Drawing.Size(579, 254);
            this.tbTextDecrypt.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(1, 288);
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
            this.tbPasswordDecrypt.Location = new System.Drawing.Point(127, 293);
            this.tbPasswordDecrypt.Name = "tbPasswordDecrypt";
            this.tbPasswordDecrypt.Size = new System.Drawing.Size(460, 22);
            this.tbPasswordDecrypt.TabIndex = 0;
            // 
            // ilTranscription
            // 
            this.ilTranscription.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTranscription.ImageStream")));
            this.ilTranscription.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTranscription.Images.SetKeyName(0, "cadenas_ferme.png");
            this.ilTranscription.Images.SetKeyName(1, "cadenas_ouvert.png");
            // 
            // Ftranscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 404);
            this.Controls.Add(this.tcTranscription);
            this.MinimumSize = new System.Drawing.Size(336, 238);
            this.Name = "Ftranscription";
            this.Text = "Transcription";
            this.Load += new System.EventHandler(this.Ftranscription_Load);
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
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btResetDecrypt;
        private System.Windows.Forms.Button btValidationDecrypt;
        private System.Windows.Forms.ImageList ilTranscription;
        private System.Windows.Forms.Button btResetEncrypt;
        private System.Windows.Forms.Button btValidationEncrypt;
        private System.Windows.Forms.TextBox tbTextEncrypt;
        private System.Windows.Forms.Label lbPasswordEncrypt;
        private System.Windows.Forms.Label lbTextEncrypt;
        private System.Windows.Forms.TextBox tbPasswordEncrypt;
        private System.Windows.Forms.Button btOpenEncrypt;
        private System.Windows.Forms.Button btOpenDecrypt;
    }
}

