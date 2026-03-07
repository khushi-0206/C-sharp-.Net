using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
namespace Assessment_7_March.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        public string Author { get; set; }
        public decimal Price { get; set; }
        
    }
}
