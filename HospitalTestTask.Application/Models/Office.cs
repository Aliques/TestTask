
using HospitalTestTask.Domain.Entities;

namespace HospitalTestTask.Application.Models
{
    public class Office : Entity<long>
    {
        public int Number { get; set; }
    }
}
