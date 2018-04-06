namespace HTTPClient
{
    partial class BodyForm
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
            this.body_text = new System.Windows.Forms.RichTextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // body_text
            // 
            this.body_text.Location = new System.Drawing.Point(16, 20);
            this.body_text.Name = "body_text";
            this.body_text.Size = new System.Drawing.Size(481, 319);
            this.body_text.TabIndex = 0;
            this.body_text.Text = "";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(173, 354);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(173, 32);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add request body";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // BodyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 398);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.body_text);
            this.Name = "BodyForm";
            this.Text = "BodyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox body_text;
        private System.Windows.Forms.Button button_add;
    }
}