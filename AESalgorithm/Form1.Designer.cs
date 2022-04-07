
namespace AESalgorithm
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
            this.SetMatricaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getAts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.decryption = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.setText = new System.Windows.Forms.TextBox();
            this.SifravButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setVector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.setKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chooseKey = new System.Windows.Forms.ComboBox();
            this.chooseModa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Encrypted = new System.Windows.Forms.TextBox();
            this.getAtsBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.encryptedAts = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetMatricaButton
            // 
            this.SetMatricaButton.Location = new System.Drawing.Point(435, 473);
            this.SetMatricaButton.Name = "SetMatricaButton";
            this.SetMatricaButton.Size = new System.Drawing.Size(143, 33);
            this.SetMatricaButton.TabIndex = 0;
            this.SetMatricaButton.Text = "Išimti iš failo";
            this.SetMatricaButton.UseVisualStyleBackColor = true;
            this.SetMatricaButton.Click += new System.EventHandler(this.SetMatricaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Įveskite tekstą";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // getAts
            // 
            this.getAts.Location = new System.Drawing.Point(9, 238);
            this.getAts.Name = "getAts";
            this.getAts.Size = new System.Drawing.Size(701, 22);
            this.getAts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Šifruotas tekstas Hex";
            // 
            // decryption
            // 
            this.decryption.Location = new System.Drawing.Point(239, 473);
            this.decryption.Name = "decryption";
            this.decryption.Size = new System.Drawing.Size(143, 33);
            this.decryption.TabIndex = 6;
            this.decryption.Text = "Dešifruoti";
            this.decryption.UseVisualStyleBackColor = true;
            this.decryption.Click += new System.EventHandler(this.createMatricaButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(625, 473);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(143, 33);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Išsaugoti";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // setText
            // 
            this.setText.Location = new System.Drawing.Point(9, 50);
            this.setText.Name = "setText";
            this.setText.Size = new System.Drawing.Size(701, 22);
            this.setText.TabIndex = 8;
            // 
            // SifravButton
            // 
            this.SifravButton.Location = new System.Drawing.Point(45, 473);
            this.SifravButton.Name = "SifravButton";
            this.SifravButton.Size = new System.Drawing.Size(143, 33);
            this.SifravButton.TabIndex = 9;
            this.SifravButton.Text = "Šifruoti";
            this.SifravButton.UseVisualStyleBackColor = true;
            this.SifravButton.Click += new System.EventHandler(this.SifravButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.encryptedAts);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.getAtsBase);
            this.groupBox1.Controls.Add(this.Encrypted);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.setVector);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.setKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.getAts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chooseKey);
            this.groupBox1.Controls.Add(this.chooseModa);
            this.groupBox1.Controls.Add(this.setText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 424);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Šifravimas";
            // 
            // setVector
            // 
            this.setVector.Location = new System.Drawing.Point(302, 120);
            this.setVector.Name = "setVector";
            this.setVector.Size = new System.Drawing.Size(408, 22);
            this.setVector.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Įrašykite vektorių:";
            // 
            // setKey
            // 
            this.setKey.Location = new System.Drawing.Point(9, 182);
            this.setKey.Name = "setKey";
            this.setKey.Size = new System.Drawing.Size(701, 22);
            this.setKey.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Įveskite rakto kodą";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pasirinkite rakto dydį:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pasirinkite modą:";
            // 
            // chooseKey
            // 
            this.chooseKey.FormattingEnabled = true;
            this.chooseKey.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.chooseKey.Location = new System.Drawing.Point(158, 120);
            this.chooseKey.Name = "chooseKey";
            this.chooseKey.Size = new System.Drawing.Size(121, 24);
            this.chooseKey.TabIndex = 10;
            // 
            // chooseModa
            // 
            this.chooseModa.FormattingEnabled = true;
            this.chooseModa.Items.AddRange(new object[] {
            "CBC",
            "ECB"});
            this.chooseModa.Location = new System.Drawing.Point(158, 85);
            this.chooseModa.Name = "chooseModa";
            this.chooseModa.Size = new System.Drawing.Size(121, 24);
            this.chooseModa.TabIndex = 10;
            this.chooseModa.SelectedIndexChanged += new System.EventHandler(this.SetModa_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Šifruotas tekstas Base64";
            // 
            // Encrypted
            // 
            this.Encrypted.Location = new System.Drawing.Point(12, 348);
            this.Encrypted.Name = "Encrypted";
            this.Encrypted.Size = new System.Drawing.Size(698, 22);
            this.Encrypted.TabIndex = 18;
            // 
            // getAtsBase
            // 
            this.getAtsBase.Location = new System.Drawing.Point(9, 296);
            this.getAtsBase.Name = "getAtsBase";
            this.getAtsBase.Size = new System.Drawing.Size(701, 22);
            this.getAtsBase.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dešifruoti tekstą Base64";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Dešifruotas tekstas";
            // 
            // encryptedAts
            // 
            this.encryptedAts.Location = new System.Drawing.Point(15, 397);
            this.encryptedAts.Name = "encryptedAts";
            this.encryptedAts.Size = new System.Drawing.Size(695, 22);
            this.encryptedAts.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SifravButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.decryption);
            this.Controls.Add(this.SetMatricaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetMatricaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getAts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decryption;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox setText;
        private System.Windows.Forms.Button SifravButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox chooseModa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chooseKey;
        private System.Windows.Forms.TextBox setKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox setVector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox getAtsBase;
        private System.Windows.Forms.TextBox Encrypted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox encryptedAts;
        private System.Windows.Forms.Label label8;
    }
}

