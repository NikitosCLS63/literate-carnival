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
    
    public partial class ServiseRecords
    {
        public int id { get; set; }
        public Nullable<int> idAvtomobilya { get; set; }
        public string Dataobslujivaniya { get; set; }
        public string Opisaniyerabot { get; set; }
    
        public virtual Avtomobili Avtomobili { get; set; }
       
    }
}
