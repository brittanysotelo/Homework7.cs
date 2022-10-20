namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer C1 = new Customer();
        C1.ID = 110;
        C1.Name = "Alice";
        C1.Age = 28;
        C1.PrintCustomerInfo();

        Customer C2 = new Customer();
        C2.ID = 111;
        C2.Name = "Bob";
        C2.Age = 30;
        C2.PrintCustomerInfo();

        C1.new_ID = 220;
        C1.UpdateNew_ID();
        C2.new_ID = 221;
        C2.UpdateNew_ID();

//Wasn't sure on how to do the last part, this is what I got to 
    //     C1.Age = new Customer(: 28);
    //     C2.Age = new Customer(Age: 30);
    //     C1.CompareAge(C2);
    //     C2.CompareAge(C1);
    }
}
