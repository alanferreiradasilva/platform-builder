using PlatformBuilder.Abstractions.Entities;

namespace PlatformBuilder.Abstractions.Services
{
    public interface IBinarySearchTreeService
    {
        TreeNode GetNode();
        string FindWithValue(TreeNode root, int value);
    }
}
