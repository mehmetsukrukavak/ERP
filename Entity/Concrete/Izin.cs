using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Entity.Concrete
{
    public class Izin : IEntity
    {
        [JsonIgnore]
        public long Id { get; set; }
        public long PersonelId { get; set; }
        public DateTime IzinBaslamaTarihi { get; set; }
        public DateTime IzinBitisTarihi { get; set; }
    }
}
