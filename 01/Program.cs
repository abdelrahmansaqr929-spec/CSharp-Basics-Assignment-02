using _01;
#region _1 
object obj = new Book() { title = "quran", pages = 604 };
Console.WriteLine(obj );
Console.WriteLine(obj .ToString ());
Console.WriteLine(obj.Equals(obj));
Console.WriteLine(obj.GetHashCode());
Console.WriteLine(obj.GetType());
#endregion

#region _2
/*that is compile time error 
you shoulde remove double quotes
to be int pages = 464 ;
 */
#endregion

#region _3
try
{
    int i = 10;
    int j = 0;
    int k = i / j;

}
catch (DivideByZeroException)
{
    Console.WriteLine("you can not divide by zero ");
}
finally
{
    Console.WriteLine("done ");
}

#endregion


#region _4
int pages = 300;
double p = pages;
Console.WriteLine(p);
#endregion


#region _5
double price = 49.99;
int intprice = (int)price;
Console.WriteLine(intprice);
#endregion

