using SalesWebMvc2.Models.Enums;
using System.Collections.Generic;
using System;

namespace SalesWebMvc2.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }

        public Seller Seller { get; set; } //venda possui um vendedor
       
        //Construtor sem argumento
        public SalesRecord()
        {

        }

        //Construtor com argumentos (parâmetros)
        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
