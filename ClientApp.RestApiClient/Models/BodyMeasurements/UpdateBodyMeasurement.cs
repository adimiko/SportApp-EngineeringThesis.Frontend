using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.BodyMeasurements
{
    public class UpdateBodyMeasurement
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        public float Arm { get; set; }
        public float Chest { get; set; }
        public float Waist { get; set; }
        public float Hip { get; set; }
        public float Thigh { get; set; }
        public float Calf { get; set; }
    }
}
