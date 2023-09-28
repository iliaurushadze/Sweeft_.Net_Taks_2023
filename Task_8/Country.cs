using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Country
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string? Subregion { get; set; }
        public JArray LatlngArray { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Area { get; set; }
        public long Population { get; set; }
    }
}
