using ShapeLIB;
namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chosenShape;
            Console.WriteLine("Inserisci la figura di cui vuoi calcolare Area e Perimetro");
            Console.WriteLine("1) Quadrato\n2) Rettangolo\n3) Cerchio");

            do
            {
                Console.Write("Scegli: ");
                chosenShape = int.Parse(Console.ReadLine());
            } while (chosenShape <= 0 || chosenShape > 3);
            

            switch(chosenShape)
            {
                case 1:
                    Console.Write("Inserisci la lunghezza del lato: ");
                    double edge = double.Parse(Console.ReadLine());

                    Square squareShape = new Square(edge);

                    Console.WriteLine($"\nArea: {squareShape.Area} | Perimetro: {squareShape.Perimeter}");
                    break;
                case 2:
                    Console.Write("Inserisci la lunghezza della base: ");
                    double baseEdge = double.Parse(Console.ReadLine());

                    Console.Write("Inserisci la lunghezza dell\'altezza: ");
                    double height = double.Parse(Console.ReadLine());

                    Rectangle rectangleShape = new Rectangle(baseEdge, height);

                    Console.WriteLine($"\nArea: {rectangleShape.Area} | Perimetro: {rectangleShape.Perimeter}");
                    break;
                case 3:
                    Console.Write("Inserisci la lunghezza del raggio: ");
                    double radius = double.Parse(Console.ReadLine());

                    Circle circleShape = new Circle(radius);

                    Console.WriteLine($"\nArea: {circleShape.Area} | Circonferenza: {circleShape.Perimeter}");
                    break;
            }
        }
    }
}