using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_MovieLists
{
    class Program
    {
        static void Main(string[] args)

        {
            string continueAnswer;
            
        


            List<Movie> catalog = MovieGenre.getMovies();
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");

            do
            {

                Console.WriteLine("What category are you interested in?(enter a category)");
                string movieCategory = Console.ReadLine();

                int countNumberOfMoviesFound = 0;
                foreach (Movie individualMovie in catalog)
                {

                    if (individualMovie.Category.ToLower() == movieCategory.ToLower())
                    {
                        countNumberOfMoviesFound ++;

                        Console.WriteLine(individualMovie.Title);
                    }
                    if (countNumberOfMoviesFound == 10)
                    {
                      break;
                    }
                    
                }
                Console.WriteLine("Continue?(y/n):");
                continueAnswer = Console.ReadLine();
            } while (continueAnswer == "y");
        }
    }
    }

