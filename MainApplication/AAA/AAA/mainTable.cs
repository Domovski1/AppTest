//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAA
{
    using System;
    using System.Collections.Generic;
    
    public partial class mainTable
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int GroupID { get; set; }
        public int Size { get; set; }
        public byte[] icon { get; set; }
    
        public virtual Group Group { get; set; }
    }
}
