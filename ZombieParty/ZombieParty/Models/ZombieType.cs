using System.ComponentModel.DataAnnotations;
namespace ZombieParty.Models

{
    public class ZombieType
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Type Name has to be filled.")]
        public string TypeName { get; set; }
    }
}
