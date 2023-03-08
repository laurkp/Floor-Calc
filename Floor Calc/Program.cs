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

            Console.WriteLine("Insert the radius of a circle shaped floor: ");
            double floorRadius = float.Parse(Console.ReadLine());

            // Calculating floor area for a rectangle room
            double floorArea = floorWidth * floorLength;

            // Calculate the floor area for a circle shaped room
            double circleArea = Math.PI * (floorRadius * floorRadius);

            //Calculating tile area
            double tileArea = tileWidth * tileLength;

            //Calculating how much flooring we need for the rooms
            double flooringNeeded = floorArea / tileArea;
            double circleFlooring = circleArea/ tileArea;

            // Calculating the total price for the rooms
            double total = floorArea / tileArea * pricePerUnit;
            double circleTotal = circleArea / tileArea * pricePerUnit;

            Console.WriteLine($"Calculate the labor cost if the average flooring team can only put in {FLOOR_TEAM} square feet of flooring per hour at a cost of {HOUR_PRICE}/hr");

            //Calculating hours needed for the rooms 
            double hoursN = floorArea / FLOOR_TEAM;
            double circleHoursN = circleArea/ FLOOR_TEAM;   

            //Calculating total labor cost for the rooms
            double laborC = hoursN * HOUR_PRICE;
            double circleLaborC = circleHoursN * HOUR_PRICE;

            Console.WriteLine($"Tile area is: {tileArea}");
            Console.WriteLine($"Floor area is {floorArea} for the rectangle room and {circleArea} for the circle shaped room.");
            Console.WriteLine($"Flooring needed for the room {flooringNeeded} for the rectangle room and {circleFlooring} for the circle shaped room.");
            Console.WriteLine($"Total price is ${total} for the rectangle room and ${circleTotal} for the circle shaped room.");
            Console.WriteLine($"Total hours needed is {hoursN} for the rectangle room and {circleHoursN} for the circle shaped room.");
            Console.WriteLine($"Total labor cost is: ${laborC} for the rectangle room and ${circleLaborC} for the circle shaped room.");
        }
    }
}
