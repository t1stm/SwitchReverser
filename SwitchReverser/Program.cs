using System.IO;
using System.Linq;

namespace SwitchReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program is retarded
            var yes = File.ReadAllLines("../../../NewFile1.txt");
            var newString = yes.Select(line => line.Split("=>")).Aggregate("", (current, split) => current + $"{split[1].Trim().Replace(',', (char) 0)} => {split[0].Trim()},\n");
            File.WriteAllText("./out.txt", newString);
        }
    }
}
