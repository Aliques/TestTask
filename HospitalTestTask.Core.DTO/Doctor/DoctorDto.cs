using HospitalTestTask.Core.DTO.RefsDto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalTestTask.Core.DTO.Doctor
{
    public class DoctorDto
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public OfficeDto Office { get; set; }
        public SpecializationDto Specialization { get; set; }
        public DistrictPartDto DistrictPart { get; set; }
    }
}
