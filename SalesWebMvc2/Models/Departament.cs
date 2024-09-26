using System.Collections.Generic;
using System;
using System.Linq;
namespace SalesWebMvc2.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); //Associação do departament com Seller

        //Construtor sem argumentos
        public Departament()
        {

        }

        public Departament(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //somando a venda de todos os vendedores daquele departamento
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
