
using HospitalTestTask.Domain.Entities;
using System.Numerics;

namespace HospitalTestTask.Application.Models
{
    public class Office : Entity<long>
    {
        public int Number { get; set; }
    }
}
