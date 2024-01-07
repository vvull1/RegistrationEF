using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationEF.Models
{
    [Table("tblCity")]
    public class CityModel
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        [ForeignKey("StateId")]
        public int FKStateId { get; set; }

        public StateModel StateId { get; set; }
    }
}
