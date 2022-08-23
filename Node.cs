using System;
namespace BST
{
    class BinaryNode<T> where T : IComparable<T>
    {
        T NodeData;
        public BinaryNode<T> leftTree { get; set; }
        public BinaryNode<T> rightTree { get; set; }

        bool result = false;
        int leftCount = 0;
        int rightCount = 0;

        public BinaryNode(T NodeData)
        {
            this.NodeData = NodeData;
            leftTree = null;
            rightTree = null;
        }
        public void Insert(T item)
        {
            T currentNodeValue = NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (leftTree == null)
                    leftTree = new BinaryNode<T>(item);
                else
                    leftTree.Insert(item);
            }
            else
            {
                if (rightTree == null)
                    rightTree = new BinaryNode<T>(item);
                else
                    rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (leftTree != null)
            {
                leftTree.Display();
            }
            Console.WriteLine(NodeData.ToString());
            if (rightTree != null)
            {
                rightTree.Display();
            }
        }
        public void Size()
        {
            Console.WriteLine(" \nSize of BST is " + (1 + leftCount + rightCount) + "\n");
        }
        public bool ifExists(T element, BinaryNode<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("\n(UC-3), Element searched in BST :" + node.NodeData + "\n");
                return true;
            }
            else
                Console.WriteLine("(UC-2), Element {0} is added in BST ", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                ifExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                ifExists(element, node.rightTree);
            return result;
        }
    }
}