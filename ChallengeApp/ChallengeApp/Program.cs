string name = "Ewa";
string sex = "female";
var age = 33;


if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (sex!= "female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
