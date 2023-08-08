using System;

namespace Assign24Lib
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double Salary { get; set; }

    }
}
