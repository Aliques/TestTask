using HospitalTestTask.Application.Interfaces.Services;
using HospitalTestTask.Core.Application.Requests.Patient;
using HospitalTestTask.Core.Application.Wrapper;
using HospitalTestTask.Core.DTO.Patient;
using HospitalTestTask.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalTestTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<ActionResult<IPaginatedResult<PatientDto>>> GetPatients([FromQuery] PatientRequest patientRequest)
        {
            return Ok(await _patientService.GetAllPaginated(patientRequest));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IPaginatedResult<PatientDto>>> GetPatient(Guid id)
        {
            return Ok(await _patientService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult<IPaginatedResult<PatientDto>>> CreatePatient(PatientCreationDto patient)
        {
            return Ok(await _patientService.AddAsync(patient));
        }

        [HttpPut]
        public async Task<ActionResult<IPaginatedResult<PatientDto>>> UpdatePatientr(PatientUpdateDto patient)
        {
            return Ok(await _patientService.UpdateAsync(patient));
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeletePatient(Guid id)
        {
            return Ok(await _patientService.DeleteAsync(id));
        }
    }
}
