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
    
    public partial class Satrudniki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satrudniki()
        {
            this.Chek = new HashSet<Chek>();
        }
    
        public int id { get; set; }
        public string Nickname { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Parol { get; set; }
        public int IDroli { get; set; }
        public string LoginSat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chek> Chek { get; set; }
        public virtual Rolu Rolu { get; set; }
    }
}
