using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Rental_Management_System.Interfaces;

namespace Vehicle_Rental_Management_System.factories
{
    public abstract class PersonCreator
    {

        public abstract IPerson createPerson();

        public  IPerson OrderPerson(string id,string FirstName,string LastName,string Nationality,string PhoneNumber)
        {
            IPerson person=  this.createPerson();
            person.Id = id;
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Nationality = Nationality;
            person.PhoneNumber = PhoneNumber;

            return person;
        }
    }
}
