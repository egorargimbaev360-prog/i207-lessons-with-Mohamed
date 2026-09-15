using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static Lesson3.Profile clsProfile = new Lesson3.Profile();
        static void Main(){
            Console.WriteLine($"id:{clsProfile.id}\n" +
                              $"Fullname: {clsProfile.name} {clsProfile.surName} {clsProfile.familyName}\n" +
                              $"Age: {DateTime.Now.Year - clsProfile.birthDate.Year}\n" +
                              $"BirthDate: {clsProfile.birthDate}\n" +
                              $"Gender: {(clsProfile.gender == false ? "Man" : "Woman")}");
                
           
        }
    }
}
