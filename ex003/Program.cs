void New_array(int[] arr)
{
    int[] array = new int[8];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(1, 100);
    }
}
New_array(array);