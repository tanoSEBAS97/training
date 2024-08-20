namespace Training;

public class Comparators
{
    public class Player : IComparable<Player>
    {
        public string name { set; get; }
        public int score { set; get; }


        public int CompareTo(Player other)
        {
            if (-this.score.CompareTo(other.score) != 0)
            {
                return -this.score.CompareTo(other.score);
            }

            return this.name.CompareTo(other.name);
        }
    }


    /*public static void Main(string[] args)
    {
        List<Player> players = new List<Player>();
        int elements = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        do
        {
            string row = Console.ReadLine();
            String[] fields = row.Split(' ');
            string name = fields[0];
            int score = Convert.ToInt32(fields[1]);
            Player player = new Player();
            player.name = name;
            player.score = score;
            players.Add(player);
            i++;
        } while (i <= elements);

        players.Sort();


        foreach (var player in players)
        {
            Console.WriteLine($"{player.name} {player.score}");
        }
    }*/
}