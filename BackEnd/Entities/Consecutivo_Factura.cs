//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consecutivo_Factura
    {
        public int compania { get; set; }
        public int consecutivo_factura { get; set; }
    
        public virtual Compania Companias { get; set; }
    }
}
