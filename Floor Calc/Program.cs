namespace Floor_Calc
{
    internal class Program
    {
        //Declaring how much we put in an hour and the price
        const int FLOOR_TEAM = 20;
        const int HOUR_PRICE = 86;
        static void Main(string[] args)
        {
            // Asking the floor shape
            Console.WriteLine("Choose floor shape\n1 - rectangle\n2 - circle ");
            int floorShape = Convert.ToInt32(Console.ReadLine());

            double floorArea = 0, flooringNeeded = 0, total = 0, hoursN = 0, laborC = 0;

            // Asking for tile dimensions and price
            Console.WriteLine("Insert tile width: ");
            double tileWidth = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert tile length: ");
            double tileLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert price per unit of flooring: ");
            double pricePerUnit = double.Parse(Console.ReadLine());

            Console.WriteLine($"Calculate the labor cost if the average flooring team can only put in {FLOOR_TEAM} square feet of flooring per hour at a cost of {HOUR_PRICE}/hr");

            //Calculating tile area
            double tileArea = tileWidth * tileLength;
            Console.WriteLine($"Tile area is: {tileArea}");

            if (floorShape == 1)
            {
                // Asking dimensions of the rectangle floor
                Console.WriteLine("Insert floor width: ");
                double floorWidth = double.Parse(Console.ReadLine());

                Console.WriteLine("Insert floor length: ");
                double floorLength = double.Parse(Console.ReadLine());

                // Calculating floor area for the rectangle room
                double rectangleArea = floorWidth * floorLength;
                floorArea = rectangleArea;
            }
            if (floorShape == 2)
            {
                // Asking for the radius of the circle shaped room
                Console.WriteLine("Insert the radius of a circle shaped floor: ");
                double floorRadius = double.Parse(Console.ReadLine());

                // Calculate the floor area for the circle shaped room
                floorArea = Math.PI * (floorRadius * floorRadius);
            }
            //Calculating how much flooring we need
            flooringNeeded = floorArea / tileArea;

            // Calculating the total price 
            total = floorArea / tileArea * pricePerUnit;

            //Calculating hours needed 
            hoursN = floorArea / FLOOR_TEAM;

            //Calculating total labor cost 
            laborC = hoursN * HOUR_PRICE;

            Console.WriteLine($"Floor area is: {floorArea}");
            Console.WriteLine($"Flooring needed for the room: {flooringNeeded}");
            Console.WriteLine($"Total price is: ${total}");
            Console.WriteLine($"Total hours needed is: {hoursN}");
            Console.WriteLine($"Total labor cost is: ${laborC}");
            }
        }
    }
}
