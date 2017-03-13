namespace szyfr
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.boxUnencText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCipherText = new System.Windows.Forms.TextBox();
            this.textCipher = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.rsaEncryptedTextBytes = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rsaPlainTextBytes = new System.Windows.Forms.RichTextBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.rsaDecryptText = new System.Windows.Forms.RichTextBox();
            this.rsaEncryptText = new System.Windows.Forms.RichTextBox();
            this.rsaPlainText = new System.Windows.Forms.RichTextBox();
            this.privateKeyBox = new System.Windows.Forms.RichTextBox();
            this.publicKeyBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rsaDecryptButton = new System.Windows.Forms.Button();
            this.rsaEncryptButton = new System.Windows.Forms.Button();
            this.generateRSAkeys = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encryptButton.Location = new System.Drawing.Point(91, 86);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(165, 61);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Zaszyfruj";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decryptButton.Location = new System.Drawing.Point(321, 86);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(165, 61);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Odszyfruj";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // boxUnencText
            // 
            this.boxUnencText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxUnencText.Location = new System.Drawing.Point(6, 35);
            this.boxUnencText.Name = "boxUnencText";
            this.boxUnencText.Size = new System.Drawing.Size(606, 26);
            this.boxUnencText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tekst jawny";
            // 
            // boxCipherText
            // 
            this.boxCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxCipherText.Location = new System.Drawing.Point(6, 189);
            this.boxCipherText.Name = "boxCipherText";
            this.boxCipherText.Size = new System.Drawing.Size(606, 26);
            this.boxCipherText.TabIndex = 4;
            // 
            // textCipher
            // 
            this.textCipher.AutoSize = true;
            this.textCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textCipher.Location = new System.Drawing.Point(6, 166);
            this.textCipher.Name = "textCipher";
            this.textCipher.Size = new System.Drawing.Size(138, 20);
            this.textCipher.TabIndex = 5;
            this.textCipher.Text = "Text zaszyfrowany";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 537);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.boxUnencText);
            this.tabPage1.Controls.Add(this.boxCipherText);
            this.tabPage1.Controls.Add(this.textCipher);
            this.tabPage1.Controls.Add(this.encryptButton);
            this.tabPage1.Controls.Add(this.decryptButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Szyfr Cezara";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.rsaEncryptedTextBytes);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.rsaPlainTextBytes);
            this.tabPage2.Controls.Add(this.helpButton);
            this.tabPage2.Controls.Add(this.rsaDecryptText);
            this.tabPage2.Controls.Add(this.rsaEncryptText);
            this.tabPage2.Controls.Add(this.rsaPlainText);
            this.tabPage2.Controls.Add(this.privateKeyBox);
            this.tabPage2.Controls.Add(this.publicKeyBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rsaDecryptButton);
            this.tabPage2.Controls.Add(this.rsaEncryptButton);
            this.tabPage2.Controls.Add(this.generateRSAkeys);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RSA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(396, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tekst zaszyfrowany (szesnastkowo):";
            // 
            // rsaEncryptedTextBytes
            // 
            this.rsaEncryptedTextBytes.Location = new System.Drawing.Point(396, 344);
            this.rsaEncryptedTextBytes.Name = "rsaEncryptedTextBytes";
            this.rsaEncryptedTextBytes.Size = new System.Drawing.Size(231, 69);
            this.rsaEncryptedTextBytes.TabIndex = 21;
            this.rsaEncryptedTextBytes.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(396, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tekst jawny (szesnastkowo):";
            // 
            // rsaPlainTextBytes
            // 
            this.rsaPlainTextBytes.Location = new System.Drawing.Point(396, 252);
            this.rsaPlainTextBytes.Name = "rsaPlainTextBytes";
            this.rsaPlainTextBytes.Size = new System.Drawing.Size(231, 69);
            this.rsaPlainTextBytes.TabIndex = 19;
            this.rsaPlainTextBytes.Text = "";
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpButton.Location = new System.Drawing.Point(633, 436);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(113, 69);
            this.helpButton.TabIndex = 18;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // rsaDecryptText
            // 
            this.rsaDecryptText.Location = new System.Drawing.Point(6, 436);
            this.rsaDecryptText.Name = "rsaDecryptText";
            this.rsaDecryptText.ReadOnly = true;
            this.rsaDecryptText.Size = new System.Drawing.Size(621, 69);
            this.rsaDecryptText.TabIndex = 17;
            this.rsaDecryptText.Text = "";
            // 
            // rsaEncryptText
            // 
            this.rsaEncryptText.Location = new System.Drawing.Point(6, 344);
            this.rsaEncryptText.Name = "rsaEncryptText";
            this.rsaEncryptText.ReadOnly = true;
            this.rsaEncryptText.Size = new System.Drawing.Size(384, 69);
            this.rsaEncryptText.TabIndex = 16;
            this.rsaEncryptText.Text = "";
            // 
            // rsaPlainText
            // 
            this.rsaPlainText.Location = new System.Drawing.Point(6, 252);
            this.rsaPlainText.Name = "rsaPlainText";
            this.rsaPlainText.Size = new System.Drawing.Size(384, 69);
            this.rsaPlainText.TabIndex = 15;
            this.rsaPlainText.Text = "";
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(6, 114);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.Size = new System.Drawing.Size(740, 87);
            this.privateKeyBox.TabIndex = 14;
            this.privateKeyBox.Text = "";
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.Location = new System.Drawing.Point(6, 26);
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.Size = new System.Drawing.Size(658, 69);
            this.publicKeyBox.TabIndex = 13;
            this.publicKeyBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tekst rozszyfrowany:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tekst zaszyfrowany:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tekst jawny:";
            // 
            // rsaDecryptButton
            // 
            this.rsaDecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rsaDecryptButton.Location = new System.Drawing.Point(633, 344);
            this.rsaDecryptButton.Name = "rsaDecryptButton";
            this.rsaDecryptButton.Size = new System.Drawing.Size(113, 69);
            this.rsaDecryptButton.TabIndex = 9;
            this.rsaDecryptButton.Text = "Odszyfruj";
            this.rsaDecryptButton.UseVisualStyleBackColor = true;
            this.rsaDecryptButton.Click += new System.EventHandler(this.rsaDecryptButton_Click);
            // 
            // rsaEncryptButton
            // 
            this.rsaEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rsaEncryptButton.Location = new System.Drawing.Point(633, 252);
            this.rsaEncryptButton.Name = "rsaEncryptButton";
            this.rsaEncryptButton.Size = new System.Drawing.Size(113, 69);
            this.rsaEncryptButton.TabIndex = 8;
            this.rsaEncryptButton.Text = "Zaszyfruj";
            this.rsaEncryptButton.UseVisualStyleBackColor = true;
            this.rsaEncryptButton.Click += new System.EventHandler(this.rsaEncryptButton_Click);
            // 
            // generateRSAkeys
            // 
            this.generateRSAkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generateRSAkeys.Location = new System.Drawing.Point(670, 26);
            this.generateRSAkeys.Name = "generateRSAkeys";
            this.generateRSAkeys.Size = new System.Drawing.Size(76, 69);
            this.generateRSAkeys.TabIndex = 4;
            this.generateRSAkeys.Text = "Generuj klucze";
            this.generateRSAkeys.UseVisualStyleBackColor = true;
            this.generateRSAkeys.Click += new System.EventHandler(this.generateRSAkeys_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Klucz publiczny i prywatny (XML):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klucz publiczny (XML):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Szyfrowanie";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox boxUnencText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxCipherText;
        private System.Windows.Forms.Label textCipher;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateRSAkeys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rsaDecryptButton;
        private System.Windows.Forms.Button rsaEncryptButton;
        private System.Windows.Forms.RichTextBox privateKeyBox;
        private System.Windows.Forms.RichTextBox publicKeyBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.RichTextBox rsaDecryptText;
        private System.Windows.Forms.RichTextBox rsaEncryptText;
        private System.Windows.Forms.RichTextBox rsaPlainText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rsaPlainTextBytes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rsaEncryptedTextBytes;
    }
}

