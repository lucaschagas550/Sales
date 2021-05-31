using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); // garantir que ele seja instanciada, 1 departamento para muitos vendedor, 1 para N

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller Seller)
        {
            Sellers.Add(Seller);
        }

        //total de vendas por departamento
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final)); //TotalSales do vendedor
        }
    }
}
