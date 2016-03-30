namespace Number_To_Text_App
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
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutputString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input The Number: ";
            // 
            // txtInputString
            // 
            this.txtInputString.Location = new System.Drawing.Point(44, 69);
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(336, 29);
            this.txtInputString.TabIndex = 1;
            this.txtInputString.Text = "$ 00.00";
            this.txtInputString.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInputString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtInputString_MouseClick);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(44, 129);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(197, 37);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert To Text";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtOutputString
            // 
            this.txtOutputString.HideSelection = false;
            this.txtOutputString.Location = new System.Drawing.Point(44, 196);
            this.txtOutputString.Multiline = true;
            this.txtOutputString.Name = "txtOutputString";
            this.txtOutputString.Size = new System.Drawing.Size(618, 104);
            this.txtOutputString.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 322);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutputString);
            this.Controls.Add(this.txtInputString);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumbersToText Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutputString;
    }
}

