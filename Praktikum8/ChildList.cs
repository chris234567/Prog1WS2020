using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum8
{
    class ChildList
    {
        int numberOfChildren;
        Child[] children;

        public int NumberOfChildren { get; }

        public ChildList(int numberOfChildren)
        {
            this.numberOfChildren = numberOfChildren;
            children = new Child[numberOfChildren];
        }

        public int NumberOfKindChildren // how many children are kind ( not naughty )
        {
            get
            {
                int num = 0;

                foreach (var child in children)
                {
                    if (child.WasKind)
                        num++;
                }
                return num;
            }
        }

        public void AddChild(Child child) // adds child if theres room in ChildList
        {
            for (int i = 0; i < children.Length; i++)
            {
                if (children[i] == null)
                {
                    children[i] = child;
                    return;
                }
            }
        }

        public int CountChildrenWithWish(string wish) // HasWish() on every child in ChildList
        {
            int counter = 0;

            foreach (var child in children)
                if (child.HasWish(wish))
                    counter++;

            return counter;
        }
    }
}
