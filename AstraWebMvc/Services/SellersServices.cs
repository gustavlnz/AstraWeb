using AstraWebMvc.Data;
using AstraWebMvc.Models;

namespace AstraWebMvc.Services
{
    public class SellersServices
    {
        private readonly AstraWebMvcContext _context;

        public SellersServices(AstraWebMvcContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }

    }
}
