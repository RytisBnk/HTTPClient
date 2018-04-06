namespace HTTPClient
{
    partial class RequestCodeForm
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
            this.request_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // request_text
            // 
            this.request_text.Location = new System.Drawing.Point(13, 38);
            this.request_text.Name = "request_text";
            this.request_text.Size = new System.Drawing.Size(454, 336);
            this.request_text.TabIndex = 0;
            this.request_text.Text = "";
            // 
            // RequestCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 399);
            this.Controls.Add(this.request_text);
            this.Name = "RequestCodeForm";
            this.Text = "RequestCodeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox request_text;
    }
}