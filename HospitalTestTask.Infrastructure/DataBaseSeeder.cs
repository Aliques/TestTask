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

        public static Doctor[] Doctors = new[]
        {
            new Doctor
            {
                Id = 1,
                DistrictPartId = 3,
                FullName = "Doctor_FullName_1",
                OfficeId = 5,
                SpecializationId = 1
            },
            new Doctor
            {
                Id = 2,
                DistrictPartId = null,
                FullName = "Doctor_FullName_2",
                OfficeId = 2,
                SpecializationId = 2
            },
            new Doctor
            {
                Id = 3,
                DistrictPartId = null,
                FullName = "Doctor_FullName_3",
                OfficeId = 3,
                SpecializationId = 2
            },
            new Doctor
            {
                Id = 4,
                DistrictPartId = 1,
                FullName = "Doctor_FullName_4",
                OfficeId = 1,
                SpecializationId = 1
            },
            new Doctor
            {
                Id = 5,
                DistrictPartId = 5,
                FullName = "Doctor_FullName_5",
                OfficeId = 4,
                SpecializationId = 1
            },
            new Doctor
            {
                Id = 6,
                DistrictPartId = 2,
                FullName = "Doctor_FullName_6",
                OfficeId = 3,
                SpecializationId = 1
            },
            new Doctor
            {
                Id = 7,
                DistrictPartId = null,
                FullName = "Doctor_FullName_7",
                OfficeId = 1,
                SpecializationId = 3
            },
        };

        public static Patient[] Patients = new[]
        {
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 3,
                Name = "Patient_FirstName_1",
                Surname = "Patient_Surname_1",
                Patronymic = "Patient_Patronymic_1",
                Address = "Address_1_1",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Male
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 1,
                Name = "Patient_FirstName_2",
                Surname = "Patient_Surname_2",
                Patronymic = "Patient_Patronymic_2",
                Address = "Address_21_5",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Female
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 3,
                Name = "Patient_FirstName_3",
                Surname = "Patient_Surname_3",
                Patronymic = null,
                Address = "Address_12_22",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Male
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 2,
                Name = "Patient_FirstName_4",
                Surname = "Patient_Surname_4",
                Patronymic = "Patient_Patronymic_4",
                Address = "Address_224_4",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Male
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 3,
                Name = "Patient_FirstName_5",
                Surname = "Patient_Surname_5",
                Patronymic = "Patient_Patronymic_5",
                Address = "Address_5_44",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Male
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 2,
                Name = "Patient_FirstName_6",
                Surname = "Patient_Surname_6",
                Patronymic = "Patient_Patronymic_6",
                Address = "Address_7_4",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Female
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 1,
                Name = "Patient_FirstName_7",
                Surname = "Patient_Surname_7",
                Patronymic = "Patient_Patronymic_7",
                Address = "Address_1_1",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Female
            },
            new Patient
            {
                Id = Guid.NewGuid(),
                DistrictPartId = 4,
                Name = "Patient_FirstName_8",
                Surname = "Patient_Surname_8",
                Patronymic = "Patient_Patronymic_8",
                Address = "Address_22_41",
                BirthDate = DateTime.Now,
                Gender = Core.Application.Enums.Gender.Male
            },
        };
    }
}
