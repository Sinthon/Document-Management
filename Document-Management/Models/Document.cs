using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Document_Management.Models
{
    public class Document
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Title is required field")]
        public string Title { get; set; }
        public string Extention { get; set; }
        public string FileSize { get; set; }
        [Required(ErrorMessage = "Please select a file befor upload")]
        public string FilePath { get; set; }
    }
}
