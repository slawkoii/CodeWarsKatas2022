namespace CodeWarsKatas2022
{
    public class Hero
    {
        public string Name;
        public string Position = "00";
        public float Health = 100;
        public float Damage = 5;
        public int Experience = 0;


        public Hero(string name = "Hero")
        {
            Name = name;
        }

        public static int Move(int position, int roll) => position + 2 * roll;
    }


}
