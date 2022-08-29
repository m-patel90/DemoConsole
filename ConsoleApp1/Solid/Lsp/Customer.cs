using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Solid.Lsp
{
    public class Customer: IRepository
    {
        public int BaseDiscount = 10;
        public virtual int Discount(int sales)
        {
            return sales;
        }

        //public void Discount()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class Database : IDatabase
    {
        public void Add() { }

        public void AddExistingCustomer() { }

        public void AnotherExtension() { }
    }

    public interface IDatabase
    {
        void Add();
    }
}
