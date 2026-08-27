using _01;
#region _1 
object obj = new Book() { title = "quran", pages = 604 };
Console.WriteLine(obj );
Console.WriteLine(obj .ToString ());
Console.WriteLine(obj.Equals(obj));
Console.WriteLine(obj.GetHashCode());
Console.WriteLine(obj.GetType());
#endregion


