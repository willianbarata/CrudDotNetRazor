using CompanyCrudBlazor.Models;

namespace CompanyCrudBlazor.Services
{
    public interface ICompanyServices
    {
        Task Add(Company company);
        Task Update(Company company);
        Task Delete(Company company);
        Task<Company> GetById(Guid id);
        Task<List<Company>> FindAll();
    }
}
