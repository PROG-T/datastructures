public class TreeNode{
    public int Value{set; get;}
    public TreeNode RightChild{set; get;}
    public TreeNode LeftChild{set; get;}
public TreeNode(int value)
{
    Value = value;
}

public int MaxDepth(TreeNode root){
if(root == null){return 0}
var maxLeftDepth = MaxDepth(root.LeftChild);
var maxRightDepth = MaxDepth(root.RightChild)
return 1 + Math.Max(maxLeftDepth, maxRightDepth)
}
}