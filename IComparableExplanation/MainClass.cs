namespace IComparableExplanation
{
    class MainClass
    {
        static void Main()
        {
            Student[] arr = new Student[5];
            arr[0] = new Student(40);
            arr[1] = new Student(20);
            arr[2] = new Student(30);
            arr[3] = new Student(10);
            arr[4] = new Student(50);

            Utilities.Sort(arr);
            foreach(Student s in arr)
            {
                Console.WriteLine(s);
            }
            Employee[] arr2 = new Employee[5];
            arr2[0] = new Employee(40000);
            arr2[1] = new Employee(200000);
            arr2[2] = new Employee(300000);
            arr2[3] = new Employee(100000);
            arr2[4] = new Employee(500000);
            Utilities.Sort(arr2);
            foreach(Employee s in arr2)
            {
                Console.WriteLine(s);
            }
        }
    }
}