
namespace ClientApp.GUI.Forms.StartWorkout
{
    partial class StartWorkoutForm
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
            this.SampleWorkoutRoutineListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomWorkoutRoutineLabel = new System.Windows.Forms.Label();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SampleWorkoutRoutinesLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.CustomWorkoutRoutineListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CustomWorkoutRoutineListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SampleWorkoutRoutineListBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.CustomWorkoutRoutineLabel);
            this.panel1.Controls.Add(this.ViewDetailsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 71);
            this.panel1.TabIndex = 0;
            // 
            // CustomWorkoutRoutineLabel
            // 
            this.CustomWorkoutRoutineLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomWorkoutRoutineLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomWorkoutRoutineLabel.Location = new System.Drawing.Point(0, 0);
            this.CustomWorkoutRoutineLabel.Name = "CustomWorkoutRoutineLabel";
            this.CustomWorkoutRoutineLabel.Size = new System.Drawing.Size(394, 13);
            this.CustomWorkoutRoutineLabel.TabIndex = 1;
            this.CustomWorkoutRoutineLabel.Text = "Your Wokrout Routines";
            this.CustomWorkoutRoutineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ViewDetailsButton.Location = new System.Drawing.Point(0, 33);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.Size = new System.Drawing.Size(394, 38);
            this.ViewDetailsButton.TabIndex = 0;
            this.ViewDetailsButton.Text = "View Details";
            this.ViewDetailsButton.UseVisualStyleBackColor = true;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.SampleWorkoutRoutinesLabel);
            this.panel2.Controls.Add(this.StartButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(403, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 71);
            this.panel2.TabIndex = 1;
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
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartButton.Location = new System.Drawing.Point(0, 33);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(394, 38);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CustomWorkoutRoutineListBox
            // 
            this.CustomWorkoutRoutineListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomWorkoutRoutineListBox.FormattingEnabled = true;
            this.CustomWorkoutRoutineListBox.Location = new System.Drawing.Point(3, 3);
            this.CustomWorkoutRoutineListBox.Name = "CustomWorkoutRoutineListBox";
            this.CustomWorkoutRoutineListBox.Size = new System.Drawing.Size(394, 367);
            this.CustomWorkoutRoutineListBox.TabIndex = 2;
            this.CustomWorkoutRoutineListBox.SelectedIndexChanged += new System.EventHandler(this.CustomWorkoutRoutineListBox_SelectedIndexChanged);
            // 
            // StartWorkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartWorkoutForm";
            this.Text = "StartWorkoutForms";
            this.Load += new System.EventHandler(this.StartWorkoutForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SampleWorkoutRoutineListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CustomWorkoutRoutineLabel;
        private System.Windows.Forms.Button ViewDetailsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SampleWorkoutRoutinesLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListBox CustomWorkoutRoutineListBox;
    }
}