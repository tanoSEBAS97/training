using System.Xml.Schema;

namespace Training;

public class Graph
{
    private Dictionary<int, List<int>> adjacentList = new();
    private Dictionary<int, int> cachedResults = new();

    public void AddEdge(int s, int n)
    {
        if (adjacentList.TryGetValue(s, out var list))
        {
            list.Add(n);
        }
        else
        {
            adjacentList.Add(s, new List<int>() { n });
        }
    }

    public int BFS(int s)
    {
        int initialValue = s;
        if (cachedResults.TryGetValue(s, out var result))
        {
            return result;
        }

        HashSet<int> visited = new HashSet<int>();
        Queue<int> queue = new Queue<int>();

        visited.Add(s);
        queue.Enqueue(s);
        while (queue.Any())
        {
            s = queue.Dequeue();
            if (cachedResults.TryGetValue(s, out var test))
            {
                cachedResults.Add(initialValue, test);
                return test;
            }   

            List<int> local = adjacentList[s];
            foreach (var number in local)
            {
                if (!visited.Contains(number))
                {
                    visited.Add(number);
                    queue.Enqueue(number);
                }
            }
        }

        cachedResults.Add(initialValue, visited.Count);

        return visited.Count;
    }
}

public class Components_in_a_graph
{
    /*public static void Main(string[] args)
    {
        List<List<int>> aux = new List<List<int>>()
        {
            new() { 1, 6 },
            new() { 2, 7 },
            new() { 3, 8 },
            new() { 4, 9 },
            new() { 2, 6 },
        };
        List<int> result = componentsInGraph(aux);
        Console.WriteLine(result);
    }*/

    public static List<int> componentsInGraph(List<List<int>> gb)
    {
        Graph graph = new Graph();

        foreach (var list in gb)
        {
            graph.AddEdge(list[0], list[1]);
            graph.AddEdge(list[1], list[0]);
        }

        int max, min;
        max = min = graph.BFS(gb[0][0]);

        foreach (var list in gb)
        {
            int result = graph.BFS(list[0]);
            if (result > 1)
            {
                min = Math.Min(result, min);
            }

            max = Math.Max(result, max);
        }

        return new List<int>() { min, max };
    }
}