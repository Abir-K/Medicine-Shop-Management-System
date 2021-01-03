using Medicalshop.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.DataAccess_Layer
{
    class MedicineDataAccess
    {
        DataAccess dataAccess;
        public MedicineDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Medicines> GetAllMedicineData()
        {
            string sql = "SELECT * FROM ShopMedicines ;";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Medicines> medicine = new List<Medicines>();
            while (reader.Read())
            {
                Medicines medicine1 = new Medicines();
                medicine1.MedicineId = (int)reader["MedicineId"];
                medicine1.MedicineName = reader["MedicineName"].ToString();
                medicine1.MedicineGroup = reader["MedicineGroup"].ToString();
                medicine1.MedicineQuantity = (int)reader["Quantity"];
                medicine1.MedicineAddingDate = reader["AddingDate"].ToString();
                medicine1.MedicinePrice = (double)reader["Price"];
                medicine.Add(medicine1);
            }

            return medicine;
        }

        public int NewMedicinesAdd(Medicines medicines)
        {
            string sql = "INSERT INTO ShopMedicines(MedicineName,MedicineGroup,Quantity,AddingDate,Price) VALUES('" + medicines.MedicineName + "','" + medicines.MedicineGroup + "','" + medicines.MedicineQuantity + "','" + medicines.MedicineAddingDate + "','" + medicines.MedicinePrice + "');";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int DeleteMedicines(int medicineId)
        {
            string sql = "DELETE FROM ShopMedicines WHERE UserId='" + medicineId + "';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<Medicines> GetAllMedicineData(string medicineName)
        {
            string sql = "SELECT * FROM ShopMedicines WHERE MedicineName='"+medicineName+"' OR MedicineGroup='"+medicineName+"' ;";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Medicines> medicine = new List<Medicines>();
            while (reader.Read())
            {
                Medicines medicine1 = new Medicines();
                medicine1.MedicineId = (int)reader["MedicineId"];
                medicine1.MedicineName = reader["MedicineName"].ToString();
                medicine1.MedicineGroup = reader["MedicineGroup"].ToString();
                medicine1.MedicineQuantity = (int)reader["Quantity"];
                medicine1.MedicineAddingDate = reader["AddingDate"].ToString();
                medicine1.MedicinePrice = (double)reader["Price"];
                medicine.Add(medicine1);
            }

            return medicine;
        }

        public int UpdateMedicineInfo(Medicines medicine, int medicineId)
        {
            string sql = "UPDATE ShopMedicines SET MedicineName='" + medicine.MedicineName + "',MedicineGroup='" + medicine.MedicineGroup + "',Quantity='" + medicine.MedicineQuantity + "',AddingDate='" + medicine.MedicineAddingDate + "' WHERE MedicineId='" + medicineId + "';";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
    }
}
