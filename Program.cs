namespace HashLinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable Program");
            LinkedMap<string, int> linkedmap = new LinkedMap<string, int>(5);

            string Sentence = "paranoids are not paranoid because they are paranoid but because " +
                "they keep putting themselves deliberately into paranoid avoidable situations";
            string[] Words = Sentence.Split(" ");
            foreach (string word in Words)
            {
                int Value = linkedmap.Get(word);
                if (Value == default)
                    Value = 1;
                else Value++;
                linkedmap.Add(word, Value);
            }
            int Frequency = linkedmap.Get("paranoid");
            Console.WriteLine("\"paranoid\" comes {0} times in the given paragraph", Frequency);
            Frequency = linkedmap.Get("are");
            Console.WriteLine("\"are\" comes {0} times in the given paragraph", Frequency);
            Frequency = linkedmap.Get("they");
            Console.WriteLine("\"they\" comes {0} times in the given paragraph", Frequency);
        }
    }
}

