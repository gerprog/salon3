//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public Contact()
        {
            this.Users = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public string Address_line1 { get; set; }
        public string Address_lin2 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
