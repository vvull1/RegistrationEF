using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationEF.Models
{
    [Table("tblCountry")]
    public class CountryModel
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
