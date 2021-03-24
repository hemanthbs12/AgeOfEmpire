using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfEmpire.ServiceModel
{
    public class UnitDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonProperty("hit_points")]
        public int HitPoints { get; set; }
        public int Attack { get; set; }

    }
}
