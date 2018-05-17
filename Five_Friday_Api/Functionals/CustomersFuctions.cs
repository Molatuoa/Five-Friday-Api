using Five_Friday_Api.DBSettings;
using Five_Friday_Api.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Five_Friday_Api.Functionals
{
    public class CustomersFuctions
    {
        private readonly Database _database;
        private const string _connectionSringName = "MainDBSet";
        public CustomersFuctions()
        {
            _database = new DbSettings().GetDatabase(_connectionSringName);
        }
        public List<Customer> GetCustomerList(string sSearch)
        {
            string sql = $"select * from Customer";
            string _where = (string.IsNullOrEmpty(sSearch) ? "" : $" where Name like '%{sSearch}%'");
            return _database.Fetch<Customer>(sql + _where);
        }
        public int _addNewCustomer(Customer objCustomer)
        {
            _database.Save(objCustomer);
            return objCustomer.id;
        }
        public void _addNewContact(CustomerContact objContact)
        {
            _database.Save(objContact);
        }
        public List<CustomerContact> getCustomerContact(int id)
        {
            return _database.Fetch<CustomerContact>($"select * from CustomerContact where CustomerID =@0", id);
        }
    }
}