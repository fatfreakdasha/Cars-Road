//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cars_Road
{
    using System;
    using System.Collections.Generic;
    
    public partial class Дороги
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Дороги()
        {
            this.СервисныеПункты = new HashSet<СервисныеПункты>();
        }
    
        public int НомерДороги { get; set; }
        public Nullable<decimal> Протяженность { get; set; }
        public string ЕдиницаИзмерения { get; set; }
        public string Категория { get; set; }
        public string ВидПокрытия { get; set; }
        public Nullable<int> ОграничениеСкорости { get; set; }
        public Nullable<int> СоединенныйГородИдентификатор { get; set; }
        public string НаличиеАвторемонтныхПунктов { get; set; }
        public string НаличиеАвтозаправочныхСтанций { get; set; }
    
        public virtual Города Города { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<СервисныеПункты> СервисныеПункты { get; set; }
    }
}
