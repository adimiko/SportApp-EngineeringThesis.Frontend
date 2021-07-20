
namespace ClientApp.GUI.Forms
{
    partial class ErrorForm
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
            this.ClipboardButton = new System.Windows.Forms.Button();
            this.ErrorMessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ClipboardButton
            // 
            this.ClipboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ClipboardButton.Location = new System.Drawing.Point(475, 9);
            this.ClipboardButton.Name = "ClipboardButton";
            this.ClipboardButton.Size = new System.Drawing.Size(40, 45);
            this.ClipboardButton.TabIndex = 3;
            this.ClipboardButton.Text = "📋";
            this.ClipboardButton.UseVisualStyleBackColor = true;
            this.ClipboardButton.Click += new System.EventHandler(this.ClipboardButton_Click);
            // 
            // ErrorMessageRichTextBox
            // 
            this.ErrorMessageRichTextBox.Location = new System.Drawing.Point(12, 9);
            this.ErrorMessageRichTextBox.Name = "ErrorMessageRichTextBox";
            this.ErrorMessageRichTextBox.ReadOnly = true;
            this.ErrorMessageRichTextBox.Size = new System.Drawing.Size(457, 113);
            this.ErrorMessageRichTextBox.TabIndex = 4;
            this.ErrorMessageRichTextBox.Text = "";
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 134);
            this.Controls.Add(this.ErrorMessageRichTextBox);
            this.Controls.Add(this.ClipboardButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(538, 173);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(538, 173);
            this.Name = "ErrorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ClipboardButton;
        private System.Windows.Forms.RichTextBox ErrorMessageRichTextBox;
    }
}