
namespace ClientApp.GUI.Forms.BodyMeasurements
{
    partial class CreateBodyMeasurementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBodyMeasurementForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CreateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalfNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ThighNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HipNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WaistNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChestNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ArmNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CalfLabel = new System.Windows.Forms.Label();
            this.ThighLabel = new System.Windows.Forms.Label();
            this.HipLabel = new System.Windows.Forms.Label();
            this.WaistLabel = new System.Windows.Forms.Label();
            this.ChestLabel = new System.Windows.Forms.Label();
            this.ArmLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalfNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThighNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HipNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaistNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArmNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CreateButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateButton.Location = new System.Drawing.Point(206, 390);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CalfNumericUpDown);
            this.panel1.Controls.Add(this.ThighNumericUpDown);
            this.panel1.Controls.Add(this.HipNumericUpDown);
            this.panel1.Controls.Add(this.WaistNumericUpDown);
            this.panel1.Controls.Add(this.ChestNumericUpDown);
            this.panel1.Controls.Add(this.ArmNumericUpDown);
            this.panel1.Controls.Add(this.HeightNumericUpDown);
            this.panel1.Controls.Add(this.WeightNumericUpDown);
            this.panel1.Controls.Add(this.CalfLabel);
            this.panel1.Controls.Add(this.ThighLabel);
            this.panel1.Controls.Add(this.HipLabel);
            this.panel1.Controls.Add(this.WaistLabel);
            this.panel1.Controls.Add(this.ChestLabel);
            this.panel1.Controls.Add(this.ArmLabel);
            this.panel1.Controls.Add(this.HeightLabel);
            this.panel1.Controls.Add(this.WeightLabel);
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Controls.Add(this.DescriptionRichTextBox);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(47, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 344);
            this.panel1.TabIndex = 1;
            // 
            // CalfNumericUpDown
            // 
            this.CalfNumericUpDown.DecimalPlaces = 2;
            this.CalfNumericUpDown.Location = new System.Drawing.Point(51, 291);
            this.CalfNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CalfNumericUpDown.Name = "CalfNumericUpDown";
            this.CalfNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CalfNumericUpDown.TabIndex = 26;
            // 
            // ThighNumericUpDown
            // 
            this.ThighNumericUpDown.DecimalPlaces = 2;
            this.ThighNumericUpDown.Location = new System.Drawing.Point(51, 265);
            this.ThighNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ThighNumericUpDown.Name = "ThighNumericUpDown";
            this.ThighNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ThighNumericUpDown.TabIndex = 25;
            // 
            // HipNumericUpDown
            // 
            this.HipNumericUpDown.DecimalPlaces = 2;
            this.HipNumericUpDown.Location = new System.Drawing.Point(51, 239);
            this.HipNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HipNumericUpDown.Name = "HipNumericUpDown";
            this.HipNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HipNumericUpDown.TabIndex = 24;
            // 
            // WaistNumericUpDown
            // 
            this.WaistNumericUpDown.DecimalPlaces = 2;
            this.WaistNumericUpDown.Location = new System.Drawing.Point(51, 213);
            this.WaistNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WaistNumericUpDown.Name = "WaistNumericUpDown";
            this.WaistNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.WaistNumericUpDown.TabIndex = 23;
            // 
            // ChestNumericUpDown
            // 
            this.ChestNumericUpDown.DecimalPlaces = 2;
            this.ChestNumericUpDown.Location = new System.Drawing.Point(51, 187);
            this.ChestNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChestNumericUpDown.Name = "ChestNumericUpDown";
            this.ChestNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ChestNumericUpDown.TabIndex = 22;
            // 
            // ArmNumericUpDown
            // 
            this.ArmNumericUpDown.DecimalPlaces = 2;
            this.ArmNumericUpDown.Location = new System.Drawing.Point(51, 161);
            this.ArmNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ArmNumericUpDown.Name = "ArmNumericUpDown";
            this.ArmNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.ArmNumericUpDown.TabIndex = 21;
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Location = new System.Drawing.Point(51, 135);
            this.HeightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HeightNumericUpDown.TabIndex = 20;
            // 
            // WeightNumericUpDown
            // 
            this.WeightNumericUpDown.DecimalPlaces = 2;
            this.WeightNumericUpDown.Location = new System.Drawing.Point(51, 109);
            this.WeightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WeightNumericUpDown.Name = "WeightNumericUpDown";
            this.WeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.WeightNumericUpDown.TabIndex = 19;
            // 
            // CalfLabel
            // 
            this.CalfLabel.AutoSize = true;
            this.CalfLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CalfLabel.Location = new System.Drawing.Point(4, 293);
            this.CalfLabel.Name = "CalfLabel";
            this.CalfLabel.Size = new System.Drawing.Size(25, 13);
            this.CalfLabel.TabIndex = 17;
            this.CalfLabel.Text = "Calf";
            // 
            // ThighLabel
            // 
            this.ThighLabel.AutoSize = true;
            this.ThighLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ThighLabel.Location = new System.Drawing.Point(4, 267);
            this.ThighLabel.Name = "ThighLabel";
            this.ThighLabel.Size = new System.Drawing.Size(34, 13);
            this.ThighLabel.TabIndex = 15;
            this.ThighLabel.Text = "Thigh";
            // 
            // HipLabel
            // 
            this.HipLabel.AutoSize = true;
            this.HipLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HipLabel.Location = new System.Drawing.Point(4, 241);
            this.HipLabel.Name = "HipLabel";
            this.HipLabel.Size = new System.Drawing.Size(23, 13);
            this.HipLabel.TabIndex = 13;
            this.HipLabel.Text = "Hip";
            // 
            // WaistLabel
            // 
            this.WaistLabel.AutoSize = true;
            this.WaistLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WaistLabel.Location = new System.Drawing.Point(4, 215);
            this.WaistLabel.Name = "WaistLabel";
            this.WaistLabel.Size = new System.Drawing.Size(34, 13);
            this.WaistLabel.TabIndex = 11;
            this.WaistLabel.Text = "Waist";
            // 
            // ChestLabel
            // 
            this.ChestLabel.AutoSize = true;
            this.ChestLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ChestLabel.Location = new System.Drawing.Point(4, 189);
            this.ChestLabel.Name = "ChestLabel";
            this.ChestLabel.Size = new System.Drawing.Size(34, 13);
            this.ChestLabel.TabIndex = 9;
            this.ChestLabel.Text = "Chest";
            // 
            // ArmLabel
            // 
            this.ArmLabel.AutoSize = true;
            this.ArmLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ArmLabel.Location = new System.Drawing.Point(4, 163);
            this.ArmLabel.Name = "ArmLabel";
            this.ArmLabel.Size = new System.Drawing.Size(25, 13);
            this.ArmLabel.TabIndex = 7;
            this.ArmLabel.Text = "Arm";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HeightLabel.Location = new System.Drawing.Point(4, 137);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 5;
            this.HeightLabel.Text = "Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WeightLabel.Location = new System.Drawing.Point(4, 111);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "Weight";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DescriptionLabel.Location = new System.Drawing.Point(4, 31);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(3, 50);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(388, 53);
            this.DescriptionRichTextBox.TabIndex = 1;
            this.DescriptionRichTextBox.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // CreateBodyMeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(488, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(422, 464);
            this.Name = "CreateBodyMeasurementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Measurement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalfNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThighNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HipNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaistNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArmNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label CalfLabel;
        private System.Windows.Forms.Label ThighLabel;
        private System.Windows.Forms.Label HipLabel;
        private System.Windows.Forms.Label WaistLabel;
        private System.Windows.Forms.Label ChestLabel;
        private System.Windows.Forms.Label ArmLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown CalfNumericUpDown;
        private System.Windows.Forms.NumericUpDown ThighNumericUpDown;
        private System.Windows.Forms.NumericUpDown HipNumericUpDown;
        private System.Windows.Forms.NumericUpDown WaistNumericUpDown;
        private System.Windows.Forms.NumericUpDown ChestNumericUpDown;
        private System.Windows.Forms.NumericUpDown ArmNumericUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown WeightNumericUpDown;
    }
}