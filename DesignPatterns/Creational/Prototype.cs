using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public class Prototype
    {
        public class Person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public AditionalInformation AditionalInformation { get; set; }

            public Person ShallowCopy()
            {
                return (Person)this.MemberwiseClone();
            }

            public Person DeepCopy()
            {
                Person person = (Person)this.MemberwiseClone();

                person.Name = String.Copy(this.Name);
                person.LastName = String.Copy(this.LastName);
                person.AditionalInformation = new AditionalInformation();
                person.AditionalInformation.SetAge(this.AditionalInformation.GetAge());

                return person;
            }
        }

        public class AditionalInformation
        {
            private int _age;

            public void SetAge(int age)
            {
                this._age = age;
            }

            public int GetAge() => this._age;
        }
    }


}
