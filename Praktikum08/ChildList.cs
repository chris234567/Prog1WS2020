using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Praktikum8
{
    class ChildList
    {
        int numberOfChildren;
        Child[] children;

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

        public int CountChildrenWithWish(string wish) // HasWish() for every child in ChildList
        {
            int counter = 0;

            foreach (var child in children)
                if (child.HasWish(wish))
                    counter++;

            return counter;
        }

        public void SaveChildList(ChildList childList, string path)
        {
            var myWriter = new StreamWriter(path, true);

            for (int child = 0; child < children.Length; child++)
            {
                myWriter.WriteLine(Child.Serialize(childList.children[child])); // writes one line for every child in childList
            }

            myWriter.Close();
        }

        public static ChildList ReadChildList(string path)
        {
            var myReader = new StreamReader(path);

            var child = myReader.ReadLine();
            var lines = 0;

            while (child != null) // count lines
            {
                lines++;
                child = myReader.ReadLine();
            }

            var childList = new ChildList(lines);

            myReader = new StreamReader(path); // reopen file
            child = myReader.ReadLine();

            while (child != null)
            {
                childList.AddChild(Child.Deserialize(child));
                
                child = myReader.ReadLine();
            }
            myReader.Close();

            return childList;
        }
    }
}
