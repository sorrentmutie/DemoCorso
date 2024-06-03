namespace DemoCorso.Core.Interfaces;

public interface IPeopleData
{
    List<Person>? GetPeople();
    Person? GetPersonById(int id);
    void AddPerson(Person person);
    void RemovePerson(int id);
    void UpdatePerson(Person person);
    string GetSalute();
}
