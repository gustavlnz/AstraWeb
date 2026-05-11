using AstraWebMvc.Controllers;
using AstraWebMvc.Data;
using AstraWebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
           
            return _context.Sellers.Include (s => s.Department).ToList();
        }
        public void Insert(Seller obj)
        {
            
            _context.Add(obj);
            _context.SaveChanges();
        }
        public List<Department> FindAllDepartment()
        {
            return _context.Department.OrderBy(d => d.Id).ToList();
        }

    }
}
