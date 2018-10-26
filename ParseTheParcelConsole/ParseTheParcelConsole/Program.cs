using System;

namespace ParseTheParcelConsole
{
    class Program
    {      
        
        public static void Main(string[] args)
        {
            var userInput = new UserInput();
            var userPackage = new UserPackage();
            var categorisePackage = new CategorisePackage();
            
            userInput.RequestUserInput(userPackage);
            categorisePackage.CalculateParcelCost(userPackage);            

            if(userPackage.Cost!=0)
            {
                Console.WriteLine("The cost of shipping your parcel is $" + userPackage.Cost);
            }            
            Console.ReadLine();
        }
    }
}
