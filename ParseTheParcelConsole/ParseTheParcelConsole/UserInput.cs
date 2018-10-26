using System;

namespace ParseTheParcelConsole
{
    public class UserInput
    {
        internal void RequestUserInput(UserPackage userPackage)
        {
            Console.WriteLine("Welcome to our shipping price calculator");

            bool allInputsRead = false;
            while (allInputsRead == false)
            {
                if (userPackage.Length == 0)
                {
                    UserLength(userPackage);
                }
                else if (userPackage.Breadth==0)
                {
                    UserBreadth(userPackage);
                }
                else if (userPackage.Height==0)
                {
                    UserHeight(userPackage);
                }
                else if (userPackage.Weight==0)
                {
                    UserWeight(userPackage);
                }
                else
                {
                    allInputsRead = true;
                }
            }  
        }


        public void UserLength(UserPackage clientPackage)
        {
            Console.WriteLine("Please input the length of your parcel in mm then press enter");
            string input = Console.ReadLine();
            double result = ValidInput(input);
            if (result != 0) { clientPackage.Length = result; }
        }

        public void UserBreadth(UserPackage clientPackage)
        {
            Console.WriteLine("Please input the breadth of your parcel in mm then press enter");
            string input = Console.ReadLine();
            double result = ValidInput(input);
            if (result!=0) { clientPackage.Breadth = result; }
        }

        public void UserHeight(UserPackage clientPackage)
        {
            Console.WriteLine("Please input the height of your parcel in mm then press enter");
            string input = Console.ReadLine();
            double result = ValidInput(input);
            if (result!=0) { clientPackage.Height = result; }
        }

        public void UserWeight(UserPackage clientPackage)
        {
            Console.WriteLine("Please input the weight of your parcel in kg then press enter");
            string input = Console.ReadLine();
            double result = ValidInput(input);
            if (result != 0) { clientPackage.Weight = result; }
        }

        public double ValidInput(string input)
        {
            if (!Double.TryParse(input, out double result) || result==0)
            {
                Console.WriteLine("Invalid Input");
            }
            if (result < 0)
            {
                result = 0;
                Console.WriteLine("Invalid Input");
            }
            return result;
        }

    }
}
