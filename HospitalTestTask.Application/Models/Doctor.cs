
using HospitalTestTask.Domain.Entities;

namespace HospitalTestTask.Application.Models
{
    public class Doctor : Entity<long>
    {
        /// <summary>
        /// ФИО по заданию в одном поле
        /// </summary>
        public string FullName { get; set; }
        public long OfficeId { get; set; }
        public Office Office { get; set; }
        public long SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
        public long? DistrictPartId { get; set; }
        public DistrictPart DistrictPart { get; set; }
    }
}
