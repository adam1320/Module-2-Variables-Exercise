using System;

namespace TCModule2VariablesExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Names of my children, oldest to youngest
            string wifeName = "Mandy";
            string child1Name = "Trevor";
            string child2Name = "Makenzy";
            string child3Name = "Addison";
            string child4Name = "Ashton";

            //Ages of my children, oldest to youngest, and by reference
            int child1Age = 17;
            int child2Age = 15;
            int child3Age = 10;
            int child4Age = 9;

            //Number of Dogs that we own
            char numberOfDogs = '2';

            //Boolean value demonstrating that our dogs are corgi breed
            bool dogsAreCorgi = true;

            //Using decimal to demonstrate tow vehicle MPG while towing fully loaded camper
            decimal towVehicleMpg = 10.5m;

            //double to show cost for fuel during trip to tow camper and family
            double fuelCost = 269.91;
            
            Console.WriteLine($"My wife, {wifeName}, and I enjoy an annual camping trip to the remote north country of Michigan's " +
                $"upper peninsula, along with our children, {child1Name}, {child1Age}, {child2Name}, {child2Age}, " +
                $"{child3Name}, {child3Age}, and {child4Name}, {child4Age}. We also take along our {numberOfDogs} " +
                $"dogs. Are they Corgis? {dogsAreCorgi}! A crew this large requires a big camper, and a big truck" +
                $" to tow it with. We get {towVehicleMpg} MPG, and our total fuel cost for the trip last year was" +
                $" ${fuelCost}.");


        }
    }
}
