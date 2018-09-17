//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agrishare.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Telephone { get; set; }
        public Gender GenderId { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public short NotificationPreferences { get; set; }
        public Interest InterestId { get; set; }
        public string RoleList { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string AuthToken { get; set; }
        public int FailedLoginAttempts { get; set; }
        public string VerificationCode { get; set; }
        public Nullable<System.DateTime> VerificationCodeExpiry { get; set; }
        public string SignalRConnectionId { get; set; }
        public UserStatus StatusId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime LastModified { get; set; }
        public bool Deleted { get; set; }
    }
}