using System;

namespace CEPMBL.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime EstablishedDate { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string TinNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
