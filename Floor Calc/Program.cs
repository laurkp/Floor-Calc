

namespace Floor_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorShape = FloorMethods.AskFloorShape();

            double floorArea = 0;

            double tileArea = FloorMethods.TileArea();

            double pricePerUnit = FloorMethods.AskTilePrice();

            if (floorShape == 1)
            {
                floorArea = FloorMethods.RectangleArea();
            }
            if (floorShape == 2)
            {
                floorArea = FloorMethods.CircleArea();
            }

            FloorMethods.AskLaborCost();
            FloorMethods.CalculateFlooring(floorArea, tileArea, pricePerUnit);
            FloorMethods.CalculateLabor(floorArea);
        }
    }
}