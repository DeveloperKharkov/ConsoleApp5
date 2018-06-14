using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10ClassWork
{
    public class TreeNode
    {
        public TreeNode ParentNode;
        public int NodeValue;
    }

    class Program
    {
        static public void Main(string[] args)
        {
            var nodeList = new List<TreeNode>();

            int[,] treeNodes = { {5, 2}, {1, 6}, {5, 4}, {3, 5}, {5, 7}, {3, 1} };

            for (int i = 0; i < treeNodes.GetLength(0); i++)
            {
                TreeNode node = nodeList.Find(x => x.NodeValue == treeNodes[i, 1]);

                if (node == null)
                {
                    node = new TreeNode { NodeValue = treeNodes[i, 1] };
                    nodeList.Add(node);
                }

                TreeNode parentNode = nodeList.Find(x => x.NodeValue == treeNodes[i, 0]);

                if (parentNode == null)
                {
                    parentNode = new TreeNode { NodeValue = treeNodes[i, 0] };
                    nodeList.Add(parentNode);
                }

                node.ParentNode = parentNode;
            }

            foreach (var node in nodeList)
            {
                TreeNode parentNode = node;
                int level = 0;
                do
                {
                    parentNode = parentNode.ParentNode;
                    level++;
                }
                while (parentNode != null);

                Console.WriteLine($"Node={node.NodeValue}, level={level}");
            }
        }
    }
}
