using ClientApp.GUI.Forms.BodyMeasurements;
using ClientApp.GUI.UserControls;
using ClientApp.RestApiClient.Endpoints.V1.BodyMeasurements;
using ClientApp.RestApiClient.Models.BodyMeasurements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp.GUI.Forms
{
    public partial class BodyMeasurementForm : Form
    { 

        private readonly IBodyMeasurementsRestClient _bodyMeasurementsRestClient;
        private readonly SimpleInjector.Container _container;

        public BodyMeasurementForm(SimpleInjector.Container container, IBodyMeasurementsRestClient bodyMeasurementsRestClient)
        {
            _bodyMeasurementsRestClient = bodyMeasurementsRestClient;
            _container = container;
            InitializeComponent();
            BodyMeasurementsListBox.BackColor = this.BackColor;
            BodyMeasurementsListBox.ForeColor = Color.White;
            BodyMeasurementsListBox.BorderStyle = BorderStyle.None;
        }

        private void BodyMeasurementForm_Load(object sender, EventArgs e)
        {
            RefreshBodyMeasurementsListBox();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _container.GetInstance<CreateBodyMeasurementForm>().ShowDialog();
            RefreshBodyMeasurementsListBox();
        }

        private async void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (BodyMeasurementsListBox.SelectedItem == null) return;
            var obj = BodyMeasurementsListBox.SelectedItem;
            var bm = obj as BodyMeasurement;
            var bmDetails = await _bodyMeasurementsRestClient.GetAsync(bm.Id);
            MessageBox.Show(bmDetails.ToString());
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BodyMeasurementsListBox.SelectedItem == null) return;
            var obj = BodyMeasurementsListBox.SelectedItem;
            var bm = obj as BodyMeasurement;
            await _bodyMeasurementsRestClient.DeleteAsync(bm.Id);
            RefreshBodyMeasurementsListBox();
        }


        private async void RefreshBodyMeasurementsListBox()
        {
            var bodyMeasurements = await _bodyMeasurementsRestClient.BrowseAsync();
            if (bodyMeasurements == null) bodyMeasurements = new List<BodyMeasurement>();
            BodyMeasurementsListBox.Items.Clear();
            BodyMeasurementsListBox.Items.AddRange(bodyMeasurements.ToArray());
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (BodyMeasurementsListBox.SelectedItem == null) return;
            var obj = BodyMeasurementsListBox.SelectedItem;
            var bm = obj as BodyMeasurement;

            var updateForm = _container.GetInstance<UpdateBodyMeasurementForm>();
            updateForm.Id = bm.Id;
            updateForm.ShowDialog();

            RefreshBodyMeasurementsListBox();
        }
    }
}
