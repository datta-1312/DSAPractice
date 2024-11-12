public class BalancedBinaryTree
{
    public bool IsBalanced(TreeNode root) {
        return CheckBalance(root) == 0;
    }

    private int CheckBalance(TreeNode root)
    {
        if(root is null)
        {
            return 0;
        }

        int left = CheckBalance(root.left);
        int right = CheckBalance(root.right);
        return Math.Abs(right - left);
    }
}