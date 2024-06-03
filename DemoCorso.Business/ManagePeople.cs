using DemoCorso.Core;
using DemoCorso.Core.Interfaces;

namespace DemoCorso.Business;

public class ManagePeople : IPeopleData
{
    private readonly ISalute? salute;

    private List<Person>? people { get; set; }

    public ManagePeople(ISalute salute)
    {
        this.salute = salute;
        people = new List<Person>();
        people.Add(
            new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            });
    }

    public List<Person>? GetPeople()
    {
        return people;
    }

    public void AddPerson(Person person)
    {
        people?.Add(person);
    } 

    public Person? GetPersonById(int id)
    {
        return people?.FirstOrDefault(p => p.Id == id);
    }

    public void RemovePerson(int id)
    {
        var person = GetPersonById(id);
        if (person is not null)
        {
            people?.Remove(person);
        }
    }

    public void UpdatePerson(Person person) { 
       var existingPerson = GetPersonById(person.Id);
        if (existingPerson is not null)
        {
            RemovePerson(person.Id);
            AddPerson(person);
        }
    }

    public string GetSalute()
    {
        return salute.GetSalute();
    }
}
