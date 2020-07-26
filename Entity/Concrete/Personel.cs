using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Personel : IEntity
    {
        public long Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public int KalanİzinGunu { get; set; }
    }
}
