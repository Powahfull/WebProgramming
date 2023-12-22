
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lighthouse.Models
{
    public class Events
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        [NotMapped] // Exclude this property from the database schema
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".png", ".jpg", ".jpeg" })]
        public IFormFile? AttachmentFile { get; set; }

        public byte[]? AttachmentData { get; set; }
        public string? AttachmentFileName { get; set; }
        public string? AttachmentContentType { get; set; }
        public bool IncludeEmail { get; set; }
        public bool IncludeWebsite { get; set; }
        public bool IsPaid { get; set; }
        public bool IsFree { get; set; }

        // Amount for paid events
        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        public decimal? Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Location { get; set; }

    }
}
