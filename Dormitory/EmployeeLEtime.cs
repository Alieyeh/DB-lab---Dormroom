//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dormitory
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeLEtime
    {
        public int EId { get; set; }
        public System.DateTime EntranceTime { get; set; }
        public System.DateTime LeavingTime { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
