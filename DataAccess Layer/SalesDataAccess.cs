using Medicalshop.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.DataAccess_Layer
{
    class SalesDataAccess
    {
        DataAccess dataAccess;
        public SalesDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Sales> GetAllData()
        {
            string sql = "SELECT * FROM GlobalSales ";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Sales> sell = new List<Sales>();
            while (reader.Read())
            {
                Sales sales = new Sales();
                sales.UserToken = reader["UserToken"].ToString();
                sales.MedicineName = reader["MedicineName"].ToString();
                sales.SalesMedicineQuantity = (int)reader["Quantity"];
                sales.SellingPrice = (double)reader["SellingPrice"];
                sales.SellingDate = reader["SellingDate"].ToString();
                sales.SellingStatus = reader["SellingStatus"].ToString();
                sell.Add(sales);
            }

            return sell;
        }

        public int SellingMedicines(Sales sales)
        {
            string sql = "INSERT INTO GlobalSales(UserToken,MedicineName,Quantity,SellingPrice,SellingDate,SellingStatus) VALUES('"+sales.UserToken+"','" + sales.MedicineName + "','" + sales.SalesMedicineQuantity + "','" + sales.SellingPrice + "','"+ sales.SellingDate + "','"+sales.SellingStatus+"');";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateSellingInfo(Sales sales, string userToken)
        {
            string sql = "UPDATE GlobalSales SET SellingStatus='" + sales.SellingStatus + "' WHERE UserToken='" + userToken + "';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
