//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBookStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public string id_Book { get; set; }
        public int id_Order { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}
