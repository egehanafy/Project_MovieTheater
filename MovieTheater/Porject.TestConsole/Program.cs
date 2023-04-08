using Project.BLL.Concrete;
using System;

namespace Porject.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieRepository movieRepo = new MovieRepository();

            foreach (var item in movieRepo.GetAll())
            {
                Console.WriteLine(item.MovieName);
            }
        }
    }
}
