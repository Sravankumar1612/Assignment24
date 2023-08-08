using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Assign24Lib;
namespace BinarySerializaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Binary Serialization
            Employee employee = new Employee() { Id=1,FirstName="Ram",LastName="Laksman",Salary=56783.6};
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("E://Dotnet//Phase1//Day21//Assignment24//emp.bin", FileMode.Create))
            {
                bf.Serialize(fs, employee);
            }
            Console.WriteLine("Created & Serialized");
            using (FileStream fs2 = new FileStream("E://Dotnet//Phase1//Day21//Assignment24//emp.bin", FileMode.Open))
            {
                Employee dp = (Employee)bf.Deserialize(fs2);
                Console.WriteLine();
                Console.WriteLine("Deserialised");
                Console.WriteLine("Employee ID : " + dp.Id);
                Console.WriteLine("Employee FirstName : " + dp.FirstName);
                Console.WriteLine("Employee LastName : " + dp.LastName);
                Console.WriteLine("Employee Salary : " + dp.Salary);
            }
            Console.WriteLine();
            //XML Serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("E:\\Dotnet\\Phase1\\Day21\\Assignment24\\Emp.xml"))
            {

                serializer.Serialize(writer, employee);

            }
            Console.WriteLine("Xml Serialization Done");
            Console.WriteLine();
            XmlSerializer ds = new XmlSerializer(typeof(Employee));
            using (TextReader reader = new StreamReader("E:\\Dotnet\\Phase1\\Day21\\Assignment24\\Emp.xml"))
            {
                Employee dplayer = (Employee)ds.Deserialize(reader);
                Console.WriteLine($"ID : {dplayer.Id}\n FirstName : {dplayer.FirstName}");
                Console.WriteLine($"Last Name : {dplayer.LastName}\n Salary :  {dplayer.Salary}");
            }
            Console.ReadKey();
        }
    }
}
