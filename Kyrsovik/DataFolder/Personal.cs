//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kyrsovik.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personal
    {
        public int Idpersonal { get; set; }
        public string PersonaleName { get; set; }
        public string PhoneNumber { get; set; }
        public int IdOrder { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
