using HospitalTestTask.Core.Application.Enums;
using HospitalTestTask.Core.DTO.RefsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTestTask.Core.DTO.Patient
{
    public class PatientDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public DistrictPartDto DistrictPart { get; set; }
    }
}
