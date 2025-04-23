using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsBinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Display(Node node)
        {
            if (node != null)
                Console.Write($"{node.key.ToString()} ");
            else
                Console.Write("null ");
        }

        public void Process(Node node)
        {
            Display(node);
        }

        // Node-Left-Right (NLR)
        public void PreOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                Process(aRoot);
                PreOrder(aRoot.left);
                PreOrder(aRoot.right);
            }
        }

        // Left-Node-Right (LNR)
        public void InOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                InOrder(aRoot.left);
                Process(aRoot);
                InOrder(aRoot.right);
            }
        }

        // Left-Right-Node (LRN)
        public void PostOrder(Node aRoot)
        {
            if (aRoot != null)
            {
                PostOrder(aRoot.left);
                PostOrder(aRoot.right);
                Process(aRoot);
            }
        }

        public void CountAndSumAllNodes(Node aRoot, ref int count, ref int sum)
        {
            if (aRoot != null)
            {
                count++;
                sum += aRoot.key;
                CountAndSumAllNodes(aRoot.left, ref count, ref sum);
                CountAndSumAllNodes(aRoot.right, ref count, ref sum);
            }
        }

        public int CalTreeHeight(Node aRoot)
        
        {
            if (aRoot == null)
                return -1;
            else
            {
                int leftHeight = CalTreeHeight(aRoot.left);
                int rightHeight = CalTreeHeight(aRoot.right);
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        public Node Search(int X)
        {
            Node curNode = root;
            while (X != curNode.key)
            {
                if (X < curNode.key)
                    curNode = curNode.left;
                else
                    curNode = curNode.right;
                if (curNode == null)
                    return null;
            }
            return curNode;
        }

        public int FindMax(Node aRoot)
        {
            int max = aRoot.key;
            if (aRoot.right == null)
                return max;
            else
                return FindMax(aRoot.right);
        }

        public int FindMin(Node aRoot)
        {
            int min = aRoot.key;
            if (aRoot.left == null)
                return min;
            else
                return FindMin(aRoot.left);
        }

        public bool Add(int X)
        {
            bool result = true;
            Node newNode = new Node(X);
            if (root == null)
            {
                root = newNode;
                return result;
            }
            Node curNode = root;
            Node parentNode;
            while (true)
            {
                parentNode = curNode;
                if (X < curNode.key)
                {
                    curNode = curNode.left;
                    if (curNode == null)
                    {
                        parentNode.left = newNode;
                        return result;
                    }
                }
                else if (X > curNode.key)
                {
                    curNode = curNode.right;
                    if (curNode == null)
                    {
                        parentNode.right = newNode;
                        return result;
                    }
                }
                else
                {
                    result = false;
                    return result;
                }
            }
        }

        public Node GetSubsNode(Node removeNode)
        {
            Node subsParent = removeNode;
            Node subsNode = removeNode;
            Node curNode = removeNode.right;
            while (curNode != null)
            {
                subsParent = subsNode;
                subsNode = curNode;
                curNode = curNode.left;
            }
            if (subsNode != removeNode.right)
            {
                subsParent.left = subsNode.right;
                subsNode.right = removeNode.right;
            }
            return subsNode;
        }

        public bool Remove(int X)
        {
            Node curNode = root;
            Node parentNode = root;
            bool isLeftChild = true;
            while (curNode.key != X)
            {
                parentNode = curNode;
                if (X < curNode.key)
                {
                    isLeftChild = true;
                    curNode = curNode.left;
                }
                else
                {
                    isLeftChild = false;
                    curNode = curNode.right;
                }
                if (curNode == null)
                    return false;
            }
            if ((curNode.left == null) && (curNode.right == null))
            {
                if (curNode == root)
                    root = null;
                else if (isLeftChild)
                    parentNode.left = null;
                else
                    parentNode.right = null;
            }
            else if (curNode.right == null)
            {
                if (curNode == root)
                    root = curNode.left;
                else if (isLeftChild)
                    parentNode.left = curNode.left;
                else
                    parentNode.right = curNode.left;
            }
            else if (curNode.left == null)
            {
                if (curNode == root)
                    root = curNode.right;
                else if (isLeftChild)
                    parentNode.left = curNode.right;
                else
                    parentNode.right = curNode.right;
            }
            else
            {
                Node subsNode = GetSubsNode(curNode);
                if (curNode == root)
                    root = subsNode;
                else if (isLeftChild)
                    parentNode.left = subsNode;
                else
                    parentNode.right = subsNode;
                subsNode.left = curNode.left;
            }
            return true;
        }
    }
}
