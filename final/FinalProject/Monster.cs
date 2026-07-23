class Monster
    {
        public string Type { get; set; }
        public string Weakness { get; set; }
        public int HP { get; set; }
        public int AttackPower { get; set; }
        public int Difficulty { get; set; }
        public string Description { get; set; }

        public bool IsDefeated() => HP <= 0;
    }