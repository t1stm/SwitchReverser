using System.IO;
using System.Linq;

namespace SwitchReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program is retarded
            for (var i = 0; i < args.Length; i++)
            {
                var yes = File.ReadAllLines(args[i]);
                var newString = yes.Select(line => line.Split("=>")).Aggregate("", (current, split) => current + $"{split[1].Trim().Replace(',', (char) 0)} => {split[0].Trim()},\n");
                File.WriteAllText($"./out{i}.txt", newString);
            }
        }
    }
}
