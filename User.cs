using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHuy
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public User(string name, int age, string gender)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                throw new ArgumentNullException(nameof(gender));
            }

            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Name} | {Age} | {Gender}"; 
        }
    }
}
