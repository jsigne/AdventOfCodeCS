using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.DayTwo
{
    public class CubeGame
    {
        private int redCubeNumber { get; set; }
        private int greenCubeNumber { get; set; }
        private int blueCubeNumber { get; set; }
        public CubeGame(int redCubeNumber, int greenCubeNumber, int blueCubeNumber)
        {
            this.redCubeNumber = redCubeNumber;
            this.greenCubeNumber = greenCubeNumber;
            this.blueCubeNumber = blueCubeNumber;
        }

        public int processRecords(List<string> records)
        {
            return 0;
        }


        private bool IsSetImpossible(Set set)
        {
            return set.red > redCubeNumber && set.green > greenCubeNumber && set.blue > blueCubeNumber;
        }

        private bool IsGamePossible(GameRecord gameRecord)
        {
            foreach(Set set in gameRecord.sets)
            {
                if (IsSetImpossible(set))
                {
                    return false;
                }
            }
            return true;
        }

        private class Set()
        {
            public int red {get; private set;}
            public int blue {get; private set;}
            public int green {get; private set;}
        }

        private class GameRecord()
        {
            public int id;
            public List<Set> sets {get; set;}
        }

        public static void Main(string[] args)
        {
            CubeGame cubeGame = new(12, 13, 14);

            Console.WriteLine("Sum of ids of valid game records");

            string[] cubeGameRecordsDocument = File.ReadAllLines("ressources\\CubeGameRecords.txt");

            Console.WriteLine(cubeGame.processRecords(cubeGameRecordsDocument.ToList()));
        }
    }
}
