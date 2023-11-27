using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme11Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person;
            //person = new Person();
            Person person = new Person();
            person.name = "Иван";
            person.surname = "Иванов";
            person.age = 20;
            //person.Info();
            Person person1 = new Person();
            person1.name = "Илья";
            person1.surname = "Абабий";
            person1.age = 16;
            //Console.WriteLine($"{person1.ToString()}");
            Person person2 = new Person();
            person2.name = "Артём";
            person2.surname = "Сиглов";
            person2.age = 17;
            //Console.WriteLine($"{person2.ToString()}");


            Address address = new Address();
            address.index = 3300;
            address.country = "Молдова";
            address.city = "Кишинёв";
            address.city = "Восточная";
            address.house = 5;
            address.apartament = 28;
            //Console.WriteLine($"{address.ToString()}");


            Dog neapolitanmastiff = new Dog();
            neapolitanmastiff.breed = "Неаполитанский мастиф";
            neapolitanmastiff.size = 60;
            neapolitanmastiff.age = 7;
            neapolitanmastiff.color = "черный";
            Console.WriteLine($"{neapolitanmastiff.ToString()}\n");
            Dog maltese = new Dog();
            maltese.breed = "Мальтезе";
            maltese.size = 20;
            maltese.age = 12;
            maltese.color = "белый";
            Console.WriteLine($"{maltese.ToString()}\n");
            Dog сhowсhow = new Dog();
            сhowсhow.breed = "Чау-чау";
            сhowсhow.size = 48;
            сhowсhow.age = 10;
            сhowсhow.color = "рыжий";
            Console.WriteLine($"{сhowсhow.ToString()}");

            Console.Read();
        }
    }
}
