public class BTDiameter {
    int diameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        PreOrderTraversal(root);
        return diameter;
    }
    private int PreOrderTraversal(TreeNode root)
    {
        if(root == null)
            return 0;
        
        if(root.left == null && root.right == null)
        {
            return 1;
        }
        
        diameter = PreOrderTraversal(root.left);

        diameter += PreOrderTraversal(root.right);
        
        return diameter;
    }

    public TreeNode SearchBST(TreeNode root, int val) {
        if(root == null || val == root.val)
            return root;
        return val < root.val ? SearchBST(root.left,val) : SearchBST(root.right,val);
    }
}

public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0) {
         this.val = val;
     }
 }