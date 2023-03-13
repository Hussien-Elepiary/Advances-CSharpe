using Session_01.Point;

namespace Session_01
{
    public class Helper
    {
        public static void BubbleSort(int[] array)
        {
            if (array is not null)
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                        if (array[j] > array[j + 1])
                            SWAP(ref array[j], ref array[j + 1]);
        }


        public static void SWAP (ref int X , ref int Y)
        {
            Console.WriteLine("===SWAP===");
            int Temp = X;
            X = Y ;
            Y = Temp;
        }

        public static void SWAP (ref double X, ref double Y)
        {
            Console.WriteLine("===SWAP===");
            double Temp = X;
            X = Y;
            Y = Temp;
        }

        public static void SWAP (ref Point2D X, ref Point2D Y)
        {
            Console.WriteLine("===SWAP===");
            Point2D Temp = X;
            X = Y;
            Y = Temp;
        }
    }
}
