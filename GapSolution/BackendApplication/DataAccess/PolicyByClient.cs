//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendApplication.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class PolicyByClient
    {
        public int IdClient { get; set; }
        public int IdPolicy { get; set; }
        public decimal CoverPercentage { get; set; }
        public System.DateTime DateCreation { get; set; }
    }
}
