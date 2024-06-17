using API.Controllers;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API;

public class CompanyController : BaseApiController
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public CompanyController(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanies()
    {
        var companies = await _companyRepository.GetCompaniesAsync();

        return Ok(companies);
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<CompanyDto>> GetCompany(string name)
    {
        return await _companyRepository.GetCompanyAsync(name);
    }
}
