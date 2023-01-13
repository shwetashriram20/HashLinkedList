namespace HashLinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable Program");
            LinkedMap<string, int> linkedmap = new LinkedMap<string, int>(5);

            string Sentence = "to be or not to be";
            string[] Words = Sentence.Split(" ");
            foreach (string word in Words)
            {
                int Value = linkedmap.Get(word);
                if (Value == default)
                    Value = 1;
                else Value++;
                linkedmap.Add(word, Value);
            }
            int Frequency = linkedmap.Get("to");
            Console.WriteLine(Frequency);
        }
    }
}
