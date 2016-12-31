using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System;
using System.Data;

namespace ClinicManager.DataBusiness
{
    public class PatientBusiness
    {
        #region Contructor
        private PatientAccess dataAccess;

        public PatientBusiness()
        {
            dataAccess = new PatientAccess();
        }

        #endregion

        public int Insert(object data)
        {
            return dataAccess.Insert(data);
        }

        public bool Update(object data)
        {
            return dataAccess.Update(data);
        }

        public bool Delete(int id)
        {
            return dataAccess.Delete(id);
        }

        public System.Data.DataTable GetAll()
        {
            return dataAccess.GetAll();
        }
        public System.Data.DataTable GetByCondition(string name, DateTime dateOfBirth, string gender)
        {
            return dataAccess.GetByCondition(name,dateOfBirth,gender);
        }
        public Patient GetbyId(int id)
        {
            Patient patient = new Patient();
            DataTable patientTable = dataAccess.GetById(id);
            if (patientTable.Rows.Count >0)
            {
                patient.FullName = patientTable.Rows[0]["FullName"].ToString();
                patient.PatientID = (int)patientTable.Rows[0]["PatientID"];
                patient.Gender =  patientTable.Rows[0]["Gender"].ToString();
                patient.Address = patientTable.Rows[0]["Address"].ToString();
                patient.DateOfBirth = (DateTime)patientTable.Rows[0]["DateOfBirth"] ;
                patient.Job = patientTable.Rows[0]["Job"].ToString();
                patient.Job= patientTable.Rows[0]["Job"].ToString();
                patient.Note= patientTable.Rows[0]["Note"].ToString();
                patient.CreateDate= (DateTime)patientTable.Rows[0]["CreateDate"] ;
             
            }
            return patient;
        }

        public string Validate(object data, string property)
        {
            return dataAccess.Validate(data, property);
        }
    }
}
