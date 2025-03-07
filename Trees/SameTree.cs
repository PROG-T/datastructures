public class TreeNode{
    public int Value{set; get;}
    public TreeNode RightChild{set; get;}
    public TreeNode LeftChild{set; get;}
public TreeNode(int value)
{
    Value = value;
}

//Dept first approach :recursive call of method
public bool IsSameTree(TreeNode one, TreeNode two){
if(one == null && two == null){return true;}
if(one == null || two == null){return false;}
if (one.Value != two.value){return false;}

return IsSameTree(one.LeftChild, two.LeftChild) && IsSameTree(one.RightChild, two.RightChild);
}
}