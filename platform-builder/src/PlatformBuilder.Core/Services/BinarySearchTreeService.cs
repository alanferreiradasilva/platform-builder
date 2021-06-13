using PlatformBuilder.Abstractions.Entities;
using PlatformBuilder.Abstractions.Services;

namespace PlatformBuilder.Core.Services
{
    public class BinarySearchTreeService : IBinarySearchTreeService
    {
        public TreeNode GetNode()
        {
            return new TreeNode
            {
                Name = "n2",
                Value = 2,
                Left = new TreeNode
                {
                    Name = "n1",
                    Value = 1
                },
                Right = new TreeNode
                {
                    Name = "n3",
                    Value = 3
                }
            };
        }

        public string FindWithValue(TreeNode root, int value)
        {
            if (root == null)
            {
                return string.Empty;
            }
            else
            {
                if (root.Value > value)
                {
                    root = root.Left;
                    return FindWithValue(root, value);
                }
                else if (root.Value < value)
                {
                    root = root.Right;
                    return FindWithValue(root, value);
                }
                else if (root.Value == value)
                {
                    return root.Name;
                }
                else
                {
                    return string.Empty;
                }
            }
        }
    }
}
