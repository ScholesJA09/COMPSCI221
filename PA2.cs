namespace COMPSCI221
{
    static class PA2
    {
        //Task 2/4
        static int GetLineCount(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found", path);
            }

            int count = 0;
            using StreamReader reader = new StreamReader(path);

            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                count++;
            }

            return count;
        }

        static pokemon[] ReadPokemonsFromFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found", path);
            }

            int lineCount = GetLineCount(path);

            pokemon[] pokemons = new pokemon[lineCount - 1];

            using StreamReader reader = new StreamReader(path);
            reader.ReadLine();

            for (int i = 0; i < pokemons.Length; i++)
            {
                string line = reader.ReadLine();
                string[] cols = line.Split(',');

                int dexNum = int.Parse(cols[0]);
                string name = cols[1];
                string type1 = cols[2];
                string type2 = cols[3];
                int hp = int.Parse(cols[4]);
                int attack = int.Parse(cols[5]);
                int defense = int.Parse(cols[6]);
                int special = int.Parse(cols[7]);
                int speed = int.Parse(cols[8]);

                pokemons[i] = new pokemon(dexNum, name, type1, type2, hp, attack, defense, special, speed);
            }

            return pokemons;
        }

        static void WritePokemonToFile(pokemon pokemons, string sortedPath)
        {
            using StreamWriter writer = new StreamWriter(sortedPath, true);
            string line = string.Join(',', pokemons.DexNum, pokemons.Name, pokemons.Type1, pokemons.Type2, pokemons.Hp, pokemons.Attack, pokemons.Defense, pokemons.Special, pokemons.Speed);
            writer.WriteLine(line);
        }

        static void Main()
        {
            string path = "First-Generation-Pokemon.csv";

            pokemon[] pokemons = ReadPokemonsFromFile(path);

            //Task 3/4 - Sort by Hp Descending
            Console.WriteLine("Sorting Data...");
            for (int i = 0; i < pokemons.Length - 1; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < pokemons.Length; j++)
                {
                    if (pokemons[j].Hp > pokemons[min_index].Hp)
                {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    pokemon temp = pokemons[i];
                    pokemons[i] = pokemons[min_index];
                    pokemons[min_index] = temp;
                }
            }
            Console.WriteLine("Done!\n");

            for (int i = 0; i < pokemons.Length; i++)
            {
                Console.WriteLine(pokemons[i]);
            }

            //Task 4/4
            string sortedPath = "First-Generation-Pokemon-Sorted.csv";
            Console.WriteLine("\nWriting data to CSV file...");

            using StreamWriter writer = new StreamWriter(sortedPath);
            writer.WriteLine("Dex #,Name,Type 1,Type 2,HP,Attack,Defence,Special,Speed");
            writer.Close();

            for (int i = 0; i < pokemons.Length; i++)
            {
                WritePokemonToFile(pokemons[i], sortedPath);
            }
            Console.WriteLine("Done!");
        }
    }
}
