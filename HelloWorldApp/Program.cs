using System;
using HelloWorldApp;
class HelloWorld{
public static void Main(string[] arg){
    H h1 = new H();
    h1.solve();
    Stu s1=new Stu();
    s1.data("sathwika",21,12221254,"cse");
    s1.print();
    OnlinePayment payment;
    payment =new UPIPayment();
    payment.pay();
    payment=new CardPayment();
    payment.pay();
    Animal A;
    A =new Cow();
    A.bark();
    A=new Crow();
    A.bark();
}

}

