

var people = new List<People>()
{
    new People(){ Name = "Luis", Age = 32 },
    new People(){ Name = "Ana", Age = 25 },
    new People(){ Name = "Emanuel", Age = 5 },
    new People(){ Name = "Joel", Age = 2 },
    new People(){ Name = "Enrique", Age = 56 },
    new People(){ Name = "Luisa", Age = 30 },
};

var orderedPeople = (from person in people
                     where person.Age <= 18
                    orderby person.Age descending
                    select person).ToList();

var orderedPeople2 = people.Where(p => p.Age < 18).OrderByDescending(p => p.Age).Select(p => p);

foreach (var person in orderedPeople)
{
    Console.WriteLine($"{person.Name} -- {person.Age}");
}


foreach (var person in orderedPeople2)
{
    Console.WriteLine($"{person.Name} -- {person.Age}");
}
class People()
{
    public string ?Name { get; set; }
    public decimal ?Age { get; set; }
}