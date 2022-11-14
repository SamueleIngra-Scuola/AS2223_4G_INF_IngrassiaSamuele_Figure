namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la figura di cui vuoi calcolare Area e Perimetro");
            Console.WriteLine("1) Quadrato\n2) Rettangolo\n3) Cerchio");
            Console.Write("Scegli: ");
            int chosenShape = int.Parse(Console.ReadLine());

            switch(chosenShape)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}