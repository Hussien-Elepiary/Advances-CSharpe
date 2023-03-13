namespace Session_01
{
    public class HelperGenaric<T> where T : IComparable<T>
    {
        public static int SearchArray(T[] array , T value)
        {
            if(array is not null )
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (value.Equals(array[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static void BubbleSort(T[] array) 
        {
            if (array is not null)
                for (int i = 0; i < array.Length; i++)
                    for (int j = 0; j < array.Length - i - 1; j++)
                        if (array[j].CompareTo(array[j + 1]) == 1)
                            SWAP(ref array[j],ref array[j + 1]);
        }

        public static void SWAP(ref T X , ref T Z)
        {
            T temp = X;
            X = Z;
            Z = temp;
        }
    }
}
