using System;

namespace Rabbit_Race
{
    public static class Factory
    {
        private static Random Random = new Random();
        private static int newNumber;
        public static int RabbitCount { get; set; } = 0;
        public static int RaceTrackLength { get; set; }
        public static int Location { get; set; } = 0;

        public static int Number()
        {
            return newNumber = Random.Next(1, 50);
        }


        // decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Punter01();
                case 1:
                    return new Punter02();
                case 2:
                    return new Punter03();

                default:
                    return new Punter01();
            }
        }

        public static Rabbit GetARabbit(int id)
        {
            switch (id)
            {
                case 0:
                    return new Rabbit01();
                case 1:
                    return new Rabbit02();
                case 2:
                    return new Rabbit03();
                case 3:
                    return new Rabbit04();

                default:
                    return new Rabbit01();
            }
        }
    }
}
