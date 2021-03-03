using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace brane.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; } //trigrame
    }
}