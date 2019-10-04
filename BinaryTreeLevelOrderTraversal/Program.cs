using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeLevelOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static IList<IList<Int32>> levelOrder(TreeNode root)
        {
            IList<IList<Int32>> result = new List<IList<Int32>>();//Used instead of List<List<Int32>> result = new ArrayList<>() in Java

            if (root == null)
            {
                return result;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();//Used in palce of creating a queue with 
            //linked list 
            queue.Enqueue(root); //Used in place of offer in java 
            while (queue.Count!=0)//Used in place of (!queue.isEmpty()) in java
            {
                int levelSize = queue.Count();//Used instead of queue.size in java
                List<Int32> level = new List<Int32>();//Used instead of List<List<Int32>> level = new ArrayList<>() in Java
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left!=null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Add(level);
            }
            return result;
        }
    }
}
