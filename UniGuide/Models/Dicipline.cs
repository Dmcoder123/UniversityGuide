//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniGuide.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dicipline
    {
        public Dicipline()
        {
            this.Programs = new HashSet<Program>();
        }
    
        public int DiciID { get; set; }
        public string DiciplineEng { get; set; }
        public string DiciplineArb { get; set; }
        public int CatID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Program> Programs { get; set; }
    }
}
