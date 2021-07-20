
namespace ClientApp.GUI.Forms.CustomWorkoutRoutines
{
    partial class CustomWorkoutRoutineForm
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
            this.CustomWorkoutRoutineListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomWorkoutRoutineListBox
            // 
            this.CustomWorkoutRoutineListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomWorkoutRoutineListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomWorkoutRoutineListBox.FormattingEnabled = true;
            this.CustomWorkoutRoutineListBox.ItemHeight = 20;
            this.CustomWorkoutRoutineListBox.Location = new System.Drawing.Point(0, 0);
            this.CustomWorkoutRoutineListBox.Name = "CustomWorkoutRoutineListBox";
            this.CustomWorkoutRoutineListBox.Size = new System.Drawing.Size(800, 350);
            this.CustomWorkoutRoutineListBox.TabIndex = 5;
            this.CustomWorkoutRoutineListBox.SelectedIndexChanged += new System.EventHandler(this.CustomWorkoutRoutineListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.CreateButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewDetailsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ArchiveButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.Location = new System.Drawing.Point(336, 19);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(126, 61);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ViewDetailsButton.Location = new System.Drawing.Point(70, 19);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.Size = new System.Drawing.Size(126, 61);
            this.ViewDetailsButton.TabIndex = 0;
            this.ViewDetailsButton.Text = "View Details";
            this.ViewDetailsButton.UseVisualStyleBackColor = true;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArchiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArchiveButton.Location = new System.Drawing.Point(603, 19);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(126, 61);
            this.ArchiveButton.TabIndex = 3;
            this.ArchiveButton.Text = "Archive";
            this.ArchiveButton.UseVisualStyleBackColor = true;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            // 
            // CustomWorkoutRoutineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomWorkoutRoutineListBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomWorkoutRoutineForm";
            this.Text = "CustomWorkoutRoutineForm";
            this.Load += new System.EventHandler(this.CustomWorkoutRoutineForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CustomWorkoutRoutineListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ViewDetailsButton;
        private System.Windows.Forms.Button ArchiveButton;
    }
}