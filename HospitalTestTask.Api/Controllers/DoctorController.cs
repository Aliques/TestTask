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
        public async Task<ActionResult<IPaginatedResult<DoctorDto>>> GetUsers([FromQuery]DoctorRequest doctorRequest)
        {
            return Ok(await _doctorService.GetAllPaginated(doctorRequest));
        }
    }
}
