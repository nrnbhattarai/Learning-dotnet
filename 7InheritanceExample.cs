// namespace InheritanceExample;
// class IShape 
// {
//    public float GetArea();
//    public float GetPerimeter();
// }
// class Rectangle : IShape
// {
//     public Rectangle(  float l, float b)
//     {
//         length = l;
//         width =b;
//     }
//     float length;
//     float width;
//     public float GetArea()=> length * width; // one liner called lamda Expression

//    public float GetPerimeter() => 2 * (length + width);

// }
//  class Square :Rectangle
//  { 
//     float side;
//  public Square(float s): base(s ,s)
//  {
   
//  }
//  class Circle 
//  {
//     public Circle(float r) => radius = r;
//  float radius;
//  public float GetArea()=> 3.14f * radius * radius; 
//    public double GetPerimeter() => 2 * 3.14f * radius;
//  }
//  }