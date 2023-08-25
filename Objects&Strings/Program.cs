// See https://aka.ms/new-console-template for more information
namespace Objects_Strings
{

    class Program
    {
        /// <summary>
        /// A computer object passes thorugh needed arguments
        /// IBootUp object is assigned to computer object
        /// IBootUp & computer are compared equals & result printed to console
        /// Othercomputer object is assigned to the same values passed through the first computer object
        /// the two computer objects are compared, they have the same values & results are printed to console
        /// A string variable is given the same value as the computer objects ToString method
        /// The string is compared to object using ToString & results printed to console
        /// The GetType method is used on computer object & results are printed to console
        /// GetType is used on IBootUp object and results are printed to console
        /// The computer objects can be turn on or off by calling the PowerOnOff method
        /// ToUpper is used on the string variable & results are printed.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)

        {
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUp myBootUp = myComputer; 
            Console.WriteLine(myComputer.Equals(myBootUp));


            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString = myComputer.ToString();
            string myOtherString = myString;

            myString = "Hi!";


            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            myOtherComputer.PowerOnOff();
            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains('i'));
            
            Console.WriteLine(myString.ToUpper());  
          
        }
    }
}