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
            this.BTNClick = new System.Windows.Forms.Button();
            this.TXTNumber = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTNClick
            // 
            this.BTNClick.Location = new System.Drawing.Point(135, 264);
            this.BTNClick.Name = "BTNClick";
            this.BTNClick.Size = new System.Drawing.Size(276, 76);
            this.BTNClick.TabIndex = 0;
            this.BTNClick.Text = "Click";
            this.BTNClick.UseVisualStyleBackColor = true;
            this.BTNClick.Click += new System.EventHandler(this.BTNClick_Click);
            // 
            // TXTNumber
            // 
            this.TXTNumber.Location = new System.Drawing.Point(136, 130);
            this.TXTNumber.Name = "TXTNumber";
            this.TXTNumber.Size = new System.Drawing.Size(274, 20);
            this.TXTNumber.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(536, 126);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(201, 212);
            this.listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.TXTNumber);
            this.Controls.Add(this.BTNClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNClick;
        private System.Windows.Forms.TextBox TXTNumber;
        private System.Windows.Forms.ListBox listBox;
    }
}

