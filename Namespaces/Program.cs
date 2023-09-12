using System;
using Kulpot;
//using Your;   // explicit must .Dog

//ref link:https://www.youtube.com/watch?v=AK40rIzwDbU&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=54
//

namespace Kulpot
{
    class Dog { }
}

namespace Your
{
    class Dog { }
}
//class KulpotDog { }

//class YourDog { }

class MainClass
{
    static void Main()
    {
        //KulpotDog dog1 = new KulpotDog();
        Kulpot.Dog dog = new Kulpot.Dog();
        Your.Dog yDog = new Your.Dog();
        Dog usingKulpotdog = new Dog();
    }
}