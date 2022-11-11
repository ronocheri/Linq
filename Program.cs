//print all persons' names contain 'a' - Query + Method syntax
List<string> persons = new List<string>();
persons.Add("Ron");
persons.Add("Sean");
persons.Add("Mor");
persons.Add("Barak");
persons.Add("Maor");

// Query Syntax
var res =from person in persons
        where person.Contains('a')
        select person;

// Method Syntax
var result = persons.Where(s => s.Contains('a'));

Console.WriteLine("Query Syntax results:");
foreach (var str in res)
	Console.WriteLine(str);

Console.WriteLine("Method Syntax results:");
foreach (var str in result)
    Console.WriteLine(str);

Console.ReadLine();