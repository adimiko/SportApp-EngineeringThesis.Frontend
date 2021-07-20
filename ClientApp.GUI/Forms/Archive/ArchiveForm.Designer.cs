
namespace ClientApp.GUI.Forms.Archive
{
    partial class ArchiveForm
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
            this.RestoreButton = new System.Windows.Forms.Button();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
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
            this.CustomWorkoutRoutineListBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.RestoreButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewDetailsButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RestoreButton
            // 
            this.RestoreButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RestoreButton.Location = new System.Drawing.Point(537, 19);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(126, 61);
            this.RestoreButton.TabIndex = 1;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ViewDetailsButton.Location = new System.Drawing.Point(137, 19);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.Size = new System.Drawing.Size(126, 61);
            this.ViewDetailsButton.TabIndex = 0;
            this.ViewDetailsButton.Text = "View Details";
            this.ViewDetailsButton.UseVisualStyleBackColor = true;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomWorkoutRoutineListBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchiveForm";
            this.Text = "ArchiveForm";
            this.Load += new System.EventHandler(this.ArchiveForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CustomWorkoutRoutineListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button ViewDetailsButton;
    }
}