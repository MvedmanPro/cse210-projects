public class User {
    public string _firstName;
    public string _lastName;
    public string _major;


    public void displayName(){
        Console.Write($"{_firstName} {_lastName} logged in. ");
        Console.WriteLine($"\n{_firstName} ({_major})");
    }
}