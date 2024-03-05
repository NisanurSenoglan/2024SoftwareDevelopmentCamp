using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Nisanur");

            /*
            Sum(num1: 10, num2: 20);   // Sum(25, 30);
            int result1 = Sum(15, 25);
            Sum();

            //Arrays
            string[] students = new string[3];
            students[0] = "Nisa";
            students[1] = "Beyza";
            students[2] = "Nur";

            students = new string[4];
            students[3] = "Engin";

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            //'students' dizisinin referansı değiştirilerek yeni bir dizi atanmıştır.
            //Bu durumda, önceki dizi bellekten(heap) silinir ve yeni dizi ile yer değiştirir.
            //'students' dizisinin referansı değiştiği için önceki elemanlara erişilemez.

            string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = { "Bursa", "Antalya", "Diyarbakır" };
            cities2 = cities1;
            cities1[0] = "Adana";   //cities2[0] = "Adana" oldu.
            foreach (string element in cities1)
            {
                Console.WriteLine(element);
            }

            //Dizi oluşturmadan liste yapıp döngüyle yazdırılabilir.
            List<string> newCities = new List<string> { "Ankara", "İstanbul", "İzmir" };
            foreach (var element in newCities)
            {
                Console.WriteLine(element);
            }

            List<string> newCities1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            newCities1.Add("Adana1");    //Add metodu kullanılarak "Adana1" elemanı listenin sonuna eklenmiştir. 
            foreach (var element1 in newCities1)
            {
                Console.WriteLine(element1);
            }*/

            Person person1 = new Person();  //using Entities.Concrete;
            person1.FirstName = "NİSANUR";
            person1.LastName = "ŞENOĞLAN";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 12345678910;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        static void SayHello(string name = "İsimsiz")
        {
            Console.WriteLine($"Merhaba {name}!");
        }
        static int Sum(int num1 = 0, int num2 = 0)
        {
            int result = num1 + num2;
            Console.WriteLine("Toplam: " + result);
            return result;
        }
    }
    public class Citizen
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int BirthYear { get; set; }
        public long IdNumber { get; set; }
    }
}
