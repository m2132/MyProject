using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories
{
   public enum EPolicy
    {
        Allow=1,
        Deny=2,
        
    }
    public class Claim
    {
        public int Id { get; set; }
        public Role Role { get; set; }
        public Permission Permission {get; set;}
        public EPolicy Policy { get; set; }
        public override string ToString()
        {
            return $"Claim: id:{Id}, roleId:{Role.Id}, permissionId:{Permission.Id}, policy:{Policy}";
        }
    }

    
}
