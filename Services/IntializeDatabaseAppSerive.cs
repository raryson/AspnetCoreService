using System.Collections.Generic;
using System.Linq;
using AspnetCoreService.Entities;
using AspnetCoreService.Infra;

namespace AspnetCoreService.Services
{

    public class InitializeDatabaseAppService
    {
        private readonly UserContext _context;
        public InitializeDatabaseAppService(UserContext context){
            _context = context;
        }

        public void Initialize()
        {
            if(VerifyIfHaveUsersCreatedOnDatabase(_context))
                return;

            var UserList = new List<User>()
            {
               new User("Raryson", "123", "raryson.rost@gmail.com"),
               new User("Pedro", "456", "pedro@umbler.com") 
            };

            foreach(var user in UserList)
            {
                _context.Users.Add(user);
            }

            _context.SaveChanges();
            
        }

        private bool VerifyIfHaveUsersCreatedOnDatabase(UserContext _context)
        {
            return _context.Users.Any();
        }
    }
}