//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proiectfinalpssc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRANSACTION
    {
        public string ID { get; set; }
        public string USERIBAN { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}
