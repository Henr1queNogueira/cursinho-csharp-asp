using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc2.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string  Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }

        public Departament Deparment { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>(); //lista de vendas associada ao vendedor

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Departament deparment)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Deparment = deparment;
        }

        //Adicionar uma venda na lista de vendas (sales)
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        //Removendo uma venda
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime Initial, DateTime final)
        {
            //Filtrando as vendas baseado na data inicial e final e depois calcula a soma das vendas
            return Sales.Where(sr => sr.Date >= Initial && sr.Date <= final).Sum(sr => sr.Amount);

        }
    }
}
