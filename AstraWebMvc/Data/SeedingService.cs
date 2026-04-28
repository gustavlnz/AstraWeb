using AstraWebMvc.Models;
using AstraWebMvc.Models.Enums;
using AstraWebMvc.Models.ViewModels;

namespace AstraWebMvc.Data
{
    public class SeedingService
    {
        private AstraWebMvcContext _context;
        public SeedingService(AstraWebMvcContext context)
        {
            _context = context;
        }   
        public void Seed()
        {
            // Verifica se o banco já tem dados
            if (_context.Department.Any() ||
                _context.Sellers.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            // Criando departamentos
            Department d1 = new Department { Name = "Computers" };
            Department d2 = new Department { Name = "Electronics" };
            Department d3 = new Department { Name = "Fashion" };
            Department d4 = new Department { Name = "Books" };

            // Criando vendedores
            Seller s1 = new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, department = d1 };
            Seller s2 = new Seller { Name = "Maria Green", Email = "maria@gmail.com", BirthDate = new DateTime(1979, 12, 31), BaseSalary = 3500.0, department = d2 };
            Seller s3 = new Seller { Name = "Alex Grey", Email = "alex@gmail.com", BirthDate = new DateTime(1988, 1, 15), BaseSalary = 2200.0, department = d1 };
            Seller s4 = new Seller { Name = "Martha Red", Email = "martha@gmail.com", BirthDate = new DateTime(1993, 11, 30), BaseSalary = 3000.0, department = d4 };

            // Criando registros de vendas
            SalesRecord r1 = new SalesRecord { Date = new DateTime(2024, 1, 10), Amount = 11000.0, Status = Models.Enums.SaleStatus.Billed, Seller = s1 };
            SalesRecord r2 = new SalesRecord { Date = new DateTime(2024, 2, 15), Amount = 15000.0, Status = Models.Enums.SaleStatus.Pending, Seller = s2 };
            SalesRecord r3 = new SalesRecord { Date = new DateTime(2024, 3, 20), Amount = 8000.0, Status = Models.Enums.SaleStatus.Canceled, Seller = s3 };
            SalesRecord r4 = new SalesRecord { Date = new DateTime(2024, 4, 25), Amount = 20000.0, Status = Models.Enums.SaleStatus.Billed, Seller = s4 };

            // Add to the database - CADA ENTIDADE NA SUA TABELA CORRETA
            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Sellers.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4);
            _context.SaveChanges();
        }
    }
}
