//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LockServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.PROD_CUST = new HashSet<PROD_CUST>();
        }
    
        public string CST_CODE { get; set; }
        public string USER_ID { get; set; }
        public string CST_KIND { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public string CELL_PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string TEL_NO_1 { get; set; }
        public string E_MAIL { get; set; }
        public string RESP_NAME { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string DESC1 { get; set; }
        public string WEBSITE { get; set; }
        public string LOGO { get; set; }
        public string LOGO_FLAG { get; set; }
        public Nullable<decimal> preorder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROD_CUST> PROD_CUST { get; set; }
    }
}
