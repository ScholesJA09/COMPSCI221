namespace COMPSCI221
{
    //Task 1/4
    class pokemon
    {
        private int dexNum;
        private string name;
        private string type1;
        private string type2;
        private int hp;
        private int attack;
        private int defense;
        private int special;
        private int speed;

        public pokemon(int dexNum, string name, string type1, string type2, int hp, int attack, int defense, int special, int speed)
        {
            this.dexNum = dexNum;
            this.name = name;
            this.type1 = type1;
            this.type2 = type2;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.special = special;
            this.speed = speed;
        }

        public override string ToString()
        {
            if (type2 != "")
            {
                return $"#{dexNum}: {name}, Type: {type1}/{type2}, HP: {hp}, Attack: {attack}, Defense: {defense}, Special: {special}, Speed: {speed}";
            }
            else
            {
                return $"#{dexNum}: {name}, Type: {type1}, HP: {hp}, Attack: {attack}, Defense: {defense}, Special: {special}, Speed: {speed}";
            }
            
        }

        //We are not in generation 1 anymore so the pokemon and stats from then should not be changed
        public int DexNum
        {
            get => dexNum;
        }

        public string Name
        {
            get => name;
        }

        public string Type1
        {
            get => type1;
        }

        public string Type2
        {
            get => type2;
        }

        public int Hp
        {
            get => hp;
        }

        public int Attack
        {
            get => attack;
        }

        public int Defense
        {
            get => defense;
        }

        public int Special
        {
            get => special;
        }

        public int Speed
        {
            get => speed;
        }
    }
}
