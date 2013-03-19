using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _6_BinarySearchTree.BST
{
    public class BinarySearchTree<T> : IEnumerable<T>, ICloneable
        where T : IComparable<T>
    {
        private class TreeNode
        {
            public TreeNode Parent { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }
            public T Key { get; set; }
        }

        private TreeNode root;

        /// <summary>
        /// Gets the number of keys that are currently stored in the BinarySearchTree instance.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Creates an empty BinarySearchTree instance.
        /// </summary>
        public BinarySearchTree()
        {
            Count = 0;
        }

        /// <summary>
        /// Creates new BinarySearch containing the specified keys.
        /// </summary>
        /// <param name="keys">A Collection of the keys to be inserted.</param>
        public BinarySearchTree(IEnumerable<T> keys)
            : this()
        {
            foreach (var key in keys)
            {
                this.Insert(key);
            }
        }

        /// <summary>
        /// Determines weather the specified key exists in the current instance of the BinarySearchTree.
        /// </summary>
        /// <param name="key">The key to look for.</param>
        /// <returns>True if the specified key was found.</returns>
        public bool ContainsKey(T key)
        {
            return GetNode(key) != null;
        }

        /// <summary>
        /// Finds and returns the TreeNode with the specifeid key.
        /// </summary>
        /// <param name="key">The key to look for. The key cannot be null.</param>
        /// <returns>The node with the specified key.</returns>
        private TreeNode GetNode(T key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(
                    "Cannot get node with a null key");
            }

            if (Count == 0)
            {
                return null;
            }

            TreeNode current = root;
            while (key.CompareTo(current.Key) != 0)
            {
                if (key.CompareTo(current.Key) < 0)
                {
                    if (current.Left == null)
                    {
                        return null;
                    }
                    current = current.Left;
                }
                else if (key.CompareTo(current.Key) > 0)
                {
                    if (current.Right == null)
                    {
                        return null;
                    }
                    current = current.Right;
                }
            }

            return current;
        }

        /// <summary>
        /// Inserts new key into the BinarySearchTree.
        /// </summary>
        /// <param name="key">The key to be added to the BinarySearchTree. The key cannot be null</param>
        public void Insert(T key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert null into the BinarySeachTree");
            }

            if (root == null && Count == 0)
            {
                root = new TreeNode { Key = key };
                Count++;
                return;
            }

            if (!ContainsKey(key))
            {
                TreeNode current = root;
                while (true)
                {
                    if (key.CompareTo(current.Key) < 0)
                    {
                        if (current.Left == null)
                        {
                            current.Left = new TreeNode { Key = key, Parent = current };
                            Count++;
                            return;
                        }
                        current = current.Left;
                    }
                    else if (key.CompareTo(current.Key) > 0)
                    {
                        if (current.Right == null)
                        {
                            current.Right = new TreeNode { Key = key, Parent = current };
                            Count++;
                            return;
                        }
                        current = current.Right;
                    }
                }
            }
        }

        /// <summary>
        /// Removes the specified key from the BinarySearchTree.
        /// </summary>
        /// <param name="key">The key to remove from the BinarySearchTree. The key cannot be null.</param>
        public void Remove(T key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(
                    "Cannot remove null from the BinarySearchTree");
            }

            if (Count == 0)
            {
                throw new InvalidOperationException(
                    "Cannot remove element from an empty tree.");
            }

            TreeNode current = GetNode(key);
            if (current == null)
            {
                return;
            }
            TreeNode parent = current.Parent;

            // Current node has two children.
            if (current.Left != null && current.Right != null)
            {
                TreeNode predecessor = root.Left;
                while (predecessor.Right != null)
                {
                    predecessor = predecessor.Right;
                }

                // Swap current and predecessor.
                T temp = current.Key;
                current.Key = predecessor.Key;
                predecessor.Key = temp;

                current = predecessor;
                parent = current.Parent;

                // At this point the BST property is violated,
                // but only for the node we are about to delete.
            }

            // Current node has no children.
            if (current.Left == null && current.Right == null)
            {
                if (current != root)
                {
                    if (parent.Left == current)
                    {
                        parent.Left = null;
                    }
                    else if (parent.Right == current)
                    {
                        parent.Right = null;
                    }
                    Count--;
                }
                else
                {
                    root = null;
                    Count = 0;
                }
            }
            // Current node has only one child.
            else if (current.Left == null ^ current.Right == null)
            {
                TreeNode next = (current.Left == null) ? current.Right : current.Left;
                if (current != root)
                {
                    if (parent.Left == current)
                    {
                        parent.Left = next;
                    }
                    else if (parent.Right == current)
                    {
                        parent.Right = next;
                    }

                    next.Parent = parent;
                    Count--;
                }
                else 
                {
                    root = (root.Left == null) ? root.Right : root.Left;
                }
            }
        }

        /// <summary>
        /// Gets the maximum key from the BinarySearchTree.
        /// </summary>
        public T Max
        {
            get
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException(
                        "Cannot calculate max from an empty tree.");
                }

                TreeNode current = root;
                while (current.Right != null)
                {
                    current = current.Right;
                }

                return current.Key;
            }
        }

        /// <summary>
        /// Gets the minimum key.
        /// </summary>
        public T Min
        {
            get
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException(
                        "Cannot calculate min from an empty tree.");
                }

                TreeNode current = root;
                while (current.Left != null)
                {
                    current = current.Left;
                }

                return current.Key;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            // DFS pre-order traversal
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode current = root;
            while (s.Count != 0 || current != null)
            {
                if (current != null)
                {
                    s.Push(current);
                    yield return current.Key;
                    current = current.Left;
                }
                else
                {
                    current = s.Pop();
                    current = current.Right;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public object Clone()
        {
            BinarySearchTree<T> newTree = new BinarySearchTree<T>();
            foreach (var k in this)
            {
                newTree.Insert(k);
            }

            return newTree;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var key in this)
            {
                result.AppendFormat("{0} ", key);
            }

            return result.ToString();
        }

        public static bool operator ==(BinarySearchTree<T> first, BinarySearchTree<T> second)
        {
            return BinarySearchTree<T>.Equals(first, second);
        }

        public static bool operator !=(BinarySearchTree<T> first, BinarySearchTree<T> second)
        {
            return !(BinarySearchTree<T>.Equals(first, second));
        }

        public override bool Equals(object obj)
        {

            BinarySearchTree<T> other = obj as BinarySearchTree<T>;

            if (other == null)
            {
                return false;
            }

            if (this.Count != other.Count)
            {
                return false;
            }

            // Pre-order DFS traversal for both trees.
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            TreeNode current1 = this.root;
            TreeNode current2 = other.root;
            while ((s1.Count != 0 || current1 != null) && (s2.Count != 0 || current2 != null))
            {
                if (current1 != null && current2 != null)
                {
                    s1.Push(current1);
                    s2.Push(current2);
                    if (current1.Key.CompareTo(current2.Key) != 0)
                    {
                        return false;
                    }
                    current1 = current1.Left;
                    current2 = current2.Left;
                }
                else
                {
                    current1 = s1.Pop();
                    current2 = s2.Pop();
                    current1 = current1.Right;
                    current2 = current2.Right;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            int result = 0;
            foreach (var k in this)
            {
                result ^= k.GetHashCode();
            }

            return result;
        }
    }
}
