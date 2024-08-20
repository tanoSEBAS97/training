using System.Collections.Specialized;

namespace LeetCode;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class AverageLevelsBinaryTree
{
    /*public IList<double> AverageOfLevels(TreeNode root)
    {
        List<double> averages = new List<double>();

        Queue<KeyValuePair<TreeNode, int>> queue = new Queue<KeyValuePair<TreeNode, int>>();
        int currentLevel = 0;
        queue.Enqueue(new KeyValuePair<TreeNode, int>(root, currentLevel));
        int oldLevel = 0;

        while (queue.Count != 0)
        {
            KeyValuePair<TreeNode, int> keyValuePair = queue.Dequeue();

            if (oldLevel != keyValuePair.Value)
            {
                averages.Add(0);
                oldLevel = keyValuePair.Value;
            }


            TreeNode tempNode = keyValuePair.Key;

            currentLevel++;
            // Enqueue left child
            if (tempNode.left != null)
            {
                queue.Enqueue(new KeyValuePair<TreeNode, int>(tempNode.left, currentLevel));
            }

            // Enqueue right child
            if (tempNode.right != null)
            {
                queue.Enqueue(new KeyValuePair<TreeNode, int>(tempNode.right, currentLevel));
            }
        }
    }*/
}