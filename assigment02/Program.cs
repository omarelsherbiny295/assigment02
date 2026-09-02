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
            //Book book = new Book();
            //book.title = "programming";
            //book.pages = 100;

            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetType());

            #endregion

            #region question3
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    Console.WriteLine(x / y);
            //}
            //catch
            //{
            //    Console.WriteLine("can not divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("done");
            //}
            #endregion

            #region question4
            //int pages = 300;

            //double dpages = Convert.ToDouble(pages);
            //Console.WriteLine(dpages);


            #endregion

            #region question5

            double price = 49.99;
            int intprice =(int)price;

            Console.WriteLine(intprice);


            #endregion
        }
    }

}