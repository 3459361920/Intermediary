//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace intermediary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tenancy
    {
        public int ID { get; set; }
        public Nullable<int> aID { get; set; }
        public Nullable<int> rgstID { get; set; }
    
        public virtual Addhouse Addhouse { get; set; }
        public virtual register register { get; set; }
    }
}
