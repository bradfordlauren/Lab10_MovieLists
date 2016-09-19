using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_MovieLists
{
    class MovieGenre
    {
        public static List <Movie> getMovies()
        {

            List <Movie> movieCatalog = new List<Movie>();

         movieCatalog.Add(new Movie("Citizen Kane", "drama"));
         movieCatalog.Add(new Movie("Casablanca", "drama"));
         movieCatalog.Add(new Movie("The Godfather", "drama"));
         movieCatalog.Add(new Movie("Gone With The Wind", "drama"));
         movieCatalog.Add(new Movie("Lawrence Of Arabia", "drama"));
         movieCatalog.Add(new Movie("The Wizard Of Oz", "musical"));
         movieCatalog.Add(new Movie("The Graduate", "drama"));
         movieCatalog.Add(new Movie("On The Waterfront", "drama"));
         movieCatalog.Add(new Movie("Schindler's List", "drama"));
         movieCatalog.Add(new Movie("Singin' In The Rain", "musical"));
         movieCatalog.Add( new Movie("It's A Wonderful Life", "drama"));
         movieCatalog.Add( new Movie("Sunset Boulevard", "drama"));
         movieCatalog.Add( new Movie("The Bridge On The River Kwai", "drama"));
         movieCatalog.Add( new Movie("Some Like It Hot", "drama"));
         movieCatalog.Add( new Movie("Star Wars", "scifi"));
         movieCatalog.Add( new Movie("All About Eve", "drama"));
         movieCatalog.Add( new Movie("The African Queen", "drama"));
         movieCatalog.Add( new Movie("Psycho", "horror"));
         movieCatalog.Add( new Movie("Chinatown", "drama"));
         movieCatalog.Add( new Movie("One Flew Over The Cuckoo's Nest", "drama"));
         movieCatalog.Add( new Movie("The Grapes Of Wrath", "drama"));
         movieCatalog.Add( new Movie("2001: A Space Odyssey", "scifi"));
         movieCatalog.Add( new Movie("The Maltese Falcon", "drama"));
         movieCatalog.Add( new Movie("Raging Bull", "drama"));
         movieCatalog.Add( new Movie("E.T. The extra-terrestrial", "scifi"));
         movieCatalog.Add( new Movie("Dr. Strangelove", "drama"));
         movieCatalog.Add( new Movie("Bonnie And Clyde", "drama"));
         movieCatalog.Add( new Movie("Apocalypse Now", "drama"));
         movieCatalog.Add( new Movie("Mr. Smith Goes to Washington", "drama"));
         movieCatalog.Add( new Movie("The Treasure Of The Sierra Madre", "drama"));
         movieCatalog.Add( new Movie("Annie Hall", "comedy"));
         movieCatalog.Add( new Movie("The Godfather Part II", "drama"));
         movieCatalog.Add( new Movie("High Noon", "drama"));
         movieCatalog.Add( new Movie("To Kill A Mockingbird", "drama"));
         movieCatalog.Add( new Movie("It Happened One Night", "drama"));
         movieCatalog.Add( new Movie("Midnight Cowboy", "drama"));
         movieCatalog.Add( new Movie("The Best Years Of Our Lives", "drama"));
         movieCatalog.Add( new Movie("Double Indemnity", "drama"));
         movieCatalog.Add( new Movie("Doctor Zhivago", "drama"));
         movieCatalog.Add( new Movie("North By Northwest", "drama"));
         movieCatalog.Add( new Movie("West Side Story", "musical"));
         movieCatalog.Add( new Movie("Rear Window", "drama"));
         movieCatalog.Add( new Movie("King Kong", "horror"));
         movieCatalog.Add( new Movie("The Birth Of A Nation", "drama"));
         movieCatalog.Add( new Movie("A Streetcar Named Desire", "drama"));
         movieCatalog.Add( new Movie("A Clockwork Orange", "scifi"));
         movieCatalog.Add( new Movie("Taxi Driver", "drama"));
         movieCatalog.Add( new Movie("Jaws", "horror"));
         movieCatalog.Add( new Movie("Snow White And The Seven Dwarfs", "animated"));
         movieCatalog.Add( new Movie("Butch Cassidy And The Sundance Kid", "drama"));
         movieCatalog.Add( new Movie("The Philadelphia Story", "drama"));
         movieCatalog.Add( new Movie("From Here To Eternity", "drama"));
         movieCatalog.Add( new Movie("Amadeus", "drama"));
         movieCatalog.Add( new Movie("All Quiet On The Western Front", "drama"));
         movieCatalog.Add( new Movie("The Sound Of Music", "musical"));
         movieCatalog.Add( new Movie("M*A*S*H", "comedy"));
         movieCatalog.Add( new Movie("The Third Man", "drama"));
         movieCatalog.Add( new Movie("Fantasia", "animated"));
         movieCatalog.Add( new Movie("Rebel Without A Cause", "drama"));
         movieCatalog.Add( new Movie("Raiders Of The Lost Ark", "drama"));
         movieCatalog.Add( new Movie("Vertigo", "drama"));
         movieCatalog.Add( new Movie("Tootsie", "comedy"));
         movieCatalog.Add( new Movie("Stagecoach", "drama"));
         movieCatalog.Add( new Movie("Close Encounters Of The Third Kind", "scifi"));
         movieCatalog.Add( new Movie("The Silence Of The Lambs", "horror"));
         movieCatalog.Add( new Movie("Network", "drama"));
         movieCatalog.Add( new Movie("The Manchurian Candidate", "drama"));
         movieCatalog.Add( new Movie("An American In Paris", "drama"));
         movieCatalog.Add( new Movie("Shane", "drama"));
         movieCatalog.Add( new Movie("The French Connection", "drama"));
         movieCatalog.Add( new Movie("Forrest Gump", "drama"));
         movieCatalog.Add( new Movie("Ben-Hur", "drama"));
         movieCatalog.Add( new Movie("Wuthering Heights", "drama"));
         movieCatalog.Add( new Movie("The Gold Rush", "drama"));
         movieCatalog.Add( new Movie("Dances With Wolves", "drama"));
         movieCatalog.Add( new Movie("City Lights", "drama"));
         movieCatalog.Add( new Movie("American Graffiti", "drama"));
         movieCatalog.Add( new Movie("Rocky", "drama"));
         movieCatalog.Add( new Movie("The Deer Hunter", "drama"));
         movieCatalog.Add( new Movie("The Wild Bunch", "drama"));
         movieCatalog.Add( new Movie("Modern Times", "drama"));
         movieCatalog.Add( new Movie("Giant", "drama"));
         movieCatalog.Add( new Movie("Platoon", "drama"));
         movieCatalog.Add( new Movie("Fargo", "drama"));
         movieCatalog.Add( new Movie("Duck Soup", "comedy"));
         movieCatalog.Add( new Movie("Mutiny On The Bounty", "drama"));
         movieCatalog.Add( new Movie("Frankenstein", "horror"));
         movieCatalog.Add( new Movie("Easy Rider", "drama"));
         movieCatalog.Add( new Movie("Patton", "drama"));
         movieCatalog.Add( new Movie("The Jazz Singer", "drama"));
         movieCatalog.Add( new Movie("My Fair Lady", "musical"));
         movieCatalog.Add( new Movie("A Place In The Sun", "drama"));
         movieCatalog.Add( new Movie("The Apartment", "drama"));
         movieCatalog.Add( new Movie("Goodfellas", "drama"));
         movieCatalog.Add( new Movie("Pulp Fiction", "drama"));
         movieCatalog.Add( new Movie("The Searchers", "drama"));
         movieCatalog.Add( new Movie("Bringing Up Baby", "drama"));
         movieCatalog.Add( new Movie("Unforgiven", "drama"));
         movieCatalog.Add( new Movie("Guess Who's Coming To Dinner", "drama"));
         movieCatalog.Add( new Movie("Yankee Doodle Dandy", "musical"));

                return movieCatalog;
          }
    }
}
