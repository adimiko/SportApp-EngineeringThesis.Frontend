
namespace ClientApp.GUI.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.BodyMeasurementButton = new System.Windows.Forms.Button();
            this.ExerciseInfoButton = new System.Windows.Forms.Button();
            this.CustomWorkoutRoutineButton = new System.Windows.Forms.Button();
            this.WorkoutsHistoryButton = new System.Windows.Forms.Button();
            this.StartWorkoutButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.WorkoutsStatsButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.ArchiveButton);
            this.MenuPanel.Controls.Add(this.BodyMeasurementButton);
            this.MenuPanel.Controls.Add(this.ExerciseInfoButton);
            this.MenuPanel.Controls.Add(this.CustomWorkoutRoutineButton);
            this.MenuPanel.Controls.Add(this.WorkoutsHistoryButton);
            this.MenuPanel.Controls.Add(this.StartWorkoutButton);
            this.MenuPanel.Controls.Add(this.CloseButton);
            this.MenuPanel.Controls.Add(this.WorkoutsStatsButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(65, 511);
            this.MenuPanel.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(0, 395);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(65, 55);
            this.SettingsButton.TabIndex = 12;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ArchiveButton
            // 
            this.ArchiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ArchiveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ArchiveButton.BackgroundImage")));
            this.ArchiveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ArchiveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArchiveButton.FlatAppearance.BorderSize = 0;
            this.ArchiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArchiveButton.Location = new System.Drawing.Point(0, 330);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(65, 55);
            this.ArchiveButton.TabIndex = 11;
            this.ArchiveButton.UseVisualStyleBackColor = false;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            // 
            // BodyMeasurementButton
            // 
            this.BodyMeasurementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BodyMeasurementButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BodyMeasurementButton.BackgroundImage")));
            this.BodyMeasurementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BodyMeasurementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BodyMeasurementButton.FlatAppearance.BorderSize = 0;
            this.BodyMeasurementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BodyMeasurementButton.Location = new System.Drawing.Point(0, 275);
            this.BodyMeasurementButton.Name = "BodyMeasurementButton";
            this.BodyMeasurementButton.Size = new System.Drawing.Size(65, 55);
            this.BodyMeasurementButton.TabIndex = 10;
            this.BodyMeasurementButton.UseVisualStyleBackColor = false;
            this.BodyMeasurementButton.Click += new System.EventHandler(this.BodyMeasurementButton_Click);
            // 
            // ExerciseInfoButton
            // 
            this.ExerciseInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExerciseInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExerciseInfoButton.BackgroundImage")));
            this.ExerciseInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExerciseInfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExerciseInfoButton.FlatAppearance.BorderSize = 0;
            this.ExerciseInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExerciseInfoButton.Location = new System.Drawing.Point(0, 220);
            this.ExerciseInfoButton.Name = "ExerciseInfoButton";
            this.ExerciseInfoButton.Size = new System.Drawing.Size(65, 55);
            this.ExerciseInfoButton.TabIndex = 9;
            this.ExerciseInfoButton.UseVisualStyleBackColor = false;
            this.ExerciseInfoButton.Click += new System.EventHandler(this.ExerciseInfoButton_Click);
            // 
            // CustomWorkoutRoutineButton
            // 
            this.CustomWorkoutRoutineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CustomWorkoutRoutineButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomWorkoutRoutineButton.BackgroundImage")));
            this.CustomWorkoutRoutineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CustomWorkoutRoutineButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomWorkoutRoutineButton.FlatAppearance.BorderSize = 0;
            this.CustomWorkoutRoutineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomWorkoutRoutineButton.Location = new System.Drawing.Point(0, 165);
            this.CustomWorkoutRoutineButton.Name = "CustomWorkoutRoutineButton";
            this.CustomWorkoutRoutineButton.Size = new System.Drawing.Size(65, 55);
            this.CustomWorkoutRoutineButton.TabIndex = 8;
            this.CustomWorkoutRoutineButton.UseVisualStyleBackColor = false;
            this.CustomWorkoutRoutineButton.Click += new System.EventHandler(this.CustomWorkoutRoutineButton_Click);
            // 
            // WorkoutsHistoryButton
            // 
            this.WorkoutsHistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WorkoutsHistoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WorkoutsHistoryButton.BackgroundImage")));
            this.WorkoutsHistoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WorkoutsHistoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkoutsHistoryButton.FlatAppearance.BorderSize = 0;
            this.WorkoutsHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkoutsHistoryButton.Location = new System.Drawing.Point(0, 110);
            this.WorkoutsHistoryButton.Name = "WorkoutsHistoryButton";
            this.WorkoutsHistoryButton.Size = new System.Drawing.Size(65, 55);
            this.WorkoutsHistoryButton.TabIndex = 2;
            this.WorkoutsHistoryButton.UseVisualStyleBackColor = false;
            this.WorkoutsHistoryButton.Click += new System.EventHandler(this.WorkoutsHistoryButton_Click);
            // 
            // StartWorkoutButton
            // 
            this.StartWorkoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartWorkoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartWorkoutButton.BackgroundImage")));
            this.StartWorkoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartWorkoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartWorkoutButton.FlatAppearance.BorderSize = 0;
            this.StartWorkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartWorkoutButton.Location = new System.Drawing.Point(0, 55);
            this.StartWorkoutButton.Name = "StartWorkoutButton";
            this.StartWorkoutButton.Size = new System.Drawing.Size(65, 55);
            this.StartWorkoutButton.TabIndex = 1;
            this.StartWorkoutButton.UseVisualStyleBackColor = false;
            this.StartWorkoutButton.Click += new System.EventHandler(this.StartWorkoutButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(0, 450);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 61);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WorkoutsStatsButton
            // 
            this.WorkoutsStatsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WorkoutsStatsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WorkoutsStatsButton.BackgroundImage")));
            this.WorkoutsStatsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WorkoutsStatsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkoutsStatsButton.FlatAppearance.BorderSize = 0;
            this.WorkoutsStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkoutsStatsButton.Location = new System.Drawing.Point(0, 0);
            this.WorkoutsStatsButton.Name = "WorkoutsStatsButton";
            this.WorkoutsStatsButton.Size = new System.Drawing.Size(65, 55);
            this.WorkoutsStatsButton.TabIndex = 0;
            this.WorkoutsStatsButton.UseVisualStyleBackColor = false;
            this.WorkoutsStatsButton.Click += new System.EventHandler(this.WorkoutsStatsButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(65, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(719, 511);
            this.ContentPanel.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 535);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.CustomTextBox customTextBox1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button WorkoutsStatsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button WorkoutsHistoryButton;
        private System.Windows.Forms.Button StartWorkoutButton;
        private System.Windows.Forms.Button BodyMeasurementButton;
        private System.Windows.Forms.Button ExerciseInfoButton;
        private System.Windows.Forms.Button CustomWorkoutRoutineButton;
        private System.Windows.Forms.Button ArchiveButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}