    class Player
    {
        public int HP { get; set; } = 100;
        public int Points { get; set; } = 0;

        public void RewardPoints(int difficulty)
        {
            Points += difficulty * 10;
            Console.WriteLine($"You earned {difficulty * 10} points! Total: {Points}");
        }
    }