namespace Floor_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for floor and tile dimensions and price per unit
            Console.WriteLine("Insert floor width: ");
            int floorWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert floor lenght: ");
            int floorLenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert tile width: ");
            int tileWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert tile lenght: ");
            int tileLenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert price per unit of flooring: ");
            int pricePerUnit = int.Parse(Console.ReadLine());

            // Calculating floor area
            int floorArea = floorWidth * floorLenght;

            Console.WriteLine("Floor area is: " + floorArea);

            //Calculating tile area
            int tileArea = tileWidth * tileLenght;

            Console.WriteLine("Tile area is: " + tileArea);
      
            // Calculating the total price 
            int total = floorArea / tileArea * pricePerUnit;

            Console.WriteLine("Total price is: $" +total);

            Console.WriteLine("Calculate the labor cost if the average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr");

            //Declaring how much we put in an hour and the price
            int floorTeam = 20;
            int hourPrice = 86;

            //Calculating hours needed for the rooms 
            int hoursN = floorArea / floorTeam;

            Console.WriteLine("Total hours needed is: " + hoursN);

            //Calculating total laborr cost
            int laborC = hoursN * hourPrice;

            Console.WriteLine("Total labor cost is: $" + laborC);
        }
    }
}
