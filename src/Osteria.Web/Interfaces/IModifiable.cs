namespace Osteria.Web.Presentation.Interfaces
{
    public interface IModifiable
    {
        public bool Deleted { get; set; }
        public DateTime Modified { get; set; }
    }
}
