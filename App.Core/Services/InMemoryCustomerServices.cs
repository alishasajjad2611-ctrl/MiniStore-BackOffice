using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Core.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        private readonly List<Customer> _customers = new();

        public IEnumerable<Customer> GetAll() => _customers.ToList();

        public Customer? GetById(string id) =>
            _customers.FirstOrDefault(c => c.Id == id);

        public Customer Add(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);
            _customers.Add(customer);
            return customer;
        }

        public Customer Update(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);
            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existing == null)
                throw new InvalidOperationException($"Customer with ID '{customer.Id}' not found.");

            existing.Name = customer.Name;
            existing.Phone = customer.Phone;
            existing.Email = customer.Email;
            existing.Address = customer.Address;
            return existing;
        }

        public bool Delete(string id) =>
            _customers.RemoveAll(c => c.Id == id) > 0;

        public IEnumerable<Customer> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return GetAll();

            return _customers
                .Where(c => c.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
