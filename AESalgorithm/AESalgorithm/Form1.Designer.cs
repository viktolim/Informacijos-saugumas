
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
            this.label3 = new System.Windows.Forms.Label();
            this.createMatricaButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SetAts = new System.Windows.Forms.TextBox();
            this.SifravButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifruojamas skaičius:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GetAts
            // 
            this.GetAts.Location = new System.Drawing.Point(207, 69);
            this.GetAts.Name = "GetAts";
            this.GetAts.Size = new System.Drawing.Size(100, 22);
            this.GetAts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gaunama:";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(57, 141);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(687, 158);
            this.dataGrid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matrica:";
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
            this.SetAts.Location = new System.Drawing.Point(207, 28);
            this.SetAts.Name = "SetAts";
            this.SetAts.Size = new System.Drawing.Size(100, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SifravButton);
            this.Controls.Add(this.SetAts);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.createMatricaButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetAts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetMatricaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetMatricaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GetAts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createMatricaButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SetAts;
        private System.Windows.Forms.Button SifravButton;
    }
}

