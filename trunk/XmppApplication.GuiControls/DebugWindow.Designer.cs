namespace XmppApplication.GuiControls
{
    partial class DebugWindow
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
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(703, 442);
            this.RichTextBox1.TabIndex = 1;
            this.RichTextBox1.Text = "";
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 442);
            this.Controls.Add(this.RichTextBox1);
            this.Name = "DebugWindow";
            this.Text = "DebugWindow";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox RichTextBox1;
    }
}