using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Computer> computers = new List<Computer>();
        Computer firstPC = new Computer("HP",
            new Component("ASROCK", 132.00m, "B85M BULK"),
            new Component("Intel", 200.00m, "Core i3-4130 (3M Cache, 3.40 GHz)"),
            new Component("KINGSTONE", 205.20m, "4GB, DDR3, 1866Mhzm PREDATOR"),
            new Component("ADATA", 406.20m, "SSD 200GB, SX1000L, SATA3"),
            new Component("NVIDIA", 1600.20m, "Quadro K4000, 3GB, GDDR5"));

        Computer secondPC = new Computer("Lenovo",
            new Component("GIGABYTE", 114.00m, "GA-H81M-D2V (rev. 1.0)"),
            new Component("AMD", 164.40m, "Athlon II X4 740 (4MB, 3.2 GHz)"),
            new Component("A-DATA", 167.25m, "8GB DDR3 1600MHz"),
            new Component("SEAGATE", 506.40m, "SSD, 240GB, 600 Pro, SATA 6Gb/s"),
            new Component("SAPPHIRE", 452.40m, "TOXIC R9 270X, 2GB, GDDR5"));

        computers.Add(firstPC);
        computers.Add(secondPC);

        computers = computers.OrderBy(c => c.totalComponentPrice).ToList();

        foreach (var computer in computers)
        {
            computer.PrintComputer();
        }
    }
}
