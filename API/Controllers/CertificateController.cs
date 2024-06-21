using API.DTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Authorize]
    public class CertificateController : BaseApiController
    {
        private readonly ICertificateService _certificateService;

        public CertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpPost("award")]
        public IActionResult AwardCertificate(int assessmentId)
        {
            DateTime awardDate = DateTime.Today;

            CertificateDto certificateDto = _certificateService.AwardCertificate(assessmentId, awardDate);

            return Ok(certificateDto);
        }
    }
}
