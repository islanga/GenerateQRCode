using System.ComponentModel.DataAnnotations;

namespace GenerateQRCode.Models
{
    public class GenerateQRCodeModel
    {
        [Display(Name = "Enter QR Code Text")]
        public string QRCodeText { get; set; } = string.Empty;
    }
}
