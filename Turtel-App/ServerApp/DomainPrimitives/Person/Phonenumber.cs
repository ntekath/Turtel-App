using System.ComponentModel.DataAnnotations;

namespace Turtel_App.ServerApp.DomainPrimitives.Person
{
    [Serializable]
    public struct Phonenumber
    {
        string number;

        public Phonenumber()
        {
            number = "";
        }

        public Phonenumber(string number)
        {
            this.number = number ?? throw new ArgumentNullException(nameof(number));
        }

        public override bool Equals(object? obj)
        {
            return obj is Phonenumber phonenumber &&
                   number == phonenumber.number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(number);
        }

        public static bool operator ==(Phonenumber left, Phonenumber right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Phonenumber left, Phonenumber right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return number;
        }
    }
}
