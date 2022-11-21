using System.ComponentModel.DataAnnotations.Schema;

namespace Turtel_App.ServerApp.User.Domain
{
    [ComplexType]
    public class Gallery
    {
        byte[]? ProfileImage { get; set; }
        ICollection<byte[]> ImageGallery { get; set; }

        public Gallery()
        {
            ImageGallery = new List<byte[]>();
        }

        public Gallery(byte[]? profileImage, List<byte[]> gallery)
        {
            this.ProfileImage = profileImage;
            this.ImageGallery = gallery;
        }

        public override bool Equals(object? obj)
        {
            return obj is Gallery gallery &&
                   EqualityComparer<byte[]?>.Default.Equals(ProfileImage, gallery.ProfileImage) &&
                   EqualityComparer<ICollection<byte[]>>.Default.Equals(ImageGallery, gallery.ImageGallery);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProfileImage, ImageGallery);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
