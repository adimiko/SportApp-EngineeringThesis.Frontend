﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.BodyMeasurements
{
    public class BodyMeasurement
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "Date: " + Date.ToShortDateString() + " Description: " + Description;
        }
    }
}
