namespace GenericSamples
{
    internal class Program
    {
        static Conjunto<int> students = new Conjunto<int>(5); //5 indica la cantidad de elementos del arreglo
        static Conjunto<Book> Estante = new Conjunto<Book>(10);
        static Conjunto<Persona> Person = new Conjunto<Persona>(5);
        static void Main(string[] args)
        {
            students.ADD(20220268);
            students.ADD(20220269);
            students.ADD(20230200);
            students.Print();
            //students.DROP();
            //students.Print();

            //libros
            Book MyBook = new Book();
            MyBook.ISBN = "1";
            MyBook.Name = "2do. Libro Nombre";
            MyBook.ID = 201;
            Estante.ADD(MyBook);
            Estante.Print();
           

            
        }
    }
}