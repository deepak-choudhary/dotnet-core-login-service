using System.ComponentModel.DataAnnotations;

namespace LoginService.Model
{
    public class MemberShip
    {
      [Key]  
      public string username{get;set;}
      public string password{get;set;}

      public int Age{get;set;}        
    }
}
