using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14_files
{
    [Serializable]
    internal class Employee : IComparable
    {
        string _fullName;
        string _department;
        string _position;
        double _experienceYears;
        double _salary;
        double _bonus;

        public string FullName
        {
            // new feature ^-^
            get => _fullName;
            set => _fullName = string.IsNullOrWhiteSpace(value) ? "person x" : value;
        }

        public string Department
        {
            get => _department; 
            set => _department = string.IsNullOrWhiteSpace(value) ? "department x" : value;
        }

        public string Position
        {
            get => _position;  
            set => _position = string.IsNullOrWhiteSpace(value) ? "position x" : value;
        }

        public double ExperienceYears
        {
            get => _experienceYears;
            set
            {
                if (ExperienceYears < 0)
                {
                    _experienceYears = 0.0;
                    throw new ArgumentException("Experience years cannot be negative.");
                }
                else
                {
                    _experienceYears = value;
                    CalculateBonus();
                }
            }
        }

        public double Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                {
                    _salary = 0.0;
                    throw new ArgumentException("Salary cannot be negative.");
                } 
                else
                {
                    _salary = value;
                    CalculateBonus();
                }
            }
        }

        public double Bonus
        {
            get => _bonus;
            private set => _bonus = value;
        }

        public Employee() { }

        public Employee(string fullName, 
                        string department, 
                        string position, 
                        double experienceYears, 
                        double salary)
        {
            FullName = fullName;
            Department = department;
            Position = position;
            ExperienceYears = experienceYears;
            Salary = salary;
            CalculateBonus();
        }

        private void CalculateBonus()
        {
            if (ExperienceYears >= 3)
            {
                Bonus = Salary * 0.1;
            } 
            else if (ExperienceYears >= 5)
            {
                Bonus = Salary * 0.2;
            }
            else if (ExperienceYears >= 7)
            {
                Bonus = Salary * 0.3;
            } 
            else
            {
                Bonus = 0.0;
            }
        }

        public override string ToString()
        {
            return $"{FullName}" +
                $"\t{Department}" +
                $"\t{Position}" +
                $"\t{ExperienceYears}" +
                $"\t{Salary}" +
                $"\t{Bonus}\n";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1; 

            Employee other = obj as Employee;

            if (other != null)
            {
                // як на мене, логічніше порівнювати за іменем, а не зарплатою..
                return this.Salary.CompareTo(other.Salary); 
            }
            else
            {
                throw new ArgumentException("Object is not an Employee");
            }
        }
    }
}
