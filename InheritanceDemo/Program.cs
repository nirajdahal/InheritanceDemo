using System;
using System.Collections.Generic;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Corola car1 = new Corola();
            //car1.NumberOfDoors = 5;
            //car1.NumberOfWheels = 10;

            //SmartPhone smrtPhone = new SmartPhone();
            //smrtPhone.Apps = new List<string>();

            //It is totally validate to do this beacuse SmartPhone is type of Phone
            //Phone phone = new SmartPhone();

            List<Phone> phones = new List<Phone>();
            phones.Add(new SmartPhone());
            phones.Add(new CellPhone());

            
            foreach(Phone phone in phones)
            {
                if (phone is CellPhone cell)
                {
                    cell.Carrier = "Ncell";
                }

                if(phone is SmartPhone smartPhone)
                {
                    smartPhone.Apps = new List<string> {
                    "CandyCrush",
                    "FreeFire",
                    "Call Of Duty",
                    "Pubg",
                    "FlappyBird",
                    "TikTok"
                    };
                    
                }
            }
        }
    }
}
