namespace Floor_Calc
{
    internal class Program
    {
        //Declaring how much we put in an hour and the price
        const int FLOOR_TEAM = 20;
        const int HOUR_PRICE = 86;
        static void Main(string[] args)
        {
            // Asking for floor and tile dimensions and price per unit
            Console.WriteLine("Insert floor width: ");
            double floorWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert floor length: ");
            double floorLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert tile width: ");
            double tileWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert tile length: ");
            double tileLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert price per unit of flooring: ");
            double pricePerUnit = double.Parse(Console.ReadLine());

            // Calculating floor area
            double floorArea = floorWidth * floorLength;

            Console.WriteLine($"Floor area is: {floorArea}");

            //Calculating tile area
            double tileArea = tileWidth * tileLength;

            Console.WriteLine($"Tile area is: {tileArea}");

            // Calculating the total price 
            double total = floorArea / tileArea * pricePerUnit;

            Console.WriteLine($"Total price is: ${total}");

            Console.WriteLine($"Calculate the labor cost if the average flooring team can only put in {FLOOR_TEAM} square feet of flooring per hour at a cost of {HOUR_PRICE}/hr");

            //Calculating hours needed for the rooms 
            double hoursN = floorArea / FLOOR_TEAM;

            Console.WriteLine($"Total hours needed is: {hoursN}");

            //Calculating total labor cost
            double laborC = hoursN * HOUR_PRICE;

            Console.WriteLine($"Total labor cost is: ${laborC}");

            //Asking the floor dimensions for a non-rectangular room
            Console.WriteLine("Calculate how much flooring will be needed for a square room");
            Console.WriteLine("Insert floor side: ");
            double floorSide = double.Parse(Console.ReadLine());

            // Calculating floor area for the square room
            double squareFloorArea = floorSide * floorSide;

            Console.WriteLine($"Floor area for the square room is: {squareFloorArea}");

            //Calculating how much flooring we need for the room
            double flooringNeeded = squareFloorArea / tileArea;

            Console.WriteLine($"Flooring needed for the square room: {flooringNeeded}");

            //Calculating hours needed for the square room
            double squareHoursN = squareFloorArea / FLOOR_TEAM;

            Console.WriteLine($"Total hours needed for the square room is: {squareHoursN}");

            //Calculating total laborr cost for the square room
            double squareLaborC = squareHoursN * HOUR_PRICE;

            Console.WriteLine($"Total labor cost for the square room is: ${squareLaborC}");
        }
    }
}
