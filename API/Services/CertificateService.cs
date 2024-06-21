using API.DTOs;
using API.Entities;
using API.Interfaces;
using System;

namespace API.Services
{
    public class CertificateService : ICertificateService
    {
        public CertificateDto AwardCertificate(int assessmentId, DateTime awardDate)
        {
            Assessment assessment = GetAssessmentById(assessmentId);

            DateTime expiryDate = awardDate.AddYears(1);

            var certificate = new Certificate
            {
                AssessmentId = assessment.Id,
                Assessment = assessment,
                Type = assessment.Type,
                AwardDate = awardDate,
                ExpiryDate = expiryDate
            };

            return new CertificateDto
            {
                Id = certificate.Id,
                AssessmentId = certificate.AssessmentId,
                Type = (DTOs.AssessmentType)certificate.Type,
                AwardDate = certificate.AwardDate,
                ExpiryDate = certificate.ExpiryDate
            };
        }

        private Assessment GetAssessmentById(int assessmentId)
        {
            throw new NotImplementedException();
        }
    }
}
