using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turtel_App.ServerApp.DomainPrimitives.Person
{
    [ComplexType]
    public class Gender
    {
        [Required]
        readonly string representation;

        public Gender(string representation)
        {
            this.representation = representation;
        }
    }
}
