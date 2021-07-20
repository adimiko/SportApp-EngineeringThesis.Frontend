
namespace ClientApp.GUI.Forms.WorkoutStats
{
    partial class WorkoutsStatsForm
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
            this.GlobalButton = new System.Windows.Forms.Button();
            this.CurrentYearButton = new System.Windows.Forms.Button();
            this.CurrentMonthButton = new System.Windows.Forms.Button();
            this.CurrentWeekButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationTextLabel = new System.Windows.Forms.Label();
            this.CompletedWorkoutsLabel = new System.Windows.Forms.Label();
            this.CompletedWorkoutsTextLabel = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VolumeTextLabel = new System.Windows.Forms.Label();
            this.StatsTextLabel = new System.Windows.Forms.Label();
            this.AnalysisButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.GlobalButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentYearButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentMonthButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentWeekButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 500);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // GlobalButton
            // 
            this.GlobalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GlobalButton.Location = new System.Drawing.Point(637, 19);
            this.GlobalButton.Name = "GlobalButton";
            this.GlobalButton.Size = new System.Drawing.Size(126, 61);
            this.GlobalButton.TabIndex = 3;
            this.GlobalButton.Text = "Global";
            this.GlobalButton.UseVisualStyleBackColor = true;
            this.GlobalButton.Click += new System.EventHandler(this.GlobalButton_Click);
            // 
            // CurrentYearButton
            // 
            this.CurrentYearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentYearButton.Location = new System.Drawing.Point(437, 19);
            this.CurrentYearButton.Name = "CurrentYearButton";
            this.CurrentYearButton.Size = new System.Drawing.Size(126, 61);
            this.CurrentYearButton.TabIndex = 2;
            this.CurrentYearButton.Text = "Current Year";
            this.CurrentYearButton.UseVisualStyleBackColor = true;
            this.CurrentYearButton.Click += new System.EventHandler(this.CurrentYearButton_Click);
            // 
            // CurrentMonthButton
            // 
            this.CurrentMonthButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentMonthButton.Location = new System.Drawing.Point(237, 19);
            this.CurrentMonthButton.Name = "CurrentMonthButton";
            this.CurrentMonthButton.Size = new System.Drawing.Size(126, 61);
            this.CurrentMonthButton.TabIndex = 1;
            this.CurrentMonthButton.Text = "Current Month";
            this.CurrentMonthButton.UseVisualStyleBackColor = true;
            this.CurrentMonthButton.Click += new System.EventHandler(this.CurrentMonthButton_Click);
            // 
            // CurrentWeekButton
            // 
            this.CurrentWeekButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentWeekButton.Location = new System.Drawing.Point(37, 19);
            this.CurrentWeekButton.Name = "CurrentWeekButton";
            this.CurrentWeekButton.Size = new System.Drawing.Size(126, 61);
            this.CurrentWeekButton.TabIndex = 0;
            this.CurrentWeekButton.Text = "Current Week";
            this.CurrentWeekButton.UseVisualStyleBackColor = true;
            this.CurrentWeekButton.Click += new System.EventHandler(this.CurrentWeekButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ContentPanel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.StatsTextLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 500);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.AnalysisButton);
            this.ContentPanel.Controls.Add(this.DurationLabel);
            this.ContentPanel.Controls.Add(this.DurationTextLabel);
            this.ContentPanel.Controls.Add(this.CompletedWorkoutsLabel);
            this.ContentPanel.Controls.Add(this.CompletedWorkoutsTextLabel);
            this.ContentPanel.Controls.Add(this.VolumeLabel);
            this.ContentPanel.Controls.Add(this.VolumeTextLabel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(203, 128);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(394, 244);
            this.ContentPanel.TabIndex = 0;
            // 
            // DurationLabel
            // 
            this.DurationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DurationLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DurationLabel.Location = new System.Drawing.Point(0, 100);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(394, 20);
            this.DurationLabel.TabIndex = 5;
            this.DurationLabel.Text = "Duration Value";
            this.DurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurationTextLabel
            // 
            this.DurationTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DurationTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DurationTextLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DurationTextLabel.Location = new System.Drawing.Point(0, 80);
            this.DurationTextLabel.Name = "DurationTextLabel";
            this.DurationTextLabel.Size = new System.Drawing.Size(394, 20);
            this.DurationTextLabel.TabIndex = 4;
            this.DurationTextLabel.Text = "Duration";
            this.DurationTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletedWorkoutsLabel
            // 
            this.CompletedWorkoutsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompletedWorkoutsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CompletedWorkoutsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CompletedWorkoutsLabel.Location = new System.Drawing.Point(0, 60);
            this.CompletedWorkoutsLabel.Name = "CompletedWorkoutsLabel";
            this.CompletedWorkoutsLabel.Size = new System.Drawing.Size(394, 20);
            this.CompletedWorkoutsLabel.TabIndex = 3;
            this.CompletedWorkoutsLabel.Text = "Completed Workouts Value";
            this.CompletedWorkoutsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletedWorkoutsTextLabel
            // 
            this.CompletedWorkoutsTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompletedWorkoutsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CompletedWorkoutsTextLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CompletedWorkoutsTextLabel.Location = new System.Drawing.Point(0, 40);
            this.CompletedWorkoutsTextLabel.Name = "CompletedWorkoutsTextLabel";
            this.CompletedWorkoutsTextLabel.Size = new System.Drawing.Size(394, 20);
            this.CompletedWorkoutsTextLabel.TabIndex = 2;
            this.CompletedWorkoutsTextLabel.Text = "Completed Workouts";
            this.CompletedWorkoutsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VolumeLabel.Location = new System.Drawing.Point(0, 20);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(394, 20);
            this.VolumeLabel.TabIndex = 1;
            this.VolumeLabel.Text = "VolumeValue";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeTextLabel
            // 
            this.VolumeTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VolumeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeTextLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VolumeTextLabel.Location = new System.Drawing.Point(0, 0);
            this.VolumeTextLabel.Name = "VolumeTextLabel";
            this.VolumeTextLabel.Size = new System.Drawing.Size(394, 20);
            this.VolumeTextLabel.TabIndex = 0;
            this.VolumeTextLabel.Text = "Volume";
            this.VolumeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatsTextLabel
            // 
            this.StatsTextLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatsTextLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.StatsTextLabel.Location = new System.Drawing.Point(203, 102);
            this.StatsTextLabel.Name = "StatsTextLabel";
            this.StatsTextLabel.Size = new System.Drawing.Size(394, 23);
            this.StatsTextLabel.TabIndex = 1;
            this.StatsTextLabel.Text = "STATS";
            this.StatsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnalysisButton
            // 
            this.AnalysisButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnalysisButton.Location = new System.Drawing.Point(136, 123);
            this.AnalysisButton.Name = "AnalysisButton";
            this.AnalysisButton.Size = new System.Drawing.Size(126, 48);
            this.AnalysisButton.TabIndex = 4;
            this.AnalysisButton.Text = "Last month\'s analysis";
            this.AnalysisButton.UseVisualStyleBackColor = true;
            this.AnalysisButton.Click += new System.EventHandler(this.AnalysisButton_Click);
            // 
            // WorkoutsStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkoutsStatsForm";
            this.Text = "WorkoutStatsForm";
            this.Load += new System.EventHandler(this.WorkoutsStatsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GlobalButton;
        private System.Windows.Forms.Button CurrentYearButton;
        private System.Windows.Forms.Button CurrentMonthButton;
        private System.Windows.Forms.Button CurrentWeekButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label DurationTextLabel;
        private System.Windows.Forms.Label CompletedWorkoutsLabel;
        private System.Windows.Forms.Label CompletedWorkoutsTextLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label VolumeTextLabel;
        private System.Windows.Forms.Label StatsTextLabel;
        private System.Windows.Forms.Button AnalysisButton;
    }
}