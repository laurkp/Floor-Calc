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
            var floorArea = floorWidth * floorLength;

            //Calculating tile area
            var tileArea = tileWidth * tileLength;
            Console.WriteLine($"Tile area is: {tileArea}");

            //Calculating how much flooring we need for the room
            var flooringNeeded = floorArea / tileArea;

            // Calculating the total price 
            var total = floorArea / tileArea * pricePerUnit;

            Console.WriteLine($"Calculate the labor cost if the average flooring team can only put in {FLOOR_TEAM} square feet of flooring per hour at a cost of {HOUR_PRICE}/hr");

            //Calculating hours needed for the rooms 
            var hoursN = floorArea / FLOOR_TEAM;

            //Calculating total labor cost
            var laborC = hoursN * HOUR_PRICE;

            if (floorWidth != floorLength) 
            {
                Console.WriteLine($"Floor area is: {floorArea}");
                Console.WriteLine($"Total price is: ${total}");
                Console.WriteLine($"Total hours needed is: {hoursN}");
                Console.WriteLine($"Total labor cost is: ${laborC}");
            } 
            else if (floorWidth == floorLength)
            {
                Console.WriteLine($"Floor area for the square room is: {floorArea}");
                Console.WriteLine($"Flooring needed for the square room: {flooringNeeded}");
                Console.WriteLine($"Total hours needed for the square room is: {hoursN}");
                Console.WriteLine($"Total labor cost for the square room is: ${laborC}");
            }
        }
    }
}
