using LoginService.Login.contract;
using LoginService.Model;
using LoginService.Domain.Context;
using System.Linq;
namespace LoginService.Login.Service
{
    public class LoginS : ILogin
    {
        ApplicationDbContext _context;
        public LoginS(ApplicationDbContext con)
        {
            _context = con; 
        }
        void ILogin.CreateMembership(MemberShip mem)
        {
            _context.Add(mem);
            _context.SaveChanges();
        }

        bool ILogin.SignIn(string username, string password)
        {
            var temp =_context.User.Where(s=>s.username == username && 
            s.password == password).FirstOrDefault();
            if(temp == null)
                return false;
            else
                return true;
        }
    }
}