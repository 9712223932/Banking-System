//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transection()
        {
            this.BankServers = new HashSet<BankServer>();
        }
    
        public int TransectionId { get; set; }
        public Nullable<int> TransectionType { get; set; }
        public Nullable<int> TransectionAmmount { get; set; }
        public Nullable<int> TransectionMethod { get; set; }
        public Nullable<int> CustomerAccountManageId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual AccountorTransectionValue AccountorTransectionValue { get; set; }
        public virtual AccountorTransectionValue AccountorTransectionValue1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankServer> BankServers { get; set; }
        public virtual CustomerAccountManage CustomerAccountManage { get; set; }
    }
}
