using HospitalTestTask.Application.Interfaces.Services;
using HospitalTestTask.Core.Application.Requests.Doctor;
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Core.DTO.Doctor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalTestTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<ActionResult<IPaginatedResult<DoctorDto>>> GetDoctors([FromQuery] DoctorRequest doctorRequest)
        {
            return Ok(await _doctorService.GetAllPaginated(doctorRequest));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IPaginatedResult<DoctorDto>>> GetDoctors(long id)
        {
            return Ok(await _doctorService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<IPaginatedResult<DoctorDto>>> CreateDoctor(DoctorCreationDto doctor)
        {
            return Ok(await _doctorService.AddAsync(doctor));
        }

        [HttpPut]
        public async Task<ActionResult<IPaginatedResult<DoctorDto>>> UpdateDoctor(DoctorUpdateDto doctor)
        {
            return Ok(await _doctorService.UpdateAsync(doctor));
        }

        [HttpDelete]
        public async Task<ActionResult<IPaginatedResult<DoctorDto>>> DeleteDoctor(long id)
        {
            return Ok(await _doctorService.DeleteAsync(id));
        }
    }
}
