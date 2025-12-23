namespace HelloWorldApp;
class Stu{
    string name="";
    int age;
    int id;
    string subject="";
    public void data(string n,int a,int i,string s){
        name=n;
        age=a;
        id=i;
        subject=s;
    }
    public void print(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Subject: {subject}");
    }
} 