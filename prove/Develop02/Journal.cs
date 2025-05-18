namespace JournalProject {

    public class Journal
    {
        public List<Entry> entries = new List<Entry>();
        public PromptGenerator promptGenerator = new PromptGenerator();

        public Journal()
        {
            PromptGenerator promptGenerator = new PromptGenerator();
        }

        public void AddEntry()
        {
            string prompt = promptGenerator.GenerateRandomPrompt();
            Console.Write("Please enter the date (mm/dd/yyyy): ");
            string dateInput = Console.ReadLine();
            Console.WriteLine($"Today's Prompt: {prompt}");
            Console.Write("> ");
            string content = Console.ReadLine();

            // Stretch Challenge
            Console.Write("What is your mood today? (ex: happy) ");
            string mood = Console.ReadLine();

            Entry entry = new Entry(dateInput, prompt, content, mood);
            entries.Add(entry);

        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                entry.DisplayEntry();
            }
        }

        public void SaveToFile()
        {
            Console.Write("Please enter the filename you would like to save to: ");
            string filename = Console.ReadLine();
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine(entry.Date);
                        writer.WriteLine(entry.Prompt);
                        writer.WriteLine(entry.Response);
                        writer.WriteLine(entry.Mood);
                    }
                }
                Console.WriteLine($"Journal entries saved to {filename}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
            }
        }

        public void LoadFromFile()
        {
            Console.Write("Please enter the file name you would like to load from: ");
            string filename = Console.ReadLine();
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string dateString = reader.ReadLine();
                        string prompt = reader.ReadLine();
                        string response = reader.ReadLine();
                        string mood = reader.ReadLine();
                        Entry entry = new Entry(dateString, prompt, response, mood);
                        entries.Add(entry);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error loading entries from {filename}: {e.Message}");
            }
        }
    }
}
