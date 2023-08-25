using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Strings
{
    /// <summary>
    /// Computer implements the IBootUp interace.
    /// String automatic properites for Brand, & Type are set
    /// All members of interface is in this class
    /// a construstor with parameters that assigns brand, type and isOn, 
    /// The PowerOnOff method & in the body have set IsOn to the opposite of the current value
    /// A message is printed depeding is the computer is on or off 
    /// each message different if IsOn is true or false
    /// An override function returns a string & is called ToString
    /// ToString returns <Brand> & <Type>
    /// </summary>
    internal class Computer : IBootUp
    {
        public bool IsOn { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }
         
        public Computer(string brand, string type, bool isOn)
        {

            Brand = brand; 
            Type = type;    
            IsOn = isOn;    


        }
        public void PowerOnOff()
        {
            IsOn = !IsOn; 

            if(IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");

            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a {Type} computer, it is it is on {IsOn}!";
        }
    }
}
