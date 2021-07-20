
namespace ClientApp.GUI.Forms.Settings
{
    partial class SettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.AccountInfoPanel = new System.Windows.Forms.Panel();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.AccountInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ContentPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.tableLayoutPanel2);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(253, 78);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(294, 294);
            this.ContentPanel.TabIndex = 0;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.DeleteButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ChangePasswordButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AccountInfoPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 294);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteButton.Location = new System.Drawing.Point(84, 213);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(126, 61);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete your account";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(84, 115);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(126, 61);
            this.ChangePasswordButton.TabIndex = 1;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // AccountInfoPanel
            // 
            this.AccountInfoPanel.Controls.Add(this.RoleLabel);
            this.AccountInfoPanel.Controls.Add(this.NameLabel);
            this.AccountInfoPanel.Controls.Add(this.EmailLabel);
            this.AccountInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.AccountInfoPanel.Name = "AccountInfoPanel";
            this.AccountInfoPanel.Size = new System.Drawing.Size(288, 91);
            this.AccountInfoPanel.TabIndex = 3;
            this.AccountInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AccountInfoPanel_Paint);
            // 
            // RoleLabel
            // 
            this.RoleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RoleLabel.Location = new System.Drawing.Point(0, 52);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(288, 26);
            this.RoleLabel.TabIndex = 2;
            this.RoleLabel.Text = "Role";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RoleLabel.Click += new System.EventHandler(this.RoleLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(0, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(288, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.EmailLabel.Location = new System.Drawing.Point(0, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(288, 27);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(253, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "The icons used in the application come from https://icons8.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.AccountInfoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Panel AccountInfoPanel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
    }
}