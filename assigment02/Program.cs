namespace assigment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ques.1
            //Book book = new Book();
            //book.title = "programming";
            //book.pages = 100;

            //object obj = book;
            //Console.WriteLine(obj);

            #endregion

            #region question2
            Book book = new Book();
            book.title = "programming";
            book.pages = 100;

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetType());

            #endregion
        }
    }
}
