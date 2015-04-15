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
    using System.ComponentModel.DataAnnotations;
    
    public partial class City
    {
        public City()
        {
            this.Faculties = new HashSet<Faculty>();
            this.Universities = new HashSet<University>();
        }

        public int CountryID { get; set; }
        public int CityID { get; set; }

        [Display(Name = "CityEng", ResourceType = typeof(Resources.Resources))]
        public string CityEng { get; set; }
        //[Display(Name = "CityArb", ResourceType = typeof(Resources.Resources))]
        public string CityArb { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<University> Universities { get; set; }
    }
}