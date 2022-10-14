
namespace HospitalTestTask.Core.DTO.Doctor
{
    public class DoctorCreationDto
    {
        public string FullName { get; set; }
        public long OfficeId { get; set; }
        public long SpecializationId { get; set; }
        public long? DistrictPartId { get; set; }
    }
}
