
namespace ClientApp.GUI.Forms.StartWorkout
{
    partial class WorkoutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.WorkoutNoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.WorkoutNoteLabel = new System.Windows.Forms.Label();
            this.WorkoutNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.WorkoutTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ContentPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DurationLabel);
            this.panel1.Controls.Add(this.WorkoutNoteRichTextBox);
            this.panel1.Controls.Add(this.WorkoutNoteLabel);
            this.panel1.Controls.Add(this.WorkoutNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 94);
            this.panel1.TabIndex = 0;
            // 
            // DurationLabel
            // 
            this.DurationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DurationLabel.Location = new System.Drawing.Point(-6, -3);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(96, 33);
            this.DurationLabel.TabIndex = 3;
            this.DurationLabel.Text = "00:00:00";
            this.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkoutNoteRichTextBox
            // 
            this.WorkoutNoteRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkoutNoteRichTextBox.Location = new System.Drawing.Point(0, 43);
            this.WorkoutNoteRichTextBox.Name = "WorkoutNoteRichTextBox";
            this.WorkoutNoteRichTextBox.Size = new System.Drawing.Size(793, 51);
            this.WorkoutNoteRichTextBox.TabIndex = 2;
            this.WorkoutNoteRichTextBox.Text = "";
            // 
            // WorkoutNoteLabel
            // 
            this.WorkoutNoteLabel.AutoSize = true;
            this.WorkoutNoteLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkoutNoteLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.WorkoutNoteLabel.Location = new System.Drawing.Point(0, 30);
            this.WorkoutNoteLabel.Name = "WorkoutNoteLabel";
            this.WorkoutNoteLabel.Size = new System.Drawing.Size(77, 13);
            this.WorkoutNoteLabel.TabIndex = 1;
            this.WorkoutNoteLabel.Text = "Workout Note:";
            // 
            // WorkoutNameLabel
            // 
            this.WorkoutNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkoutNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkoutNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.WorkoutNameLabel.Location = new System.Drawing.Point(0, 0);
            this.WorkoutNameLabel.Name = "WorkoutNameLabel";
            this.WorkoutNameLabel.Size = new System.Drawing.Size(793, 30);
            this.WorkoutNameLabel.TabIndex = 0;
            this.WorkoutNameLabel.Text = "Workout Name";
            this.WorkoutNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.Location = new System.Drawing.Point(336, 472);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 34);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(3, 103);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(793, 363);
            this.ContentPanel.TabIndex = 3;
            // 
            // WorkoutTimer
            // 
            this.WorkoutTimer.Enabled = true;
            this.WorkoutTimer.Interval = 1000;
            this.WorkoutTimer.Tick += new System.EventHandler(this.WorkoutTimer_Tick);
            // 
            // WorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(799, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Workout";
            this.Load += new System.EventHandler(this.WorkoutForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox WorkoutNoteRichTextBox;
        private System.Windows.Forms.Label WorkoutNoteLabel;
        private System.Windows.Forms.Label WorkoutNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Timer WorkoutTimer;
        private System.Windows.Forms.Label DurationLabel;
    }
}