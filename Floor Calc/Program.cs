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
            int floorWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert floor lenght: ");
            int floorLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert tile width: ");
            int tileWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert tile lenght: ");
            int tileLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert price per unit of flooring: ");
            int pricePerUnit = int.Parse(Console.ReadLine());

            // Calculating floor area
            int floorArea = floorWidth * floorLength;

            Console.WriteLine("Floor area is: " + floorArea);

            //Calculating tile area
            int tileArea = tileWidth * tileLength;

            Console.WriteLine("Tile area is: " + tileArea);

            // Calculating the total price 
            int total = floorArea / tileArea * pricePerUnit;

            Console.WriteLine("Total price is: $" + total);

            Console.WriteLine("Calculate the labor cost if the average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr");

            //Calculating hours needed for the rooms 
            int hoursN = floorArea / FLOOR_TEAM;

            Console.WriteLine("Total hours needed is: " + hoursN);

            //Calculating total labor cost
            int laborC = hoursN * HOUR_PRICE;

            Console.WriteLine("Total labor cost is: $" + laborC);

            //Asking the floor dimensions for a non-rectangular room
            Console.WriteLine("Calculate how much flooring will be needed for a square room");
            Console.WriteLine("Insert floor side: ");
            int floorSide = int.Parse(Console.ReadLine());

            // Calculating floor area for the square room
            int squareFloorArea = floorSide * floorSide;

            Console.WriteLine("Floor area for the square room is: " + squareFloorArea);

            //Calculating how much flooring we need for the room
            int flooringNeeded = squareFloorArea / tileArea;

            Console.WriteLine("Flooring needed for the square room: " + flooringNeeded);

            //Calculating hours needed for the square room
            int squareHoursN = squareFloorArea / FLOOR_TEAM;

            Console.WriteLine("Total hours needed for the square room is: " + squareHoursN);

            //Calculating total laborr cost for the square room
            int squareLaborC = squareHoursN * HOUR_PRICE;

            Console.WriteLine("Total labor cost for the square room is: $" + squareLaborC);
        }
    }
}
