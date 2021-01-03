using Medicalshop.DataAccess_Layer;
using Medicalshop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicalshop.BusinessLogic_Layer
{
    class MedicineInfoServices
    {
        MedicineDataAccess medicineDataAccess;

        public MedicineInfoServices()
        {
            this.medicineDataAccess = new MedicineDataAccess();
        }

        public List<Medicines> GetAllMedicineInfo()
        {
            return this.medicineDataAccess.GetAllMedicineData();
        }

        public int AddnewMedicines(string medicineName, string medicineGroup, int medicineQuantity, string addingDate, double medicinePrice)
        {
            Medicines medicines = new Medicines();
            medicines.MedicineName = medicineName;
            medicines.MedicineGroup = medicineGroup;
            medicines.MedicineQuantity = medicineQuantity;
            medicines.MedicineAddingDate = addingDate;
            medicines.MedicinePrice = medicinePrice;
            return this.medicineDataAccess.NewMedicinesAdd(medicines);
        }

        public int DeleteMedicine(int medicineId)
        {
            return this.medicineDataAccess.DeleteMedicines(medicineId);
        }

        public List<Medicines> GetAllMedicineInfo(string medicineName)
        {
            return this.medicineDataAccess.GetAllMedicineData(medicineName);
        }

        public int UpdateExistingMedicine(string medicineName, string medicineGroup, int medicineQuantity, string adddingDate, int medicineId)
        {
            Medicines medicines = new Medicines();
            medicines.MedicineName = medicineName;
            medicines.MedicineGroup = medicineGroup;
            medicines.MedicineQuantity = medicineQuantity;
            medicines.MedicineAddingDate = adddingDate;
            return this.medicineDataAccess.UpdateMedicineInfo(medicines, medicineId);
        }
    }
}
