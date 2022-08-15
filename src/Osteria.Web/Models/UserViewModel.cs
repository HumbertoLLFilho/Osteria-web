namespace Osteria.Web.Models
{
    public class UserViewModel : Base
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //public List<PhoneViewModel> PhoneViewModel { get; set; } = new();
    }
}