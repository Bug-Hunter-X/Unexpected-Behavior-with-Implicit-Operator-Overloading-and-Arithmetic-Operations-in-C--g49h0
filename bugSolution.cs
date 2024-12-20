public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }

    public static MyClass operator +(MyClass a, int b)
    {
        return new MyClass(a.MyProperty + b);
    }

    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.MyProperty + b.MyProperty);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int num = obj1;    // Implicit conversion from MyClass to int
        MyClass obj2 = new MyClass(20);
        MyClass obj3 = obj2 + 5; // Now works correctly
        Console.WriteLine(obj3.MyProperty); // Output: 25
        MyClass obj4 = obj2 + obj1; // Adding two MyClass objects
        Console.WriteLine(obj4.MyProperty); //Output: 30
    }
}