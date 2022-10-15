using HospitalTestTask.Core.Application.Enums;

namespace HospitalTestTask.Core.DTO.Patient
{
    public class PatientUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender? Gender { get; set; }
        public long DistrictPartId { get; set; }
    }
}
