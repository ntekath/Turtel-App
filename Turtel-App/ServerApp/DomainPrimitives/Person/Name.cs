using System.ComponentModel.DataAnnotations;

namespace Turtel_App.ServerApp.DomainPrimitives.Person
{
    [Serializable]
    public struct Name
    {
        string name;

        public Name()
        {
            name = "";
        }

        public Name(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override bool Equals(object? obj)
        {
            return obj is Name name &&
                   this.name == name.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name);
        }

        public static bool operator ==(Name left, Name right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Name left, Name right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
