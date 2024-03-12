using ClassLibrary1.Services;

namespace ClassLibrary1.Interfaces
{
    public interface IAccount
    {
        string Email { get; set; }
        string Password { get; set; }
        UserRole Role { get; set; }
        public bool CheckLogin();
    }
}