using ClientApp.GUI.Extensions;
using ClientApp.RestApiClient.Endpoints.V1.BodyMeasurements;
using ClientApp.RestApiClient.Models.BodyMeasurements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms.BodyMeasurements
{
    public partial class UpdateBodyMeasurementForm : Form
    {
        public Guid Id { get; set; }
        private readonly IBodyMeasurementsRestClient _bodyMeasurementsRestClient;
        private UpdateBodyMeasurement updateBodyMeasurement = new UpdateBodyMeasurement();
        private readonly IMessenger _messenger;

        public UpdateBodyMeasurementForm(IBodyMeasurementsRestClient bodyMeasurementsRestClient, IMessenger messenger)
        {
            _bodyMeasurementsRestClient = bodyMeasurementsRestClient;
            _messenger = messenger;
            InitializeComponent();
            
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {

            try
            {
                updateBodyMeasurement.Date = dateTimePicker.Value;
                updateBodyMeasurement.Description = DescriptionRichTextBox.Text;
                updateBodyMeasurement.Weight = (float)WeightNumericUpDown.Value;
                updateBodyMeasurement.Height = (int)HeightNumericUpDown.Value;
                updateBodyMeasurement.Arm = (float)ArmNumericUpDown.Value;
                updateBodyMeasurement.Chest = (float)ChestNumericUpDown.Value;
                updateBodyMeasurement.Waist = (float)WaistNumericUpDown.Value;
                updateBodyMeasurement.Hip = (float)HipNumericUpDown.Value;
                updateBodyMeasurement.Thigh = (float)ThighNumericUpDown.Value;
                updateBodyMeasurement.Calf = (float)CalfNumericUpDown.Value;
                await _bodyMeasurementsRestClient.UpdateAsync(Id, updateBodyMeasurement);
                this.Close();
            }
            catch (Exception ex)
            {
                _messenger.Show(ex.Message);
            }


        }

        private async void LoadFormWithData()
        {
            var bodyMeasurement = await _bodyMeasurementsRestClient.GetAsync(Id);

            dateTimePicker.Value = bodyMeasurement.Date.Date;
            DescriptionRichTextBox.Text = bodyMeasurement.Description;
            WeightNumericUpDown.Text = bodyMeasurement.Weight.ToString();
            HeightNumericUpDown.Text = bodyMeasurement.Height.ToString();
            ArmNumericUpDown.Text = bodyMeasurement.Arm.ToString();
            ChestNumericUpDown.Text = bodyMeasurement.Chest.ToString();
            WaistNumericUpDown.Text = bodyMeasurement.Waist.ToString();
            HipNumericUpDown.Text = bodyMeasurement.Hip.ToString();
            ThighNumericUpDown.Text = bodyMeasurement.Thigh.ToString();
            CalfNumericUpDown.Text = bodyMeasurement.Calf.ToString();

        }

        private void UpdateBodyMeasurementForm_Load(object sender, EventArgs e)
            => LoadFormWithData();

    }
}
