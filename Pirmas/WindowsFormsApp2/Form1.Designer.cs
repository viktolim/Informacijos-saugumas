
namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetText = new System.Windows.Forms.TextBox();
            this.SetKey = new System.Windows.Forms.TextBox();
            this.TextGet = new System.Windows.Forms.TextBox();
            this.GetText = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.setError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(196, 220);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(101, 31);
            this.Button.TabIndex = 0;
            this.Button.Text = "Šifruoti";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pradinis tekstas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raktas:";
            // 
            // SetText
            // 
            this.SetText.Location = new System.Drawing.Point(277, 89);
            this.SetText.Name = "SetText";
            this.SetText.Size = new System.Drawing.Size(100, 22);
            this.SetText.TabIndex = 3;
            // 
            // SetKey
            // 
            this.SetKey.Location = new System.Drawing.Point(277, 125);
            this.SetKey.Name = "SetKey";
            this.SetKey.Size = new System.Drawing.Size(100, 22);
            this.SetKey.TabIndex = 4;
            // 
            // TextGet
            // 
            this.TextGet.Location = new System.Drawing.Point(277, 168);
            this.TextGet.Name = "TextGet";
            this.TextGet.Size = new System.Drawing.Size(100, 22);
            this.TextGet.TabIndex = 5;
            // 
            // GetText
            // 
            this.GetText.AutoSize = true;
            this.GetText.Location = new System.Drawing.Point(120, 173);
            this.GetText.Name = "GetText";
            this.GetText.Size = new System.Drawing.Size(142, 17);
            this.GetText.TabIndex = 6;
            this.GetText.Text = "Šifruotas/dešifruotas:";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(323, 220);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(101, 31);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "Dešifruoti";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // setError
            // 
            this.setError.AutoSize = true;
            this.setError.ForeColor = System.Drawing.Color.Red;
            this.setError.Location = new System.Drawing.Point(226, 200);
            this.setError.Name = "setError";
            this.setError.Size = new System.Drawing.Size(0, 17);
            this.setError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setError);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.GetText);
            this.Controls.Add(this.TextGet);
            this.Controls.Add(this.SetKey);
            this.Controls.Add(this.SetText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetText;
        private System.Windows.Forms.TextBox SetKey;
        private System.Windows.Forms.TextBox TextGet;
        private System.Windows.Forms.Label GetText;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label setError;
    }
}

