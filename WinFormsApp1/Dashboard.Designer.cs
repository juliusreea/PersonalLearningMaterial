namespace WinFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.messageBoxDemoButton = new System.Windows.Forms.Button();
            this.textBoxButtonDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SubTotal";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 209);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 31);
            this.textBox2.TabIndex = 3;
            // 
            // messageBoxDemoButton
            // 
            this.messageBoxDemoButton.Location = new System.Drawing.Point(55, 292);
            this.messageBoxDemoButton.Name = "messageBoxDemoButton";
            this.messageBoxDemoButton.Size = new System.Drawing.Size(223, 58);
            this.messageBoxDemoButton.TabIndex = 4;
            this.messageBoxDemoButton.Text = "MessageBox Demo";
            this.messageBoxDemoButton.UseVisualStyleBackColor = true;
            this.messageBoxDemoButton.Click += new System.EventHandler(this.messageBoxButtonDemo_Click);
            // 
            // textBoxButtonDemo
            // 
            this.textBoxButtonDemo.Location = new System.Drawing.Point(297, 292);
            this.textBoxButtonDemo.Name = "textBoxButtonDemo";
            this.textBoxButtonDemo.Size = new System.Drawing.Size(219, 58);
            this.textBoxButtonDemo.TabIndex = 5;
            this.textBoxButtonDemo.Text = "TextBox Demo";
            this.textBoxButtonDemo.UseVisualStyleBackColor = true;
            this.textBoxButtonDemo.Click += new System.EventHandler(this.textBoxButtonDemo_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 373);
            this.Controls.Add(this.textBoxButtonDemo);
            this.Controls.Add(this.messageBoxDemoButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button messageBoxDemoButton;
        private System.Windows.Forms.Button textBoxButtonDemo;
    }
}
