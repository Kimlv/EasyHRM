//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeeHRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLoginLog
    {
        public int Id { get; set; }
        public Nullable<int> LoginUser { get; set; }
        public string LoginUserGUID { get; set; }
        public Nullable<System.DateTime> LoginDate { get; set; }
    }
}