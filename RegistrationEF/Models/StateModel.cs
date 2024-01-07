using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationEF.Models
{
    [Table("tblState")]
    public class StateModel
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
        [ForeignKey("CountryId")]
        public int FKCountryId { get; set; }

        public CountryModel CountryId { get; set; }
    }
}
