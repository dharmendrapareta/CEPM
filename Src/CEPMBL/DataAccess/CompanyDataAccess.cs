using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CEPMBL.Entities;

namespace CEPMBL.DataAccess
{
    public class CompanyDataAccess : BaseDataAccess
    {
        private readonly string _currentUserName;
        public CompanyDataAccess(string userName)
        {
            _currentUserName = userName;
        }
        //list
        public List<Company> GetCompanies()
        {
            var lstResult = new List<Company>();

            var lstcompanies = DataContext.Companies.ToList();
            foreach (var company in lstcompanies)
            {
                //create new object
                var result = new Company();
                result.CompanyId = company.CompanyId;
                result.CompanyName = company.CompanyName;
                result.EstablishedDate = company.EstablishedDate;
                result.WebSite = company.WebSite;
                result.RegistrationNumber = company.RegistrationNumber;
                result.Email = company.Email;
                result.TinNumber = company.TinNumber;
                result.IsActive = company.IsActive;
                //add in list
                lstResult.Add(result);
            }
            return lstResult;
        }
        //detail
        public Company GetCompany(int companyId)
        {
            var result = new Company();

            var company = DataContext.Companies.Find(companyId);

            if (company != null)
            {
                result.CompanyId = company.CompanyId;
                result.CompanyName = company.CompanyName;
                result.EstablishedDate = company.EstablishedDate;
                result.WebSite = company.WebSite;
                result.RegistrationNumber = company.RegistrationNumber;
                result.Email = company.Email;
                result.TinNumber = company.TinNumber;
                result.IsActive = company.IsActive;
            }

            return result;
        }
        //save
        public void SaveCompany(Company company)
        {
            var result = DataContext.Companies.Find(company.CompanyId);

            if (result == null)
            {
                result = new CEPMDL.Company
                    {
                        CreatedOn = DateTime.Now, 
                        CreatedBy = _currentUserName
                    };
                DataContext.Companies.Add(result);
            }
            //last user modify information store
            result.ModifiedOn = DateTime.Now;
            result.ModifiedBy = _currentUserName;

            result.CompanyName = company.CompanyName;
            result.EstablishedDate = company.EstablishedDate;
            result.WebSite = company.WebSite;
            result.RegistrationNumber = company.RegistrationNumber;
            result.Email = company.Email;
            result.TinNumber = company.TinNumber;
            result.IsActive = company.IsActive;

            Commit();
            
        }
        //delete
        public void DeleteCompany(int companyId)
        {
            var company = DataContext.Companies.Find(companyId);

            DataContext.Companies.Remove(company);

            Commit();
        }
    }
}
