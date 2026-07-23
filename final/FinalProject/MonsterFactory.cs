static class MonsterFactory
    {
        public static List<Monster> CreateMonsters()
        {
            return new List<Monster>()
            {
                new Monster { Type="Goblin", Weakness="Fire", HP=40, AttackPower=5, Difficulty=1, Description="A small green creature." },
                new Monster { Type="Ice Golem", Weakness="Light", HP=60, AttackPower=10, Difficulty=2, Description="A giant frozen monster." },
                new Monster { Type="Dark Mage", Weakness="Light", HP=70, AttackPower=12, Difficulty=3, Description="A sorcerer of shadows." },
                new Monster { Type="Fire Dragon", Weakness="Ice", HP=100, AttackPower=20, Difficulty=4, Description="A massive dragon breathing fire." },
                new Monster { Type="Ancient Titan", Weakness="Strike", HP=150, AttackPower=25, Difficulty=5, Description="A colossal stone warrior." }
            };
        }
    }