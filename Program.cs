using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rasmda berilgan struktura asosida klasslarni yarating,
            //bunda rasmdagi ko'rsatkichning uchi tomondagi
            //class va interface lardan  voris olish nazarda tutilgan.
            var circle = new Circle();
            circle.Color = "blue";
            circle.Raduis = 12.2m;
            circle.Area();
            circle.GetColor();

            var rectangle = new Rectangle();
            rectangle.Color = "red";
            rectangle.Width = 10;
            rectangle.Length = 10;
            rectangle.Area();
            rectangle.GetColor();


        }
    }
    

}