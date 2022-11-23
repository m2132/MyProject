using MyProject.Mock;
using MyProject.Repositories;
using System;


namespace MyProject.ConsoleApp
{
    class Program

    {
        static void Main(string[] args)
        {
        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
        //    Role r = new Role() { Id = 1, Name = "admin", Description = "administractor" };
        //    Console.WriteLine($" role: {r.Id} , {r.Name} , {r.Description}");

        //    Permission p = new Permission() { Description = "admin", Id = 2, Name = "Yosi" };
        //    Console.WriteLine($" Permission: {p.Id} , {p.Name} , {p.Description}");

        //    Claim c = new Claim()
        //    { Id = 3, PermissionId = 2, Policy = Repositories.EPolicy.Allow, RoleId = 1 };
        //    Console.WriteLine($" Claim: {c.Id} , {c.PermissionId} , {c.Policy} , {c.RoleId}");
        //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //    Console.WriteLine("-----------------------------");
        //    char obj = '0';
        //    var m = new MockContext();
        //    var role = new RoleRepository(m);
        //    var permission = new PermissionRepository(m);
        //    var claim = new ClaimRepository(m);
        //    do
        //    {
        //        Console.WriteLine("enter object \n for Role enter r \n " +
        //            "for Permission enter p \n for Claim enter c  \n for exit enter e");
        //        obj = char.Parse(Console.ReadLine());
        //        if (obj == 'e')
        //            break;
        //        Console.WriteLine("enter what do you want to do \n for Add - 1 \n for delete - 2 \n " +
        //            "for update - 3 \n for get by id - 4 \n for get all - 5");
        //        int action = int.Parse(Console.ReadLine());
        //        switch (obj)
        //        {
        //            case 'r':
        //                switch (action)
        //                {
        //                    case 1:
        //                        Console.WriteLine("enter id , name and description");
        //                        role.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
        //                        break;
        //                    case 2:
        //                        Console.WriteLine("enter id");
        //                        role.Delete(int.Parse(Console.ReadLine()));
        //                        break;
        //                    case 3:
        //                        Console.WriteLine("enter role id for update");
        //                        var updateRole = role.GetById(int.Parse(Console.ReadLine()));
        //                        Console.WriteLine("for update name enter new name for not enter no");
        //                        string newName = Console.ReadLine();
        //                        if (newName != "no")
        //                            updateRole.Name = newName;
        //                        Console.WriteLine("for update description enter new name for not enter no");
        //                        string newDescription = Console.ReadLine();
        //                        if (newDescription != "no")
        //                            updateRole.Description = newDescription;
        //                        role.Update(updateRole);
        //                        break;
        //                    case 4:
        //                        Console.WriteLine("enter id");
        //                        role.GetById(int.Parse(Console.ReadLine()));
        //                        break;
        //                    case 5:
        //                        role.GetAll();
        //                        break;
        //                }
        //                break;
        //            case 'p':
        //                switch (action)
        //                {
        //                    case 1:
        //                        Console.WriteLine("enter id , name and description");
        //                        permission.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
        //                        break;
        //                    case 2:
        //                        Console.WriteLine("enter id");
        //                        permission.Delete(int.Parse(Console.ReadLine()));
        //                        break;
        //                    case 3:
        //                        Console.WriteLine("enter permission id for update");
        //                        var updatePermission = permission.GetById(int.Parse(Console.ReadLine()));
        //                        Console.WriteLine("for update name enter new name for not enter no");
        //                        string newName = Console.ReadLine();
        //                        if (newName != "no")
        //                            updatePermission.Name = newName;
        //                        Console.WriteLine("for update description enter new name for not enter no");
        //                        string newDescription = Console.ReadLine();
        //                        if (newDescription != "no")
        //                            updatePermission.Description = newDescription;
        //                        permission.Update(updatePermission);
        //                        break;
        //                    case 4:
        //                        Console.WriteLine("enter id");
        //                        permission.GetById(int.Parse(Console.ReadLine()));
        //                        break;
        //                    case 5:
        //                        permission.GetAll();
        //                        break;
        //                }
        //                break;
        //            case 'c':
        //                switch (action)
        //                {
        //                    case 1:
        //                        Console.WriteLine("enter id , role id ,permission id and policy");
        //                        claim.Add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), EPolicy.Allow);//stam
        //                        break;
        //                    case 2:
        //                        Console.WriteLine("enter id");
        //                        claim.Delete(int.Parse(Console.ReadLine()));
        //                        break;
        //                    case 3:
        //                        Console.WriteLine("enter claim id for update");
        //                        var updateClaim = claim.GetById(int.Parse(Console.ReadLine()));
        //                        Console.WriteLine("for update rolrId enter new name for not enter -1");
        //                        int newRolrId = int.Parse(Console.ReadLine());
        //                        if (newRolrId != -1)
        //                            updateClaim.RoleId = newRolrId;
        //                        Console.WriteLine("for update permissionId enter new name for not enter -1");
        //                        int newPermission = int.Parse(Console.ReadLine());
        //                        if (newPermission != -1)
        //                            updateClaim.PermissionId = newPermission;
        //                        Console.WriteLine("for update policy enter new policy for not enter no");
        //                        string policy = Console.ReadLine();
        //                        if (policy != "no")
        //                            switch (policy)
        //                            {
        //                                case "allow":
        //                                    updateClaim.Policy = EPolicy.Allow;
        //                                    break;
        //                                case "deny":
        //                                    updateClaim.Policy = EPolicy.Deny;
        //                                    break;
        //                            };
        //                        claim.Update(updateClaim);
        //                        break;
        //                    case 4:
        //                        Console.WriteLine("enter id");
        //                        claim.GetById(int.Parse(Console.ReadLine()));
        //                        break;
        //                    case 5:
        //                        claim.GetAll();
        //                        break;
        //                }
        //                break;
        //        }
        //    }
        //    while (obj != 'e');
        //    Console.ForegroundColor = ConsoleColor.DarkBlue;
        //    Console.WriteLine("-----------------------------");
        //    for (int i = 0; i < m.Roles.Count; i++)
        //    {
        //        Console.WriteLine(m.Roles[i]);
        //    }
        //    Console.WriteLine("\n------------------------------\n");
        //    for (int i = 0; i < m.Permissions.Count; i++)
        //    {
        //        Console.WriteLine(m.Permissions[i]);
        //    }
        //    Console.WriteLine("\n------------------------------\n");

        //    for (int i = 0; i < m.Claims.Count; i++)
        //    {
        //        Console.WriteLine(m.Claims[i]);
        //    }

        //    Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
