namespace RSAencryption
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_encrypt = new System.Windows.Forms.TextBox();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.txt_encrypted = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_decrypted = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // txt_encrypt
            // 
            this.txt_encrypt.Location = new System.Drawing.Point(98, 46);
            this.txt_encrypt.Name = "txt_encrypt";
            this.txt_encrypt.Size = new System.Drawing.Size(270, 20);
            this.txt_encrypt.TabIndex = 1;
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(374, 44);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(109, 23);
            this.encrypt_btn.TabIndex = 2;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // txt_encrypted
            // 
            this.txt_encrypted.Location = new System.Drawing.Point(53, 118);
            this.txt_encrypted.Name = "txt_encrypted";
            this.txt_encrypted.Size = new System.Drawing.Size(431, 93);
            this.txt_encrypted.TabIndex = 3;
            this.txt_encrypted.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Text";
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(374, 230);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(109, 23);
            this.decrypt_btn.TabIndex = 5;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted Text";
            // 
            // txt_decrypted
            // 
            this.txt_decrypted.Location = new System.Drawing.Point(53, 286);
            this.txt_decrypted.Name = "txt_decrypted";
            this.txt_decrypted.Size = new System.Drawing.Size(431, 93);
            this.txt_decrypted.TabIndex = 6;
            this.txt_decrypted.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_decrypted);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_encrypted);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.txt_encrypt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_encrypt;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.RichTextBox txt_encrypted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_decrypted;
    }
}

