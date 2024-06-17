using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CompanyRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Company> GetCompanyById(int id)
        {
            return await _context.Companies.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Company>> GetCompaniesAsync()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company> GetCompanyByName(string name)
        {
            return await _context.Companies.Where(c => c.Name == name).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
        }

        public async Task<IEnumerable<CompanyDto>> GetAllCompaniesAsync()
        {
            return await _context.Companies.ProjectTo<CompanyDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<CompanyDto> GetCompanyAsync(string name)
        {
            return await _context.Companies.Where(c => c.Name.ToLower().Equals(name.ToLower()))
            .ProjectTo<CompanyDto>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
        }
    }
}