// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Customers App");
List<Customer> customers=new List<Customer>
{
    new Customer{id=1,FirstName="John",LastName="Doe",ODLimit=98000.50},
    new Customer{id=2,FirstName="bubaker",LastName="Naji",ODLimit=108000.50},
    new Customer{id=3,FirstName="Abdo",LastName="Farhat",ODLimit=125000.50},
    new Customer{id=4,FirstName="Ahmed",LastName="DeBeski",ODLimit=308000.50},
    new Customer{id=5,FirstName="Mr.",LastName="Mohamed",ODLimit=4508000.50},
};
foreach(var c in customers)
{
    Console.WriteLine("ID: \t"+c.id +"\t Full Name: \t" + c.FirstName +" "+c.LastName +"\t OverDraftLimit\t"+c.ODLimit);
}