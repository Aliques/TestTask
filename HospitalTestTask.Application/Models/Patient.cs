using HospitalTestTask.Core.Application.Enums;
using HospitalTestTask.Domain.Entities;

namespace HospitalTestTask.Application.Models
{
    public class Patient : Entity<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public long DistrictPartId { get; set; }
        public virtual DistrictPart DistrictPart { get; set; }
    }
}
