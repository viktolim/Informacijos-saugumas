
namespace WindowsFormsApp1
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
            this.Button = new System.Windows.Forms.Button();
            this.SetText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kSet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(123, 199);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(119, 31);
            this.Button.TabIndex = 0;
            this.Button.Text = "Užšifruoti tekstą";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // SetText
            // 
            this.SetText.Location = new System.Drawing.Point(205, 123);
            this.SetText.Name = "SetText";
            this.SetText.Size = new System.Drawing.Size(100, 22);
            this.SetText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pradinis tekstas:";
            // 
            // kSet
            // 
            this.kSet.Location = new System.Drawing.Point(205, 151);
            this.kSet.Name = "kSet";
            this.kSet.Size = new System.Drawing.Size(100, 22);
            this.kSet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Poslinkis:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(257, 199);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(119, 31);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Dešifruoti tekstą";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetText);
            this.Controls.Add(this.Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox SetText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown kSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button1;
    }
}

