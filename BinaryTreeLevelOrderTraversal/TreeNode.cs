using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeLevelOrderTraversal
{
    public class TreeNode
    {
        private int _val;

        public int val
        {
            get { return _val; }
            set { _val = value; }
        }
        public TreeNode left;
        public TreeNode right;

        //private TreeNode _left;

        //public TreeNode left
        //{
        //    get { return _left; }
        //    set { _left = value; }
        //}

        //private TreeNode _right;

        //public TreeNode right
        //{
        //    get { return _right; }
        //    set { _right = value; }
        //}

        TreeNode(Int32 x) { val = x; }
    }
}
