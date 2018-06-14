using System;
using System.Collections.Generic;

namespace Module9Workshop
{
    public class TreeNode
    {
        public TreeNode ParentNode;
        public int NodeValue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 9.3 (*) *Дан граф (см. рисунок), у вершин которого может быть только один вход и несколько выходов. Кроме того вершина может не иметь входа или выходов. Данный граф описывается
                последовательностью (вершина выход – вершина вход), которая дается в произвольном порядке.
                Например, для данного графа (5,2), (1,6),(5,4),(3,5),(5,7)
                Написать программу, которая сортирует вершины по уровню вложенности
                3-я вершина
                1, 5 вершина
                6,4,7,2 
            */
            TreeNode[] array = new TreeNode[3];

            int[,] values = { { 5, 2 }, { 1, 6 }, { 5, 4 }, { 3, 5 }, { 5, 7 }, { 3, 1 } };
            var tree = new List<TreeNode>();
            for (int i = 0; i < values.GetLength(0); i++)
            {
                TreeNode node = tree.Find(n => n.NodeValue == values[i, 0]);
                if (node == null)
                {
                    node = new TreeNode { NodeValue = values[i, 0] };
                    tree.Add(node);
                }

                TreeNode childNode = tree.Find(n => n.NodeValue == values[i, 1]);
                if (childNode == null)
                {
                    childNode = new TreeNode { NodeValue = values[i, 1] };
                    tree.Add(childNode);
                }

                childNode.ParentNode = node;
            }

            foreach (TreeNode item in tree)
            {
                int level = 0;
                TreeNode parentNode = item;
                do
                {
                    parentNode = parentNode.ParentNode;
                    level++;
                }
                while (parentNode != null);
                Console.WriteLine($"{item.NodeValue}; level={level}");
            }
        }
    }
}
