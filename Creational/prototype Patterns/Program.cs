using System;

namespace prototype_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new CopyEmployee(){
                Age=10,
                Name="name",
                address=new Address(){
                    BuilderNum=10,
                    City="assuit",
                    Countery="Eegypt"
                }
            };
            Console.WriteLine("basic Employee");
            Console.WriteLine(employee.ToString());
            Employee copyEmployee=employee.ShallowCope();
            employee.Age=11;
            employee.Name="name2";
            copyEmployee.address.City="New Assuit";
            Console.ForegroundColor=ConsoleColor.DarkBlue;
            Console.WriteLine("Shallow Cope");
            Console.WriteLine(copyEmployee.ToString());
            Console.WriteLine(employee.ToString());
Console.WriteLine("-----------------------------------------------------------------------------");
            Employee employeeDep=new CopyEmployee(){
                Age=20,
                Name="nameDep",
                address=new Address(){
                    BuilderNum=20,
                    City="assuitDep",
                    Countery="Eegypt"
                }
            };
            Console.WriteLine("basic Employee");
            Console.WriteLine(employeeDep.ToString());
            Employee copyEmployeeDep=employeeDep.deepCope();
            employeeDep.Age=11;
            employeeDep.Name="nameDeep2";
            employeeDep.address.City="New Assuit Dep";
            Console.ForegroundColor=ConsoleColor.Cyan;
            Console.WriteLine("Deep Cope");
            Console.WriteLine(copyEmployeeDep.ToString());
            Console.WriteLine(employeeDep.ToString());

            
        }
    }
}
