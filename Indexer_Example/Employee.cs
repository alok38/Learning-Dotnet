using System;

namespace Indexer_Example
{
    class Employee
    {
        string[] name = new string[size];
        int[] id = new int[size];
        public static int size = 5;

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return name[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < size)
                {
                    name[index] = value;
                }
            }
        }
        public int this[string index]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (name[i] == index)
                    {
                        return id[i];
                    }
                }
                return 0;
            }
            set
            {
                for (int i = 0; i < size; i++)
                {
                    if (name[i] == index)
                    {
                        id[i] = value;
                    }
                }
            }
        }
    }
}
