using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface ICompanyRepository
    {
        void Update(Company company);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyById(int id);
        Task<Company> GetCompanyByName(string name);
        Task<IEnumerable<CompanyDto>> GetAllCompaniesAsync();
        Task<CompanyDto> GetCompanyAsync(string name);
    }
}