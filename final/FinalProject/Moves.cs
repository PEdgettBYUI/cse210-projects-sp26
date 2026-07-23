static class Moves
    {
        public static int Punch(Monster m) => 10;
        public static int Kick(Monster m) => 12;
        public static int Strike(Monster m) => 15;

        public static int FireMagic(Monster m) => m.Weakness == "Fire" ? 25 : 10;
        public static int IceMagic(Monster m) => m.Weakness == "Ice" ? 25 : 10;
        public static int LightMagic(Monster m) => m.Weakness == "Light" ? 25 : 10;

        public static int Sword(Monster m) => 20;
        public static int Gun(Monster m) => 30;

        public static int Potion(Player p)
        {
            p.HP += 20;
            Console.WriteLine("You healed 20 HP!");
            return 0;
        }
    }