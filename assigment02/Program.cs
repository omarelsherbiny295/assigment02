namespace assigment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ques.1
            Book book = new Book();
            book.title = "programming";
            book.pages = 100;

            object obj = book;
            Console.WriteLine(obj);

            #endregion




        }
    }
}
