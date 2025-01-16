using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OOP
{
    #region enum for Q1
    [Flags]
    public enum SecurityPrivileges : byte
    {
        guest = 1, developer = 2, secretary = 4, DBA = 8
    }
    #endregion
    public class Employee
    {
        #region fields
        private char gender;
        private HiringDate hireDate;
        private string name;
        private int age;
        private int id;
        private decimal salary;
        #endregion

        #region properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public SecurityPrivileges Security
        {
            get; set;
        }
        public HiringDate HireDate
        {
            get { return hireDate; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Invalid hire date provided cannot be null.");
                    hireDate = new HiringDate(1, 1, 2000);
                }
                else
                {
                    hireDate = value;
                }
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F'|| value == 'f'|| value == 'm')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Invalid gender provided");
                    gender = '_';
                }
            }
        }

        #endregion

        #region Constructors
        public Employee() : this(0, "notProvided", '_', 0.0m, new HiringDate(1, 1, 2020), (SecurityPrivileges)1)
        {
        }

        public Employee(int id, string name) : this(id, name, '_', 0.0m, new HiringDate(4, 4, 2024), (SecurityPrivileges)1)
        {
        }

        public Employee(int id, string name, char gender) : this(id, name, gender, 0.0m, new HiringDate(4, 4, 2024), (SecurityPrivileges)1)
        {
        }

        public Employee(int id, string name, char gender, decimal salary) : this(id, name, gender, salary, new HiringDate(4, 4, 2024), (SecurityPrivileges)1)
        {
        }
        public Employee(int id, string name, char gender, decimal salary, HiringDate hireDate, SecurityPrivileges security)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            Security = security;
        }

        public Employee(int id, string name, char gender, decimal salary, SecurityPrivileges securityPrivileges) : this(id, name, gender, salary)
        {
        }
        #endregion

        #region indexer
        public string this[int ID]
        {
            get
            {
                if (ID == this.ID)
                {
                    return Name;
                }
                else
                {
                    throw new KeyNotFoundException($"No employee found with ID: {ID}");

                }
            }
            set
            {
                if (ID == this.ID)
                {
                    Name = value;
                }
                else
                {
                    throw new KeyNotFoundException($"No employee found with ID: {ID}");
                }
            }
        }
        #endregion

        #region function tostring
        public override string ToString()
        {
            return String.Format(
                "ID: {0}\nname: {1}\ngender: {2}\nsalary: {3}\nhire Date: {4:yyyy-MM-dd}\npermission: {5}",
                ID, Name, Gender, String.Format("{0:C}", Salary), HireDate, Security
            );
        }
        #endregion


        #region function sort by horing date
        public static void SortEmployees(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = 0; j < employees.Length - i - 1; j++)
                {
                    HiringDate date1 = employees[j].HireDate;
                    HiringDate date2 = employees[j + 1].HireDate;

                    if (date1.Year > date2.Year ||
                        (date1.Year == date2.Year && date1.Month > date2.Month) || (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day > date2.Day))
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                }
            }
        }
        #endregion


    }
}
