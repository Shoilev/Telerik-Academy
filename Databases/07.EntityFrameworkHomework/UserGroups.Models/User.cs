//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserGroups.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserGroups = new HashSet<UserGroup>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<UserGroup> UserGroups { get; set; }
    }
}