namespace Training;

public class FormingAMagicSquare
{
    /*public static void Main(string[] args)
    {
        var hola = new List<List<int>>()
        {
            new List<int>() { 4, 9, 2 },
            new List<int>() { 3, 5, 7 },
            new List<int>() { 8, 1, 5 }
        };


        formingMagicSquare(hola);
    }*/

    public static int formingMagicSquare(List<List<int>> s)
    {
        int[,,] possibilities =
        {
            { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } },
            { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } },
            { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } },
            { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } },
            { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } },
            { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } },
            { { 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } },
            { { 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } }
        };

        int totalCost = Int32.MaxValue;

        int temp = 0;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int currentvalue = s[j][k];

                    temp += Math.Abs(possibilities[i, j, k] - currentvalue);
                }
            }

            if (temp < totalCost)
            {
                totalCost = temp;
            }

            temp = 0;
        }


        return totalCost;
    }
}