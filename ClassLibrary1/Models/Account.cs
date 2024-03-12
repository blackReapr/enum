using ClassLibrary1.Interfaces;
using System.Security.Principal;

namespace ClassLibrary1.Services
{
    public class Account : IAccount
    {
        public UserRole Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool CheckLogin()
    {
        if (Role != UserRole.SuperAdmin)
        {
            Console.WriteLine("Girish ucun icazeniz yoxdur");
            return false;
        }
        if (Password != "test12345" || Email != "test@code.edu.az")
        {
            Console.WriteLine("Email ve ya password sehvdir");
            return false;
        }
        Console.WriteLine("Girish ugurludur");
        return true;
    }
    }
    public enum UserRole
    {
        SuperAdmin,
        Admin,
        Member
    }
}

