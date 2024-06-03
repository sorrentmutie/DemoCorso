using DemoCorso.Core;
using DemoCorso.Core.Interfaces;

namespace DemoCorso.Data;

public class ManagePeopleOnSqlServer : IPeopleData
{
    public void AddPerson(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person>? GetPeople()
    {
        return null;
    }

    public Person? GetPersonById(int id)
    {
        throw new NotImplementedException();
    }

    public string GetSalute()
    {
        throw new NotImplementedException();
    }

    public void RemovePerson(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdatePerson(Person person)
    {
        throw new NotImplementedException();
    }
}
