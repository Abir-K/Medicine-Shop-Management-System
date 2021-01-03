using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.Entity
{
    class Sales
    {
        public string UserToken { get; set; }
        public string MedicineName { get; set; }
        public int SalesMedicineQuantity { get; set; }
        public double SellingPrice { get; set; }
        public string SellingDate { get; set; }
        public string SellingStatus { set; get; }
    }
}
