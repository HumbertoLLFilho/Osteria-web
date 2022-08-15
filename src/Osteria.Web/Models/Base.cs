using Osteria.Web.Presentation.Interfaces;

namespace Osteria.Web.Models
{
    public class Base : ICreateble, IModifiable
    {
        private Guid? _id;

        public Guid ID { get => _id ?? Guid.NewGuid(); init => _id = value; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;
        public DateTime Modified { get; set; }
    }
}