//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAAA.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.ItemList = new HashSet<ItemList>();
        }
    
        public int ID { get; set; }
        public int Status { get; set; }
        public int Client { get; set; }
        public int Location { get; set; }
        public Nullable<int> Sale { get; set; }
        public int Price { get; set; }
        public string Date { get; set; }
        public int Code { get; set; }
    
        public virtual Datas Datas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemList> ItemList { get; set; }
        public virtual Points Points { get; set; }
        public virtual Status Status1 { get; set; }
    }
}
