//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public user()
        {
            this.administrations = new HashSet<administration>();
            this.buyers = new HashSet<buyer>();
            this.posts = new HashSet<post>();
            this.requests = new HashSet<request>();
            this.sellers = new HashSet<seller>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<administration> administrations { get; set; }
        public virtual ICollection<buyer> buyers { get; set; }
        public virtual ICollection<post> posts { get; set; }
        public virtual ICollection<request> requests { get; set; }
        public virtual ICollection<seller> sellers { get; set; }
    }
}
