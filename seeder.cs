using System.Linq;
using brane.Models;

namespace brane
{
    public class seeder
    {
        private readonly MyDbContext _context;
        
        public seeder(MyDbContext context)
        {
            _context = context;
        }

        public void populate_One()
        {
            //make users
            this.populate_Users();
            this.populate_Projects();
        }

        private void populate_Users()
        {
            _context.Users.Add(new User() {Name = "HMO"});
            _context.Users.Add(new User() {Name = "OPE"});
            _context.Users.Add(new User() {Name = "JEE"});
            _context.Users.Add(new User() {Name = "KEP"});
            _context.SaveChanges();
        }

        private void populate_Projects()
        {
            var userOne = _context.Users.Where(user => user.Name == "HMO");
            if (userOne.Any())
            {
                _context.ProjectItems.Add(new ProjectItem(){Name = "C++",AssigneeId = userOne.AsEnumerable().First().Id});
            }
            
            var userTwo = _context.Users.Where(user => user.Name == "OPE");
            if (userTwo.Any())
            {
                _context.ProjectItems.Add(new ProjectItem(){Name = "Car",AssigneeId = userTwo.AsEnumerable().First().Id});
            }
            
            var userThree = _context.Users.Where(user => user.Name == "JEE");
            if (userThree.Any())
            {
                _context.ProjectItems.Add(new ProjectItem(){Name = "Lora",AssigneeId = userThree.AsEnumerable().First().Id});
            }
            
            var userFour = _context.Users.Where(user => user.Name == "KEP");
            if (userFour.Any())
            {
                _context.ProjectItems.Add(new ProjectItem(){Name = "Radio",AssigneeId = userFour.AsEnumerable().First().Id});
            }

            _context.SaveChanges();
        }
    }
}