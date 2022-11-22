using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Turtel_App.ServerApp.DomainPrimitives.Person;

namespace Turtel_App.ServerApp.User.Domain
{

    [ComplexType]
    [Owned]
    public partial class Account
    {
        [Required]
        public Phonenumber Phonenumber { get; set; }
        
        [Required]
        Name Name { get; set; }

        [Required]
        DateTime Birthday { get; set; }

        [Required]
        Gender Gender { get; set; }

        public Account()
        {
            Gender = default;
        }

        public Account(Phonenumber phonenumber, Name name, DateTime birthday, Gender gender)
        {
            this.Phonenumber = phonenumber;
            this.Name = name;
            this.Birthday = birthday;
            this.Gender = gender ?? throw new ArgumentNullException(nameof(gender));
        }


        public override bool Equals(object? obj)
        {
            return obj is Account account &&
                   EqualityComparer<Phonenumber>.Default.Equals(Phonenumber, account.Phonenumber) &&
                   EqualityComparer<Name>.Default.Equals(Name, account.Name) &&
                   Birthday == account.Birthday &&
                   EqualityComparer<Gender>.Default.Equals(Gender, account.Gender);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Phonenumber, Name, Birthday, Gender);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
