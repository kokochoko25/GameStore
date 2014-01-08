using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HartleyAndMarks.Models
{
    public class Product
    {
        [Key]
        public int Id{ get; set; }

        [Display(Name="poi")]
        public String Name { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name="Desciption")]
        public String Description { get; set; }

        [Display(Name="Genre")]
        public String Genre { get; set; }

        [Display(Name = "Publisher")]
        public String Publisher { get; set; }

        [Display(Name = "Box Shot")]
        public String BoxShot { get; set; }

        /// <summary>
        /// Returns true if the product was released less than three months ago.
        /// </summary>
        /// <returns>True if the product is newly released within the last three months. False otherwise.</returns>
        public bool IsNew() { 
            return DateTime.Compare(ReleaseDate, DateTime.Today.AddMonths(-3)) >= 0
                && DateTime.Compare(ReleaseDate, DateTime.Today) <= 0;
        }
        
        /// <summary>
        /// Returns true if the product is not yet released.
        /// </summary>
        /// <returns>True if the product is not yet released. False otherwise.</returns>
        public bool IsNotReleased()
        {
            return DateTime.Compare(ReleaseDate, DateTime.Today) > 0;
        }
    }

}
