using LoginService.Model;
namespace LoginService.Login.contract
{
    public interface ILogin
    {
        void CreateMembership(MemberShip mem);
        bool SignIn(string username, string password);
    }
}