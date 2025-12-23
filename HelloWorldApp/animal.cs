namespace HelloWorldApp;
interface Animal
{
    void bark();
}
class Cow: Animal
{
    public void bark()
    {
        Console.WriteLine("Cow barks moooh mooh");
    }
}
class Crow : Animal
{
    public void bark()
    {
        Console.WriteLine("no barking");
    }
}