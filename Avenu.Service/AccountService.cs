//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Avenue.InfraStructure;
//using Avenue.Service.Contract;
//using Avenue.ViewModels;
//using Microsoft.AspNet.Identity.EntityFramework;

//namespace Avenue.Service
//{
//  public  class AccountService: IAccountService
//  {

//      private readonly AvenueDbContext _context;

//      public AccountService(AvenueDbContext context)
//      {
//          _context = context;
//      }
//      public ApplicationUser Create(ApplicationUser user)
//      {
//          var users =_context.Users.Add(user);
//          _context.SaveChanges();
//          return user;
//      }

//      public void Edit(ApplicationUser user)
//      {
//         _context.Entry(user).State = EntityState.Modified;
//          _context.SaveChanges();
//      }

//      public void CrateRole(IdentityRole roleName)
//      {
//          _context.Roles.Add(roleName);
//          _context.SaveChanges();
//      }

//      public void Edit(IdentityRole roleName)
//      {
//            _context.Entry(roleName).State = EntityState.Modified;
//            _context.SaveChanges();
//        }

//        public void Delete(Guid id)
//      {
//          throw new NotImplementedException();  
//      }
//    }
//}
