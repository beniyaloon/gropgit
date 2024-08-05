using System.ComponentModel.DataAnnotations;

namespace gropgit.Models
{
    public class Hat
    {

        [Key]
        public int HatId { get; set; }

        [Display(Name = "מידה")]
        public int Hatmeasure { get; set; }

        [Display(Name = "צבע")]
        public string HatColor { get; set; }

        [Display(Name = "מותג")]
        public string Hatbrand { get; set; }

        [Display(Name = "תמונה")]
        public string HatImage { get; set; }
    }
}
