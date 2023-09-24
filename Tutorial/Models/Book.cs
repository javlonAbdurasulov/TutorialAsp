using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId{ get; set; }
        public string Name{ get; set; }

    }
}
