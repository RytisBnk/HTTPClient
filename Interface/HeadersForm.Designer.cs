namespace HTTPClient
{
    partial class HeadersForm
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
            this.headers_textbox = new System.Windows.Forms.RichTextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headers_textbox
            // 
            this.headers_textbox.Location = new System.Drawing.Point(13, 23);
            this.headers_textbox.Name = "headers_textbox";
            this.headers_textbox.Size = new System.Drawing.Size(259, 176);
            this.headers_textbox.TabIndex = 0;
            this.headers_textbox.Text = "";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(13, 216);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(259, 33);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add headers";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // HeadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.headers_textbox);
            this.Name = "HeadersForm";
            this.Text = "HeadersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox headers_textbox;
        private System.Windows.Forms.Button button_add;
    }
}