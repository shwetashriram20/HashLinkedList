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
            Console.Write("Enter the word you want to omit: ");
            string BannedWord = Console.ReadLine();
            foreach (string word in Words)
            {
                if (word != BannedWord)
                {
                    int Value = linkedmap.Get(word);
                    if (Value == default)
                        Value = 1;
                    else Value++;
                    linkedmap.Add(word, Value);
                }
            }
            int Frequency = linkedmap.Get(BannedWord);
            Console.WriteLine("\n\"{0}\" comes {1} times in the given paragraph now",
                BannedWord, Frequency);
            Console.WriteLine("\nResulting paragraph:\n" + linkedmap.Result);
        }
    }
}

