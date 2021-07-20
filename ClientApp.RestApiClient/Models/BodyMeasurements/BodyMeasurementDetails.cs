using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.BodyMeasurements
{
    public class BodyMeasurementDetails
    {
        public Guid Id { get; set; }
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
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()} \n" +
                   $"Description: {Description} \n" +
                   $"Weight: {Weight} \n" +
                   $"Height: {Height} \n" +
                   $"Arm: {Arm} \n" +
                   $"Chest: {Chest} \n" +
                   $"Waist: {Waist} \n" +
                   $"Hip: {Hip} \n" +
                   $"Thigh: {Thigh} \n" +
                   $"Calf: {Calf} \n" +
                   $"CreatedAt: {CreatedAt} \n" +
                   $"UpdatedAt: {UpdatedAt} \n";
        }
    }
}
