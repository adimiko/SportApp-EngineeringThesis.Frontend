using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.RestApiClient.Models.ExerciseInfo
{
    public class ExerciseInfoDetailsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \n" +
                   $"Description: {Description} \n";
        }
    }
}
