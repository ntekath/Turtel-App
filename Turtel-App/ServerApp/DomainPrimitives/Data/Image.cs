using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turtel_App.ServerApp.DomainPrimitives.Data
{
    [ComplexType]
    public class Image
    {

        [Required]
        public string Description { get; set; }

        [Required]
        public byte[] Data { get; }

        [Required]
        public string ImageType { get; }


        public Image(string description, byte[] data, string imageType)
        {
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Data = data ?? throw new ArgumentNullException(nameof(data));
            ImageType = imageType ?? throw new ArgumentNullException(nameof(imageType));
        }

        public Image(byte[] data, string imageType)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));
            ImageType = imageType ?? throw new ArgumentNullException(nameof(imageType));
            Description = "";
        }

        private Image()
        {
            Description = "";
            Data = Array.Empty<byte>();
            ImageType = "";
        }
    }
}
