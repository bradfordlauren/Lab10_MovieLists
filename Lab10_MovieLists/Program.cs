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

            Movie[] movieCatalog = new Movie[100];

            movieCatalog[0] = new Movie("Citizen Kane", "drama");
            movieCatalog[1] = new Movie("Casablanca", "drama");
            movieCatalog[2] = new Movie("The Godfather", "drama");
            movieCatalog[3] = new Movie("Gone With The Wind", "drama");
            movieCatalog[4] = new Movie("Lawrence Of Arabia", "drama");
            movieCatalog[5] = new Movie("The Wizard Of Oz", "musical");
            movieCatalog[6] = new Movie("The Graduate", "drama");
            movieCatalog[7] = new Movie("On The Waterfront", "drama");
            movieCatalog[8] = new Movie("Schindler's List", "drama");
            movieCatalog[9] = new Movie("Singin' In The Rain", "musical");
            movieCatalog[10] = new Movie("It's A Wonderful Life", "drama");
            movieCatalog[11] = new Movie("Sunset Boulevard", "drama");
            movieCatalog[12] = new Movie("The Bridge On The River Kwai", "drama");
            movieCatalog[13] = new Movie("Some Like It Hot", "drama");
            movieCatalog[14] = new Movie("Star Wars", "scifi");
            movieCatalog[15] = new Movie("All About Eve", "drama");
            movieCatalog[16] = new Movie("The African Queen", "drama");
            movieCatalog[17] = new Movie("Psycho", "horror");
            movieCatalog[18] = new Movie("Chinatown", "drama");
            movieCatalog[19] = new Movie("One Flew Over The Cuckoo's Nest", "drama");
            movieCatalog[20] = new Movie("The Grapes Of Wrath", "drama");
            movieCatalog[21] = new Movie("2001: A Space Odyssey", "scifi");
            movieCatalog[22] = new Movie("The Maltese Falcon", "drama");
            movieCatalog[23] = new Movie("Raging Bull", "drama");
            movieCatalog[24] = new Movie("E.T. The extra-terrestrial", "scifi");
            movieCatalog[25] = new Movie("Dr. Strangelove", "drama");
            movieCatalog[26] = new Movie("Bonnie And Clyde", "drama");
            movieCatalog[27] = new Movie("Apocalypse Now", "drama");
            movieCatalog[28] = new Movie("Mr. Smith Goes to Washington", "drama");
            movieCatalog[29] = new Movie("The Treasure Of The Sierra Madre", "drama");
            movieCatalog[30] = new Movie("Annie Hall", "comedy");
            movieCatalog[31] = new Movie("The Godfather Part II", "drama");
            movieCatalog[32] = new Movie("High Noon", "drama");
            movieCatalog[33] = new Movie("To Kill A Mockingbird", "drama");
            movieCatalog[34] = new Movie("It Happened One Night", "drama");
            movieCatalog[35] = new Movie("Midnight Cowboy", "drama");
            movieCatalog[36] = new Movie("The Best Years Of Our Lives", "drama");
            movieCatalog[37] = new Movie("Double Indemnity", "drama");
            movieCatalog[38] = new Movie("Doctor Zhivago", "drama");
            movieCatalog[39] = new Movie("North By Northwest", "drama");
            movieCatalog[40] = new Movie("West Side Story", "musical");
            movieCatalog[41] = new Movie("Rear Window", "drama");
            movieCatalog[42] = new Movie("King Kong", "horror");
            movieCatalog[43] = new Movie("The Birth Of A Nation", "drama");
            movieCatalog[44] = new Movie("A Streetcar Named Desire", "drama");
            movieCatalog[45] = new Movie("A Clockwork Orange", "scifi");
            movieCatalog[46] = new Movie("Taxi Driver", "drama");
            movieCatalog[47] = new Movie("Jaws", "horror");
            movieCatalog[48] = new Movie("Snow White And The Seven Dwarfs", "animated");
            movieCatalog[49] = new Movie("Butch Cassidy And The Sundance Kid", "drama");
            movieCatalog[50] = new Movie("The Philadelphia Story", "drama");
            movieCatalog[51] = new Movie("From Here To Eternity", "drama");
            movieCatalog[52] = new Movie("Amadeus", "drama");
            movieCatalog[53] = new Movie("All Quiet On The Western Front", "drama");
            movieCatalog[54] = new Movie("The Sound Of Music", "musical");
            movieCatalog[55] = new Movie("M*A*S*H", "comedy");
            movieCatalog[56] = new Movie("The Third Man", "drama");
            movieCatalog[57] = new Movie("Fantasia", "animated");
            movieCatalog[58] = new Movie("Rebel Without A Cause", "drama");
            movieCatalog[59] = new Movie("Raiders Of The Lost Ark", "drama");
            movieCatalog[60] = new Movie("Vertigo", "drama");
            movieCatalog[61] = new Movie("Tootsie", "comedy");
            movieCatalog[62] = new Movie("Stagecoach", "drama");
            movieCatalog[63] = new Movie("Close Encounters Of The Third Kind", "scifi");
            movieCatalog[64] = new Movie("The Silence Of The Lambs", "horror");
            movieCatalog[65] = new Movie("Network", "drama");
            movieCatalog[66] = new Movie("The Manchurian Candidate", "drama");
            movieCatalog[67] = new Movie("An American In Paris", "drama");
            movieCatalog[68] = new Movie("Shane", "drama");
            movieCatalog[69] = new Movie("The French Connection", "drama");
            movieCatalog[70] = new Movie("Forrest Gump", "drama");
            movieCatalog[71] = new Movie("Ben-Hur", "drama");
            movieCatalog[72] = new Movie("Wuthering Heights", "drama");
            movieCatalog[73] = new Movie("The Gold Rush", "drama");
            movieCatalog[74] = new Movie("Dances With Wolves", "drama");
            movieCatalog[75] = new Movie("City Lights", "drama");
            movieCatalog[76] = new Movie("American Graffiti", "drama");
            movieCatalog[77] = new Movie("Rocky", "drama");
            movieCatalog[78] = new Movie("The Deer Hunter", "drama");
            movieCatalog[79] = new Movie("The Wild Bunch", "drama");
            movieCatalog[80] = new Movie("Modern Times", "drama");
            movieCatalog[81] = new Movie("Giant", "drama");
            movieCatalog[82] = new Movie("Platoon", "drama");
            movieCatalog[83] = new Movie("Fargo", "drama");
            movieCatalog[84] = new Movie("Duck Soup", "comedy");
            movieCatalog[85] = new Movie("Mutiny On The Bounty", "drama");
            movieCatalog[86] = new Movie("Frankenstein", "horror");
            movieCatalog[87] = new Movie("Easy Rider", "drama");
            movieCatalog[88] = new Movie("Patton", "drama");
            movieCatalog[89] = new Movie("The Jazz Singer", "drama");
            movieCatalog[90] = new Movie("My Fair Lady", "musical");
            movieCatalog[91] = new Movie("A Place In The Sun", "drama");
            movieCatalog[92] = new Movie("The Apartment", "drama");
            movieCatalog[93] = new Movie("Goodfellas", "drama");
            movieCatalog[94] = new Movie("Pulp Fiction", "drama");
            movieCatalog[95] = new Movie("The Searchers", "drama");
            movieCatalog[96] = new Movie("Bringing Up Baby", "drama");
            movieCatalog[97] = new Movie("Unforgiven", "drama");
            movieCatalog[98] = new Movie("Guess Who's Coming To Dinner", "drama");
         movieCatalog[99] = new Movie("Yankee Doodle Dandy", "musical");

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");

            do
            {

           Console.WriteLine("What category are you interested in?(enter a category)");
            string movieCategory = Console.ReadLine();

            foreach (Movie movie in movieCatalog)
            {if (movie.Category == movieCategory)
                { Console.WriteLine(movie.Title); }

            }
            Console.WriteLine("Continue?(y/n):");
             continueAnswer =  Console.ReadLine();
            } while (continueAnswer == "y");
        }
    }
    }

