//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circus
{
    using System;
    using System.Collections.Generic;
    
    public partial class SheduleArtist
    {
        public int IDSheduleArtist { get; set; }
        public Nullable<int> IDPerfomance { get; set; }
        public Nullable<int> IDArtist { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Perfomance Perfomance { get; set; }
    }
}
