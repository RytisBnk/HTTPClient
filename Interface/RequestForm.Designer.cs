namespace HTTPClient
{
    partial class RequestForm
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
            this.requestTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_showBody = new System.Windows.Forms.Button();
            this.button_showHeaders = new System.Windows.Forms.Button();
            this.button_showRawView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requestTypeComboBox
            // 
            this.requestTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.requestTypeComboBox.FormattingEnabled = true;
            this.requestTypeComboBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "TRACE",
            "OPTIONS"});
            this.requestTypeComboBox.Location = new System.Drawing.Point(77, 61);
            this.requestTypeComboBox.Name = "requestTypeComboBox";
            this.requestTypeComboBox.Size = new System.Drawing.Size(88, 21);
            this.requestTypeComboBox.TabIndex = 3;
            this.requestTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.RequestTypeComboBox_SelectedIndexChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(637, 61);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(94, 20);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(77, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(676, 338);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button_showBody
            // 
            this.button_showBody.Location = new System.Drawing.Point(77, 156);
            this.button_showBody.Name = "button_showBody";
            this.button_showBody.Size = new System.Drawing.Size(87, 22);
            this.button_showBody.TabIndex = 4;
            this.button_showBody.Text = "Body";
            this.button_showBody.UseVisualStyleBackColor = true;
            this.button_showBody.Click += new System.EventHandler(this.button_showBody_Click);
            // 
            // button_showHeaders
            // 
            this.button_showHeaders.Location = new System.Drawing.Point(170, 156);
            this.button_showHeaders.Name = "button_showHeaders";
            this.button_showHeaders.Size = new System.Drawing.Size(79, 21);
            this.button_showHeaders.TabIndex = 5;
            this.button_showHeaders.Text = "Headers";
            this.button_showHeaders.UseVisualStyleBackColor = true;
            this.button_showHeaders.Click += new System.EventHandler(this.button_showHeaders_Click);
            // 
            // button_showRawView
            // 
            this.button_showRawView.Location = new System.Drawing.Point(255, 156);
            this.button_showRawView.Name = "button_showRawView";
            this.button_showRawView.Size = new System.Drawing.Size(78, 21);
            this.button_showRawView.TabIndex = 6;
            this.button_showRawView.Text = "Raw view";
            this.button_showRawView.UseVisualStyleBackColor = true;
            this.button_showRawView.Click += new System.EventHandler(this.button_showRawView_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 560);
            this.Controls.Add(this.button_showRawView);
            this.Controls.Add(this.button_showHeaders);
            this.Controls.Add(this.button_showBody);
            this.Controls.Add(this.requestTypeComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SendButton);
            this.Name = "RequestForm";
            this.Text = "HTTPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox requestTypeComboBox;
        private System.Windows.Forms.Button button_showBody;
        private System.Windows.Forms.Button button_showHeaders;
        private System.Windows.Forms.Button button_showRawView;
    }
}

