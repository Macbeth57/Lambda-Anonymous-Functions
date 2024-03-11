namespace NumPy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 15, 45, 25, 36, 17, 20, 0, 86};
            Func<int,int> addTwo = x => x + 2;

            list = MyFunction(list, addTwo);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            list = MyFunction(list, x => x - 10);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public static List<int> MyFunction(List<int> list, Func<int,int> anonFunc)
        {
            List<int> listToReturn = new List<int>();

            foreach (int value in list)
            {
                listToReturn.Add(anonFunc(value));
            }
            return listToReturn;
        }
    }
}
