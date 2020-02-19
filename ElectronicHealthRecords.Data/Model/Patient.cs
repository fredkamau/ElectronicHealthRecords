using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicHealthRecords.Data.Model
{
    class Patient
    {
        [Key]
        public Guid PatientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public int? WardID { get; set; }
        public string Illness { get; set; }
        public DateTime visitationDate { get; set; }
        public Guid? Doctor { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Weight { get; set; }
        public int Height { get; set; }
        public decimal BMI { get; set; }
        public decimal BloodPressure { get; set; }

    }
}
