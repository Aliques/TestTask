using HospitalTestTask.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTestTask.Infrastructure
{
    public static class DataBaseSeeder
    {
        public static DistrictPart[] DistrictParts = new[]
        {
            new DistrictPart{Id = 1, Number = 112},
            new DistrictPart{Id = 2, Number = 113},
            new DistrictPart{Id = 3, Number = 114},
            new DistrictPart{Id = 4, Number = 115},
            new DistrictPart{Id = 5, Number = 116}
        };

        public static Office[] Offices = new[]
        {
            new Office{Id = 1, Number = 210},
            new Office{Id = 2, Number = 220},
            new Office{Id = 3, Number = 213},
            new Office{Id = 4, Number = 314},
            new Office{Id = 5, Number = 302}
        };

        public static Specialization[] Specializations = new[]
        {
            new Specialization{Id = 1, Name = "Терапевт"},
            new Specialization{Id = 2, Name = "Хирург"},
            new Specialization{Id = 3, Name = "Офтальмолог"}
        };
    }
}
