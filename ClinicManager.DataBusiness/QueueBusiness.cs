using System;
using System.Data;
using ClinicManager.DataAccess;

namespace ClinicManager.DataBusiness
{
    public class QueueBusiness
    {
        #region Contructor
        private QueueAccess dataAccess;

        public QueueBusiness()
        {
            dataAccess = new QueueAccess();
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

        public DataTable GetQueueByDoctorId(int id)
        {
            return dataAccess.GetQueueByDoctorId(id);
        }

        public DataTable GetAll()
        {
            return dataAccess.GetAll();
        }

        public DataTable GetByDate(DateTime today)
        {
            return dataAccess.GetByDate(today);
        }

        public string Validate(object data, string propertyName)
        {
            string result = "";

            switch (propertyName)
            {
                case "ExamineReason":
                    if (string.IsNullOrWhiteSpace(data as string))
                    {
                        result = "Chưa nhập lý do khám";
                    }
                    break;
                case "DoctorId":
                    if (data == null || (int)data == 0)
                    {
                        result = "Chưa chọn bác sĩ";
                    }
                    break;
                default:
                    break;
            }

            return result;
        }

        public void UpdateStatus(int queueID, string status)
        {
            var queue = dataAccess.GetQueueById(queueID);
            queue.Status = status;
            dataAccess.Update(queue);
        }
    }
}
