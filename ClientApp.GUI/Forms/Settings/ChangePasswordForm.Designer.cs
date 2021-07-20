
namespace ClientApp.GUI.Forms.Settings
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ConfirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmNewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ContentPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ChangePasswordButton);
            this.ContentPanel.Controls.Add(this.ConfirmNewPasswordTextBox);
            this.ContentPanel.Controls.Add(this.ConfirmNewPasswordLabel);
            this.ContentPanel.Controls.Add(this.NewPasswordTextBox);
            this.ContentPanel.Controls.Add(this.NewPasswordLabel);
            this.ContentPanel.Controls.Add(this.OldPasswordTextBox);
            this.ContentPanel.Controls.Add(this.OldPasswordLabel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(246, 78);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(294, 294);
            this.ContentPanel.TabIndex = 0;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChangePasswordButton.Location = new System.Drawing.Point(0, 251);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(294, 43);
            this.ChangePasswordButton.TabIndex = 6;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ConfirmNewPasswordTextBox
            // 
            this.ConfirmNewPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfirmNewPasswordTextBox.Location = new System.Drawing.Point(0, 109);
            this.ConfirmNewPasswordTextBox.Name = "ConfirmNewPasswordTextBox";
            this.ConfirmNewPasswordTextBox.PasswordChar = '•';
            this.ConfirmNewPasswordTextBox.Size = new System.Drawing.Size(294, 20);
            this.ConfirmNewPasswordTextBox.TabIndex = 5;
            // 
            // ConfirmNewPasswordLabel
            // 
            this.ConfirmNewPasswordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfirmNewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ConfirmNewPasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmNewPasswordLabel.Location = new System.Drawing.Point(0, 86);
            this.ConfirmNewPasswordLabel.Name = "ConfirmNewPasswordLabel";
            this.ConfirmNewPasswordLabel.Size = new System.Drawing.Size(294, 23);
            this.ConfirmNewPasswordLabel.TabIndex = 4;
            this.ConfirmNewPasswordLabel.Text = "Confirm New password";
            this.ConfirmNewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPasswordTextBox.Location = new System.Drawing.Point(0, 66);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '•';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(294, 20);
            this.NewPasswordTextBox.TabIndex = 3;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.NewPasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NewPasswordLabel.Location = new System.Drawing.Point(0, 43);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(294, 23);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "New password";
            this.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OldPasswordTextBox.Location = new System.Drawing.Point(0, 23);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.PasswordChar = '•';
            this.OldPasswordTextBox.Size = new System.Drawing.Size(294, 20);
            this.OldPasswordTextBox.TabIndex = 1;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.OldPasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OldPasswordLabel.Location = new System.Drawing.Point(0, 0);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(294, 23);
            this.OldPasswordLabel.TabIndex = 0;
            this.OldPasswordLabel.Text = "Old password";
            this.OldPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox ConfirmNewPasswordTextBox;
        private System.Windows.Forms.Label ConfirmNewPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.Label OldPasswordLabel;
    }
}