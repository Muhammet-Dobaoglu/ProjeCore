using System.ComponentModel.DataAnnotations;

namespace ProjeCore.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAD { get; set; }

        public IList<Personel> Personels { get; set; }
    }
}
