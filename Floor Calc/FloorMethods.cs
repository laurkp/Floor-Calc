namespace Floor_Calc
{
    public static class FloorMethods
    {
        public const int FLOOR_TEAM = 20;
        public const int HOUR_PRICE = 86;
        /// <summary>
        /// Asking for floor shape
        /// </summary>
        /// <returns></returns>
        public static int AskFloorShape()
        {
            Console.WriteLine("Choose floor shape\n1 - rectangle\n2 - circle");
            int shape = Convert.ToInt32(Console.ReadLine());
            return shape;
        }
        /// <summary>
        /// Asking tile price
        /// </summary>
        /// <returns></returns>
        public static double AskTilePrice()
        {
            Console.WriteLine("Insert price per unit of flooring: ");
            double price = Convert.ToDouble(Console.ReadLine());
            return price;
        }
        /// <summary>
        /// Prompt for the calculation of labor cost
        /// </summary>
        public static void AskLaborCost()
        {
            Console.WriteLine($"Calculate the labor cost if the average flooring team can only put in {FLOOR_TEAM} square feet of flooring per hour at a cost of {HOUR_PRICE}/hr");
        }
        /// <summary>
        /// Ask tile dimensions and calculates tile area
        /// </summary>
        /// <param name=></param>
        /// <param name=></param>
        /// <returns></returns>
        public static double TileArea()
        {
            Console.WriteLine("Insert tile width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert tile length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            double area = width * length;
            Console.WriteLine($"Tile area is {area}");
            return area;
        }
        /// <summary>
        /// Calculates area of a rectangle room
        /// </summary>
        /// <param name=></param>
        /// <param name=></param>
        /// <returns></returns>
        public static double RectangleArea()
        {
            Console.WriteLine("Insert floor width: ");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert floor length: ");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());
            double rectangleArea = rectangleWidth * rectangleLength;
            return rectangleArea;
        }
        /// <summary>
        /// Calculates area of a circle shaped room
        /// </summary>
        /// <returns></returns>
        public static double CircleArea()
        {
            Console.WriteLine("Insert the radius of a circle shaped floor: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double circleArea = Math.PI * (radius * radius);
            return circleArea;
        }
        /// <summary>
        /// Calculates flooring needed and total price of flooring
        /// </summary>
        /// <param name="floorArea"></param>
        /// <param name="tileArea"></param>
        /// <param name="pricePerUnit"></param>
        public static void CalculateFlooring(double floorArea, double tileArea, double pricePerUnit)
        {
            double flooringNeeded = floorArea / tileArea;
            double total = flooringNeeded * pricePerUnit;
            Console.WriteLine($"Flooring needed for the room: {flooringNeeded}");
            Console.WriteLine($"Total price is: ${total}");
        }
        /// <summary>
        /// Calculates the labor cost and hours needed
        /// </summary>
        /// <param name="floorArea"></param>
        public static void CalculateLabor(double floorArea)
        {
            double hoursNeeded = floorArea / FLOOR_TEAM;
            double laborCost = hoursNeeded * HOUR_PRICE;
            Console.WriteLine($"Total hours needed is: {hoursNeeded}");
            Console.WriteLine($"Total labor cost is: ${laborCost}");
        }

    }
}