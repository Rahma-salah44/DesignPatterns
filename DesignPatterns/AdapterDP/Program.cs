using AdapterDP;
using AdapterDP.Adaptee;
using AdapterDP.Target;

Console.WriteLine("***Adapter Pattern Demo***\n");


Rectangle r = new Rectangle(20, 10);
Console.WriteLine("Area of Rectangle is :{0} Square unit", r.CalculateAreaOfRectangle());


Triangle t = new Triangle(20, 10);
Console.WriteLine("Area of Triangle is :{0} Square unit", t.CalculateAreaOfTriangle());
IRectangle adapter = new TraingleAdapter(t);
//Passing a Triangle instead of a Rectangle
Console.WriteLine("Area of Triangle using the triangle adapter is :{0}Square unit", GetArea(adapter));
/*GetArea(RectInterface r) method does not know that through 
TriangleAdapter, it is getting a Triangle instead of a Rectangle*/
static double GetArea(IRectangle r)
{
    r.AboutRectangle();
    return r.CalculateAreaOfRectangle();
}