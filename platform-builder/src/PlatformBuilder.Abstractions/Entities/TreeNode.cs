namespace PlatformBuilder.Abstractions.Entities
{
    public class TreeNode
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }


        public TreeNode() { }
        public TreeNode(int value, TreeNode left, TreeNode right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
