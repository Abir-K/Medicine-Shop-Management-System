using Medicalshop.DataAccess_Layer;
using Medicalshop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.BusinessLogic_Layer
{
    class SalesInfoService
    {
        SalesDataAccess salesDataAccess;

        public SalesInfoService()
        {
            this.salesDataAccess = new SalesDataAccess();
        }

        public List<Sales> GetAllInfo()
        {
            return this.salesDataAccess.GetAllData();
        }

        public int AddSellingMedicines(string userToken,string medicineName, int medicineQuantity, double sellingPrice, string sellingDate,string sellingStatus)
        {
            Sales sales = new Sales();
            sales.UserToken = userToken;
            sales.MedicineName = medicineName;
            sales.SalesMedicineQuantity= medicineQuantity;
            sales.SellingPrice = sellingPrice;
            sales.SellingDate = sellingDate;
            sales.SellingStatus = sellingStatus;
            return this.salesDataAccess.SellingMedicines(sales);
        }

        public int UpdateExistingSalesInfo(string userToken, string sellingStatus)
        {
            Sales sales = new Sales();
            sales.SellingStatus = sellingStatus;
            return this.salesDataAccess.UpdateSellingInfo(sales, userToken);
        }
    }
}
