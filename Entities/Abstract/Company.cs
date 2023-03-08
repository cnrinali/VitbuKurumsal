using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public class Company : EntityBase
    {
        public string TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTitle { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyMail { get; set; }
        public string CompanyPhone { get; set; }
        public string AuthorizedPerson { get; set; }
        public string AuthorizedPersonPhone { get; set; }
        public string Description { get; set; }
        public string CompanyType { get; set; }

        public virtual List<Vehicle> Vehicles { get; set; }
        public virtual List<User> Users { get; set; }
        public virtual List<Price> Prices { get; set; }
        public virtual List<Rezervation> Rezervations { get; set; }

        public Company()
        {
            Rezervations = new List<Rezervation>();
            Vehicles = new List<Vehicle>();
            Users = new List<User>();
            Prices = new List<Price>();
        }
    }
}
