using Microsoft.Identity.Client;
using AstraWebMvc.Models.ViewModels;
namespace AstraWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

       

        public void addSeller(Seller seller)
        {
            if (seller == null)
            {
                throw new ArgumentNullException(nameof(seller), "Seller cannot be null.");

            }
            Sellers.Add(seller);
        }
        //Método para somar o total de vendas de um departamento em um intervalo de datas
        /// <summary>
        /// (para cada vendedor, somar o total de vendas e depois somar o total de vendas de cada vendedor)
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.totalSales(initial, final));
        }
    }

}
