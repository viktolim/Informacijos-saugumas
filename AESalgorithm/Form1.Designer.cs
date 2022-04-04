
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
            this.GetAts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.createMatricaButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SetAts = new System.Windows.Forms.TextBox();
            this.SifravButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SetModa = new System.Windows.Forms.ComboBox();
            this.setKodas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetMatricaButton
            // 
            this.SetMatricaButton.Location = new System.Drawing.Point(57, 317);
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
            // GetAts
            // 
            this.GetAts.Location = new System.Drawing.Point(9, 157);
            this.GetAts.Name = "GetAts";
            this.GetAts.Size = new System.Drawing.Size(676, 22);
            this.GetAts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Šifruotas tekstas:";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(454, 280);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(125, 158);
            this.dataGrid.TabIndex = 4;
            // 
            // createMatricaButton
            // 
            this.createMatricaButton.Location = new System.Drawing.Point(227, 317);
            this.createMatricaButton.Name = "createMatricaButton";
            this.createMatricaButton.Size = new System.Drawing.Size(143, 33);
            this.createMatricaButton.TabIndex = 6;
            this.createMatricaButton.Text = "Sukurti ";
            this.createMatricaButton.UseVisualStyleBackColor = true;
            this.createMatricaButton.Click += new System.EventHandler(this.createMatricaButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(227, 385);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(143, 33);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Išsaugoti";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SetAts
            // 
            this.SetAts.Location = new System.Drawing.Point(9, 50);
            this.SetAts.Name = "SetAts";
            this.SetAts.Size = new System.Drawing.Size(676, 22);
            this.SetAts.TabIndex = 8;
            // 
            // SifravButton
            // 
            this.SifravButton.Location = new System.Drawing.Point(58, 385);
            this.SifravButton.Name = "SifravButton";
            this.SifravButton.Size = new System.Drawing.Size(143, 33);
            this.SifravButton.TabIndex = 9;
            this.SifravButton.Text = "Šifruoti";
            this.SifravButton.UseVisualStyleBackColor = true;
            this.SifravButton.Click += new System.EventHandler(this.SifravButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.setKodas);
            this.groupBox1.Controls.Add(this.SetModa);
            this.groupBox1.Controls.Add(this.SetAts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GetAts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 201);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Šifravimas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pasirinkite raktą:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pasirinkite modą:";
            // 
            // SetModa
            // 
            this.SetModa.FormattingEnabled = true;
            this.SetModa.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.SetModa.Location = new System.Drawing.Point(125, 81);
            this.SetModa.Name = "SetModa";
            this.SetModa.Size = new System.Drawing.Size(121, 24);
            this.SetModa.TabIndex = 10;
            // 
            // setKodas
            // 
            this.setKodas.FormattingEnabled = true;
            this.setKodas.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.setKodas.Location = new System.Drawing.Point(384, 81);
            this.setKodas.Name = "setKodas";
            this.setKodas.Size = new System.Drawing.Size(121, 24);
            this.setKodas.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SifravButton);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.createMatricaButton);
            this.Controls.Add(this.SetMatricaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetMatricaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GetAts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button createMatricaButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SetAts;
        private System.Windows.Forms.Button SifravButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SetModa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox setKodas;
    }
}

