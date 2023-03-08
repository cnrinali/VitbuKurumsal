using System;
using System.Collections.Generic;

namespace Entities.Abstract
{
	public class Customer :EntityBase
	{
		public string Uyruk { get; set; }
		public string Cinsiyet { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string KimlikNo { get; set; }
		public string PasaportNo { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Sms { get; set; }

        public Guid? RezervationId { get; set; }

        public virtual Rezervation Rezervations { get; set; }
    }
}