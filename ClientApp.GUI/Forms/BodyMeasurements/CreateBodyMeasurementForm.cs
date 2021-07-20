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
    public partial class CreateBodyMeasurementForm : Form
    {
        private IBodyMeasurementsRestClient _bodyMeasurementsRestClient;
        private CreateBodyMeasurement createBodyMeasurement = new CreateBodyMeasurement();
        private readonly IMessenger _messenger;
        public CreateBodyMeasurementForm(IBodyMeasurementsRestClient bodyMeasurementsRestClient, IMessenger messenger)
        {
            _bodyMeasurementsRestClient = bodyMeasurementsRestClient;
            _messenger = messenger;
            InitializeComponent();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                createBodyMeasurement.Date = dateTimePicker.Value;
                createBodyMeasurement.Description = DescriptionRichTextBox.Text;
                createBodyMeasurement.Weight = (float)WeightNumericUpDown.Value;
                createBodyMeasurement.Height = (int)HeightNumericUpDown.Value;
                createBodyMeasurement.Arm = (float)ArmNumericUpDown.Value;
                createBodyMeasurement.Chest = (float)ChestNumericUpDown.Value;
                createBodyMeasurement.Waist = (float)WaistNumericUpDown.Value;
                createBodyMeasurement.Hip = (float)HipNumericUpDown.Value;
                createBodyMeasurement.Thigh = (float)ThighNumericUpDown.Value;
                createBodyMeasurement.Calf = (float)CalfNumericUpDown.Value;
                await _bodyMeasurementsRestClient.CreateAsync(createBodyMeasurement);
                this.Close();
            }
            catch(Exception ex)
            {
                
                _messenger.Show(ex.Message);
                createBodyMeasurement = new CreateBodyMeasurement();
            }
        }
    }
}
