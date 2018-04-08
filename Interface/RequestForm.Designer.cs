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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.address_bar = new System.Windows.Forms.TextBox();
            this.button_showRawView = new System.Windows.Forms.Button();
            this.button_showHeaders = new System.Windows.Forms.Button();
            this.button_showBody = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.button_addHeaders = new System.Windows.Forms.Button();
            this.button_addBody = new System.Windows.Forms.Button();
            this.button_viewRequest = new System.Windows.Forms.Button();
            this.method_selector = new System.Windows.Forms.ComboBox();
            this.button_auth = new System.Windows.Forms.Button();
            this.button_viewPrevious = new System.Windows.Forms.Button();
            this.button_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(77, 183);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(676, 338);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // address_bar
            // 
            this.address_bar.Location = new System.Drawing.Point(171, 61);
            this.address_bar.Name = "address_bar";
            this.address_bar.Size = new System.Drawing.Size(460, 20);
            this.address_bar.TabIndex = 2;
            // 
            // button_showRawView
            // 
            this.button_showRawView.Location = new System.Drawing.Point(339, 156);
            this.button_showRawView.Name = "button_showRawView";
            this.button_showRawView.Size = new System.Drawing.Size(78, 21);
            this.button_showRawView.TabIndex = 6;
            this.button_showRawView.Text = "Raw view";
            this.button_showRawView.UseVisualStyleBackColor = true;
            this.button_showRawView.Click += new System.EventHandler(this.button_showRawView_Click);
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
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(643, 61);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(109, 20);
            this.send_button.TabIndex = 7;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // button_addHeaders
            // 
            this.button_addHeaders.Location = new System.Drawing.Point(77, 88);
            this.button_addHeaders.Name = "button_addHeaders";
            this.button_addHeaders.Size = new System.Drawing.Size(128, 24);
            this.button_addHeaders.TabIndex = 8;
            this.button_addHeaders.Text = "Add headers";
            this.button_addHeaders.UseVisualStyleBackColor = true;
            this.button_addHeaders.Click += new System.EventHandler(this.button_addHeaders_Click);
            // 
            // button_addBody
            // 
            this.button_addBody.Location = new System.Drawing.Point(211, 88);
            this.button_addBody.Name = "button_addBody";
            this.button_addBody.Size = new System.Drawing.Size(128, 24);
            this.button_addBody.TabIndex = 9;
            this.button_addBody.Text = "Add body";
            this.button_addBody.UseVisualStyleBackColor = true;
            this.button_addBody.Click += new System.EventHandler(this.button_addBody_Click);
            // 
            // button_viewRequest
            // 
            this.button_viewRequest.Location = new System.Drawing.Point(479, 88);
            this.button_viewRequest.Name = "button_viewRequest";
            this.button_viewRequest.Size = new System.Drawing.Size(128, 24);
            this.button_viewRequest.TabIndex = 10;
            this.button_viewRequest.Text = "View current request";
            this.button_viewRequest.UseVisualStyleBackColor = true;
            this.button_viewRequest.Click += new System.EventHandler(this.button_viewRequest_Click);
            // 
            // method_selector
            // 
            this.method_selector.FormattingEnabled = true;
            this.method_selector.Items.AddRange(new object[] {
            "GET",
            "HEAD",
            "POST",
            "PUT",
            "DELETE",
            "OPTIONS",
            "TRACE"});
            this.method_selector.Location = new System.Drawing.Point(77, 61);
            this.method_selector.Name = "method_selector";
            this.method_selector.Size = new System.Drawing.Size(87, 21);
            this.method_selector.TabIndex = 11;
            // 
            // button_auth
            // 
            this.button_auth.Location = new System.Drawing.Point(345, 88);
            this.button_auth.Name = "button_auth";
            this.button_auth.Size = new System.Drawing.Size(128, 24);
            this.button_auth.TabIndex = 12;
            this.button_auth.Text = "Authentication";
            this.button_auth.UseVisualStyleBackColor = true;
            this.button_auth.Click += new System.EventHandler(this.button_auth_Click);
            // 
            // button_viewPrevious
            // 
            this.button_viewPrevious.Location = new System.Drawing.Point(613, 88);
            this.button_viewPrevious.Name = "button_viewPrevious";
            this.button_viewPrevious.Size = new System.Drawing.Size(128, 24);
            this.button_viewPrevious.TabIndex = 13;
            this.button_viewPrevious.Text = "View previous request";
            this.button_viewPrevious.UseVisualStyleBackColor = true;
            this.button_viewPrevious.Click += new System.EventHandler(this.button_viewPrevious_Click);
            // 
            // button_status
            // 
            this.button_status.Location = new System.Drawing.Point(255, 156);
            this.button_status.Name = "button_status";
            this.button_status.Size = new System.Drawing.Size(78, 21);
            this.button_status.TabIndex = 14;
            this.button_status.Text = "Status";
            this.button_status.UseVisualStyleBackColor = true;
            this.button_status.Click += new System.EventHandler(this.button_status_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 560);
            this.Controls.Add(this.button_status);
            this.Controls.Add(this.button_viewPrevious);
            this.Controls.Add(this.button_auth);
            this.Controls.Add(this.method_selector);
            this.Controls.Add(this.button_viewRequest);
            this.Controls.Add(this.button_addBody);
            this.Controls.Add(this.button_addHeaders);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.button_showRawView);
            this.Controls.Add(this.button_showHeaders);
            this.Controls.Add(this.button_showBody);
            this.Controls.Add(this.address_bar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "RequestForm";
            this.Text = "HTTPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox address_bar;
        private System.Windows.Forms.Button button_showRawView;
        private System.Windows.Forms.Button button_showHeaders;
        private System.Windows.Forms.Button button_showBody;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button button_addHeaders;
        private System.Windows.Forms.Button button_addBody;
        private System.Windows.Forms.Button button_viewRequest;
        private System.Windows.Forms.ComboBox method_selector;
        private System.Windows.Forms.Button button_auth;
        private System.Windows.Forms.Button button_viewPrevious;
        private System.Windows.Forms.Button button_status;
    }
}

