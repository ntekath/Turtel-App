using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Turtel_App.ServerApp.DomainPrimitives
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
