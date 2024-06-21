
using API.DTOs;

namespace API.Interfaces
{
    public interface ICertificateService
    {
        CertificateDto AwardCertificate(int assessmentId, DateTime awardDate);
    }
}