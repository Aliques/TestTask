
using HospitalTestTask.Domain.Entities;

namespace HospitalTestTask.Application.Models
{
    public class Specialization : Entity<long>
    {
        public string Name { get; set; }
    }
}
