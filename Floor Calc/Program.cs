namespace Floor_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the price of flooring for a surface of 40x60 feets");
            
            // Declaring floor tile dimemsions and price per unit
            int w = 2;
            int l = 4;
            int P = 3;

            Console.WriteLine("Tile dimensions are: 2x4 feets at a price of $3 per tile");

            // Declaring tile area
            int T = w * l;

            Console.WriteLine("Tile area is: " + T);

            // Declaring floor dimensions
            int W = 40;
            int L = 60;

            Console.WriteLine("Floor dimensions are: 40x60 feets");
           
            // Calculating floor area
            int F = W * L;

            Console.WriteLine("Floor area is: " +F);
            
            // Calculating the total price 
            int total = F / T * P;

            Console.WriteLine("Total price is: $" +total);

            
            Console.WriteLine("Calculate how much flooring will be needed for a non-rectangular room, for example a square room");

            //Declaring room dimensions
            int squareWidht = 30;
            int squareLenght = 30;

            Console.WriteLine("Floor dimensions are: 30x30 feets");

            //Calculating floor area
            int squareF = squareWidht * squareLenght;

            Console.WriteLine("Floor area is: " + squareF);

            //Calculating how much floorin will be needed
            double neededT = squareF / T;

            Console.WriteLine("Total flooring needed is: " + neededT);

            
            Console.WriteLine("Calculate the labor cost if the average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr");

            //Declaring how much we put in an hour and the price
            int floorTeam = 20;
            int hourPrice = 86;

            //Calculating hours needed for the rooms 
            int hoursN = (F + squareF) / floorTeam;

            Console.WriteLine("Total hours needed is: " + hoursN);

            //Calculating total laborr cost
            int laborC = hoursN * hourPrice;

            Console.WriteLine("Total labor cost is: $" + laborC);



        }
    }
}