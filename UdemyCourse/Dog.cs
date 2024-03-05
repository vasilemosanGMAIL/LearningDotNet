using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCourse
{
    internal class Dog
    {
        private string _name;
        private string _breed;
        private int _weight;

        public Dog(string name, string breed, int weight)
        {
            _breed = breed;
            _name = name;
            _weight = weight;
        }

        public Dog(string name, int weight, string breed = "mixed-breed")
        {
            _name = name; _breed = breed;
            _weight = weight;
        }

        public string Describe()
        {
            if (_weight < 5) 
                return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a tiny dog.";
            else if (_weight >= 5 && _weight < 30) 
                return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a medium dog.";
            else return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a large dog.";
        }
    }
}
