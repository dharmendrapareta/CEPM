//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEPMDL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfile
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public System.DateTime Dob { get; set; }
        public string Mobile { get; set; }
        public string TelPhone { get; set; }
        public string Email { get; set; }
        public string VoterId { get; set; }
        public string PanCard { get; set; }
        public string DrivingLicense { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual User User { get; set; }
    }
}
