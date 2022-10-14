
using HospitalTestTask.Domain.Entities;
using System.Security.Cryptography;

namespace HospitalTestTask.Application.Models
{
    public class DistrictPart : Entity<long>
    {
        public long Number { get; set; }
    }
}
