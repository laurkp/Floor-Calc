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
            Console.WriteLine("Choose floor shape (rectangle or circle): ");
            string floorShape = Console.ReadLine();

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

            if (floorShape == "rectangle")
            {
                // Asking dimensions of the rectangle floor
                Console.WriteLine("Insert floor width: ");
                double floorWidth = double.Parse(Console.ReadLine());

                Console.WriteLine("Insert floor length: ");
                double floorLength = double.Parse(Console.ReadLine());

                // Calculating floor area for the rectangle room
                double floorArea = floorWidth * floorLength;

                //Calculating how much flooring we need for the rectangle room
                double flooringNeeded = floorArea / tileArea;

                // Calculating the total price for the rectangle room
                double total = floorArea / tileArea * pricePerUnit;

                //Calculating hours needed for the rectangle room 
                double hoursN = floorArea / FLOOR_TEAM;

                //Calculating total labor cost for the rectangle room
                double laborC = hoursN * HOUR_PRICE;

                Console.WriteLine($"Floor area is: {floorArea}");
                Console.WriteLine($"Flooring needed for the room: {flooringNeeded}");
                Console.WriteLine($"Total price is: ${total}");
                Console.WriteLine($"Total hours needed is: {hoursN}");
                Console.WriteLine($"Total labor cost is: ${laborC}");
            }
            if (floorShape == "circle")
            {
                // Asking for the radius of the circle shaped room
                Console.WriteLine("Insert the radius of a circle shaped floor: ");
                double floorRadius = double.Parse(Console.ReadLine());

                // Calculate the floor area for the circle shaped room
                double circleArea = Math.PI * (floorRadius * floorRadius);

                //Calculating how much flooring we need for the circle shaped room
                double circleFlooring = circleArea / tileArea;

                // Calculating the total price for the circle shaped room
                double circleTotal = circleArea / tileArea * pricePerUnit;

                //Calculating hours needed for the circle shaped room 
                double circleHoursN = circleArea / FLOOR_TEAM;

                //Calculating total labor cost for circle shaped room
                double circleLaborC = circleHoursN * HOUR_PRICE;

                Console.WriteLine($"Floor area is: {circleArea}");
                Console.WriteLine($"Flooring needed for the room: {circleFlooring}");
                Console.WriteLine($"Total price is: ${circleTotal}");
                Console.WriteLine($"Total hours needed is: {circleHoursN}");
                Console.WriteLine($"Total labor cost is: ${circleLaborC}");
            }
        }
    }
}
