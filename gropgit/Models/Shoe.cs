using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace gropgit.Models
{
    public class Shoe
    {
        [Key]
        public int ShoeId { get; set; }

        [Display(Name = "מידה")]
        public int measure { get; set; }

        [Display(Name = "צבע")]
        public string Color { get; set; }

        [Display(Name = "מותג")]
        public string brand { get; set; }

        [Display(Name = "תמונה")]
        public string Image { get; set; }

        //public Shoe(int measure,string Color,string brand, string Image)
        //{
        //    measure = measure;
        //    Color = Color;
        //    brand = brand;
        //    Image = Image;
        //}


    }
}
