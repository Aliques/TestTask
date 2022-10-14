
using System.ComponentModel.DataAnnotations;

namespace HospitalTestTask.Domain.Entities
{
    public abstract class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; set; }
    }
}
