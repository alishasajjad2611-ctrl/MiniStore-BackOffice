using App.Core.Models;
using System.Collections.Generic;

namespace App.Core.Contracts
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer? GetById(string id);
        Customer Add(Customer customer);
        Customer Update(Customer customer);
        bool Delete(string id);
        IEnumerable<Customer> Search(string query);
    }
}
