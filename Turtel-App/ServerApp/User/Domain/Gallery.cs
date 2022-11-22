using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Turtel_App.ServerApp.DomainPrimitives.Data;

namespace Turtel_App.ServerApp.User.Domain
{
    [ComplexType]
    [Owned]
    public class Gallery
    {
        Image? ProfileImage { get; set; }

        [Required]
        ICollection<Image> ImageGallery { get; set; }

        public Gallery()
        {
            ProfileImage = null;
            ImageGallery = new List<Image>();
        }

        public Gallery(Image? profileImage, ICollection<Image> imageGallery)
        {
            ProfileImage = profileImage;
            ImageGallery = imageGallery ?? throw new ArgumentNullException(nameof(imageGallery));
        }

        public Gallery(ICollection<Image> imageGallery)
        {
            ImageGallery = imageGallery ?? throw new ArgumentNullException(nameof(imageGallery));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddImage(Image image)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Deleteimage(Image image)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool SetProfileImage(Image image)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            return obj is Gallery gallery &&
                   EqualityComparer<Image?>.Default.Equals(ProfileImage, gallery.ProfileImage) &&
                   EqualityComparer<ICollection<Image>>.Default.Equals(ImageGallery, gallery.ImageGallery);
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
