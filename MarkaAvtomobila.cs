//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRR5AVTOsalon
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarkaAvtomobila
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarkaAvtomobila()
        {
            this.ModeliAvtomobila = new HashSet<ModeliAvtomobila>();
        }
    
        public int id { get; set; }
        public string NazvaniyeMarki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModeliAvtomobila> ModeliAvtomobila { get; set; }
    }
}
