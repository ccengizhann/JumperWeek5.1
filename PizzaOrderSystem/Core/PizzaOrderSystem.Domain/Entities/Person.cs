using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderSystem.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public Person( string firstName, string lastName, long cardNumber)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            CreatedOn = DateTime.Now;
        }

    }
}
