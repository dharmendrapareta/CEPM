using System.Collections.Generic;
using CEPMBL.DataAccess;
using CEPMBL.Entities;

namespace CEPMBL.Manager
{
    public class CompanyManager: BaseManager
    {
        private readonly CompanyDataAccess _dataAccess;
        public CompanyManager(string userName)
        {
            _dataAccess = new CompanyDataAccess(userName);
        }

        //list
        public List<Company> GetCompanies()
        {
            var lstcompanies = _dataAccess.GetCompanies();
            return lstcompanies;
        }
        //detail
        public Company GetCompany(int companyId)
        {
            var company = _dataAccess.GetCompany(companyId);
            return company;
        }
        //save
        public void SaveCompany(Company company)
        {
            _dataAccess.SaveCompany(company);
        }
        //delete
        public void DeleteCompany(int companyId)
        {
            _dataAccess.DeleteCompany(companyId);
        }
    }
}
