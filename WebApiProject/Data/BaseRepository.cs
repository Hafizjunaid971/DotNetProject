using System.Collections.Generic;
using System.Linq;
using WebApiProject.Models;

namespace WebApiProject.Data
{
    public class BaseRepository : IBaseRepository<Customer>
    {
       private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer Get(long id)
        {
            return _context.Customers
                  .FirstOrDefault(e => e.ID == id);
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
            _context.SaveChanges();
        }
     
    }
}
