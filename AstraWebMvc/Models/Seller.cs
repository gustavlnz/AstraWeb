using AstraWebMvc.Models.ViewModels;

namespace AstraWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Seller()
        {
        }   

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
        }
        public void addSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void removeSales(SalesRecord sr)
        {
            Sales.Remove(sr);

        }
        // Método para calcular o total de vendas em um intervalo de datas
        public double totalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
