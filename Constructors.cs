//Constructors ---> Constructor is a very special method to intialize the objects.

class Person
{
    public string? Name;
    public string? Designation;

    //Constructor with parameters
    public Person(string? name, string? designation)
    {
        Name = name;
        Designation = designation;
    }

    //Default Constructor

    public Person() {
        Name = "Shivendra";
        Designation = "Software Engineer 1";
    }
}