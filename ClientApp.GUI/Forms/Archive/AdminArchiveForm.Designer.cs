
namespace ClientApp.GUI.Forms.Archive
{
    partial class AdminArchiveForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExerciseInfoLabel = new System.Windows.Forms.Label();
            this.RestoreExerciseInfoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SampleWorkoutRoutinesLabel = new System.Windows.Forms.Label();
            this.RestoreSampleWokroutRoutineButton = new System.Windows.Forms.Button();
            this.ExerciseInfoListBox = new System.Windows.Forms.ListBox();
            this.SampleWorkoutRoutineListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExerciseInfoListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SampleWorkoutRoutineListBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.ExerciseInfoLabel);
            this.panel1.Controls.Add(this.RestoreExerciseInfoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 71);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExerciseInfoLabel
            // 
            this.ExerciseInfoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExerciseInfoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ExerciseInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.ExerciseInfoLabel.Name = "ExerciseInfoLabel";
            this.ExerciseInfoLabel.Size = new System.Drawing.Size(394, 13);
            this.ExerciseInfoLabel.TabIndex = 1;
            this.ExerciseInfoLabel.Text = "Exercise Info";
            this.ExerciseInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExerciseInfoLabel.Click += new System.EventHandler(this.ExerciseInfoLabel_Click);
            // 
            // RestoreExerciseInfoButton
            // 
            this.RestoreExerciseInfoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RestoreExerciseInfoButton.Location = new System.Drawing.Point(0, 33);
            this.RestoreExerciseInfoButton.Name = "RestoreExerciseInfoButton";
            this.RestoreExerciseInfoButton.Size = new System.Drawing.Size(394, 38);
            this.RestoreExerciseInfoButton.TabIndex = 0;
            this.RestoreExerciseInfoButton.Text = "Restore";
            this.RestoreExerciseInfoButton.UseVisualStyleBackColor = true;
            this.RestoreExerciseInfoButton.Click += new System.EventHandler(this.RestoreExerciseInfoButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.SampleWorkoutRoutinesLabel);
            this.panel2.Controls.Add(this.RestoreSampleWokroutRoutineButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(403, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 71);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SampleWorkoutRoutinesLabel
            // 
            this.SampleWorkoutRoutinesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SampleWorkoutRoutinesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SampleWorkoutRoutinesLabel.Location = new System.Drawing.Point(0, 0);
            this.SampleWorkoutRoutinesLabel.Name = "SampleWorkoutRoutinesLabel";
            this.SampleWorkoutRoutinesLabel.Size = new System.Drawing.Size(394, 13);
            this.SampleWorkoutRoutinesLabel.TabIndex = 2;
            this.SampleWorkoutRoutinesLabel.Text = "Sample Workout Routines";
            this.SampleWorkoutRoutinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SampleWorkoutRoutinesLabel.Click += new System.EventHandler(this.SampleWorkoutRoutinesLabel_Click);
            // 
            // RestoreSampleWokroutRoutineButton
            // 
            this.RestoreSampleWokroutRoutineButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RestoreSampleWokroutRoutineButton.Location = new System.Drawing.Point(0, 33);
            this.RestoreSampleWokroutRoutineButton.Name = "RestoreSampleWokroutRoutineButton";
            this.RestoreSampleWokroutRoutineButton.Size = new System.Drawing.Size(394, 38);
            this.RestoreSampleWokroutRoutineButton.TabIndex = 1;
            this.RestoreSampleWokroutRoutineButton.Text = "Restore";
            this.RestoreSampleWokroutRoutineButton.UseVisualStyleBackColor = true;
            this.RestoreSampleWokroutRoutineButton.Click += new System.EventHandler(this.RestoreSampleWokroutRoutineButton_Click);
            // 
            // ExerciseInfoListBox
            // 
            this.ExerciseInfoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExerciseInfoListBox.FormattingEnabled = true;
            this.ExerciseInfoListBox.Location = new System.Drawing.Point(3, 3);
            this.ExerciseInfoListBox.Name = "ExerciseInfoListBox";
            this.ExerciseInfoListBox.Size = new System.Drawing.Size(394, 367);
            this.ExerciseInfoListBox.TabIndex = 2;
            this.ExerciseInfoListBox.SelectedIndexChanged += new System.EventHandler(this.ExerciseInfoListBox_SelectedIndexChanged);
            // 
            // SampleWorkoutRoutineListBox
            // 
            this.SampleWorkoutRoutineListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleWorkoutRoutineListBox.FormattingEnabled = true;
            this.SampleWorkoutRoutineListBox.Location = new System.Drawing.Point(403, 3);
            this.SampleWorkoutRoutineListBox.Name = "SampleWorkoutRoutineListBox";
            this.SampleWorkoutRoutineListBox.Size = new System.Drawing.Size(394, 367);
            this.SampleWorkoutRoutineListBox.TabIndex = 3;
            this.SampleWorkoutRoutineListBox.SelectedIndexChanged += new System.EventHandler(this.SampleWorkoutRoutineListBox_SelectedIndexChanged);
            // 
            // AdminArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminArchiveForm";
            this.Text = "AdminArchiveForm";
            this.Load += new System.EventHandler(this.AdminArchiveForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ExerciseInfoLabel;
        private System.Windows.Forms.Button RestoreExerciseInfoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SampleWorkoutRoutinesLabel;
        private System.Windows.Forms.Button RestoreSampleWokroutRoutineButton;
        private System.Windows.Forms.ListBox ExerciseInfoListBox;
        private System.Windows.Forms.ListBox SampleWorkoutRoutineListBox;
    }
}