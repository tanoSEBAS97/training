namespace LeetCode;



public class MaximunDepthOfBinaryTree
{
    /*public static void Main(string[] args)
    {
        TreeNode fifteen = new TreeNode(15);
        TreeNode seven = new TreeNode(7);
        TreeNode twenty = new TreeNode(20, fifteen, seven);

        TreeNode nine = new TreeNode(9);
        TreeNode three = new TreeNode(3, nine, twenty);
        int result = MaxDepth(three);
    }*/


    public static int MaxDepth(TreeNode root)
    {
        return testing(root, 0);
    }

    public static int testing(TreeNode? node, int aux)
    {
        if (node is not null)
        {
            aux++;
            int leftSide = testing(node.left, 0);
            int rightSide = testing(node.right, 0);
            aux += leftSide > rightSide ? leftSide : rightSide;
            return aux;
        }

        return aux;
    }
}