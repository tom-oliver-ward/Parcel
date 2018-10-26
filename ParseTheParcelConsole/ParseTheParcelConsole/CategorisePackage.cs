using System;
using System.Collections.Generic;
using System.Linq;


namespace ParseTheParcelConsole
{
    public class CategorisePackage
    {
        SmallPackage small = new SmallPackage();
        MediumPackage medium = new MediumPackage();
        LargePackage large = new LargePackage();
        UserPackage userPackageOptimised = new UserPackage();

        internal void CalculateParcelCost(UserPackage userPackage)
        {
            OptimiseUserPackageOrientation(userPackageOptimised, userPackage);

            var costList = new List<double>
            {
                TestLength(userPackageOptimised.Length),
                TestBreadth(userPackageOptimised.Breadth),
                TestHeight(userPackageOptimised.Height),
                TestWeight(userPackageOptimised.Weight)
            };

            if (!costList.Contains(-1))
            {
                double cost = costList.Max();
                userPackage.Cost = cost;
            }
        }



        /// <summary>
        /// This method may need explaining. The user might not input their smallest value as height and their largest as breadth
        /// This method sorts the dimensions such that the package is in the most economical orientation
        /// </summary>
        /// <param name="userPackageOptimised"></param>
        /// <param name="userPackage"></param>
        public void OptimiseUserPackageOrientation(UserPackage userPackageOptimised, UserPackage userPackage)
        {
            double[] userPackageArray = { userPackage.Breadth, userPackage.Length, userPackage.Height };
            Array.Sort(userPackageArray);            
            userPackageOptimised.Height = userPackageArray[0];
            userPackageOptimised.Length = userPackageArray[1];
            userPackageOptimised.Breadth = userPackageArray[2];
            userPackageOptimised.Weight = userPackage.Weight;
        }



        public double TestLength(double length)
        {
            double cost=-1;
            if (length <= small.Length)
            {
                cost = small.Cost;
            }
            else if (length<=medium.Length)
            {
                cost = medium.Cost;
            }
            else if (length<=large.Length)
            {
                cost = large.Cost;
            }
            else
            {
                Console.WriteLine("Package dimensions are too large - maximum dimensions are 400mm x 600mm x 250mm");
            }
            return cost;
        }
        


        public double TestBreadth(double breadth)
        {
            double cost = -1;
            if (breadth <= small.Breadth)
            {
                cost = small.Cost;
            }
            else if (breadth <= medium.Breadth)
            {
                cost = medium.Cost;
            }
            else if (breadth <= large.Breadth)
            {
                cost = large.Cost;
            }
            else
            {
                Console.WriteLine("Package dimensions are too large - maximum dimensions are 400mm x 600mm x 250mm");
            }
            return cost;
        }



        public double TestHeight(double height)
        {
            double cost = -1;
            if (height <= small.Height)
            {
                cost = small.Cost;
            }
            else if (height <= medium.Height)
            {
                cost = medium.Cost;
            }
            else if (height <= large.Height)
            {
                cost = large.Cost;
            }
            else
            {
                Console.WriteLine("Package dimensions are too large - maximum dimensions are 400mm x 600mm x 250mm");
            }

            return cost;
        }



        public double TestWeight(double weight)
        {
            double cost = -1;
            if (weight<=large.Weight)
            {
                cost = 0;
            }
            else
            {
                Console.WriteLine("Package is too heavy - maximum weight is 25kg");
            }
            return cost;
        }
    }
}
