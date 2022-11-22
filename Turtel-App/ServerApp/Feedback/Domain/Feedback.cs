using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turtel_App.ServerApp.Feedback.Domain
{
    public class Feedback
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }

        [Required]
        public string Info { get; set; }

        [Required]
        DateTime SubmissionDate { get; }

        private Feedback()
        {
        }

        private Feedback(Guid id, string info, DateTime submissionDate)
        {
            Id = id;
            Info = info ?? throw new ArgumentNullException(nameof(info));
            SubmissionDate = submissionDate;
        }
        public override bool Equals(object? obj)
        {
            return obj is Feedback feedback &&
                   Id.Equals(feedback.Id) &&
                   Info == feedback.Info &&
                   SubmissionDate == feedback.SubmissionDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Info, SubmissionDate);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
