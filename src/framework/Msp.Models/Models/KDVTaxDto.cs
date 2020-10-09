using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Models.Models
{
    public class KDVTaxDto
    {
        public KDVTaxDto(int id, string value, double taxOran, int tax)
        {
            Id = id;
            Value = value;
            TaxOrani = taxOran;
            Tax = tax;

        }
        public int Id { get; set; }

        public string Value { get; set; }

        public double TaxOrani { get; set; }
        public int Tax { get; set; }
    }
}
