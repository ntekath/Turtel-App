using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turtel_App.ServerApp.User.Domain
{
    [ComplexType]
    [Owned]
    public class Presentation
    {
        string? Text { get; set; }
        byte[]? Audio { get; set; }
        byte[]? Video { get; set; }

        public Presentation()
        {
        }

        public Presentation(string? text, byte[]? audio, byte[]? video)
        {
            this.Text = text;
            this.Audio = audio;
            this.Video = video;
        }

        public override bool Equals(object? obj)
        {
            return obj is Presentation presentation &&
                   Text == presentation.Text &&
                   EqualityComparer<byte[]?>.Default.Equals(Audio, presentation.Audio) &&
                   EqualityComparer<byte[]?>.Default.Equals(Video, presentation.Video);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, Audio, Video);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
