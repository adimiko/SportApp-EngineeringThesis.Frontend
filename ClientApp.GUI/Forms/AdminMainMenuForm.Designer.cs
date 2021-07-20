
namespace ClientApp.GUI.Forms
{
    partial class AdminMainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainMenuForm));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ArchiveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ExerciseInfoButton = new System.Windows.Forms.Button();
            this.SampleWorkoutRoutineButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(65, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(735, 450);
            this.ContentPanel.TabIndex = 3;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.ArchiveButton);
            this.MenuPanel.Controls.Add(this.CloseButton);
            this.MenuPanel.Controls.Add(this.ExerciseInfoButton);
            this.MenuPanel.Controls.Add(this.SampleWorkoutRoutineButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(65, 450);
            this.MenuPanel.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Location = new System.Drawing.Point(0, 334);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(65, 55);
            this.SettingsButton.TabIndex = 13;
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
            this.ArchiveButton.Location = new System.Drawing.Point(0, 110);
            this.ArchiveButton.Name = "ArchiveButton";
            this.ArchiveButton.Size = new System.Drawing.Size(65, 55);
            this.ArchiveButton.TabIndex = 5;
            this.ArchiveButton.UseVisualStyleBackColor = false;
            this.ArchiveButton.Click += new System.EventHandler(this.ArchiveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(0, 389);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 61);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ExerciseInfoButton
            // 
            this.ExerciseInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExerciseInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExerciseInfoButton.BackgroundImage")));
            this.ExerciseInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExerciseInfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExerciseInfoButton.FlatAppearance.BorderSize = 0;
            this.ExerciseInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExerciseInfoButton.Location = new System.Drawing.Point(0, 55);
            this.ExerciseInfoButton.Name = "ExerciseInfoButton";
            this.ExerciseInfoButton.Size = new System.Drawing.Size(65, 55);
            this.ExerciseInfoButton.TabIndex = 2;
            this.ExerciseInfoButton.UseVisualStyleBackColor = false;
            this.ExerciseInfoButton.Click += new System.EventHandler(this.ExerciseInfoButton_Click);
            // 
            // SampleWorkoutRoutineButton
            // 
            this.SampleWorkoutRoutineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SampleWorkoutRoutineButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SampleWorkoutRoutineButton.BackgroundImage")));
            this.SampleWorkoutRoutineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SampleWorkoutRoutineButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SampleWorkoutRoutineButton.FlatAppearance.BorderSize = 0;
            this.SampleWorkoutRoutineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SampleWorkoutRoutineButton.Location = new System.Drawing.Point(0, 0);
            this.SampleWorkoutRoutineButton.Name = "SampleWorkoutRoutineButton";
            this.SampleWorkoutRoutineButton.Size = new System.Drawing.Size(65, 55);
            this.SampleWorkoutRoutineButton.TabIndex = 1;
            this.SampleWorkoutRoutineButton.UseVisualStyleBackColor = false;
            this.SampleWorkoutRoutineButton.Click += new System.EventHandler(this.SampleWorkoutRoutineButton_Click);
            // 
            // AdminMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.AdminMainMenuForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ExerciseInfoButton;
        private System.Windows.Forms.Button SampleWorkoutRoutineButton;
        private System.Windows.Forms.Button ArchiveButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}