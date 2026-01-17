using System;
using System.Collections.Generic;
using System.Linq;

class Movie
{
	public string Title{get;set;}
	public string Artist{get;set;}
	public string Genre{get;set;}
	public int Ratings{get;set;}
}

	
class Program
{
	public static List<Movie> MovieList = new List<Movie>()
		{
			new Movie{Title="Inception", Artist = "Leonardo DiCaprio", Genre = "Thriller", Ratings = 8},
			new Movie{Title="Titanic", Artist = "Kate Winslet", Genre = "Romance", Ratings = 7},
			new Movie{Title="The Dark Knight", Artist = "Heath Ledger", Genre = "Action", Ratings = 9},
			new Movie{Title="3Idiots", Artist = "Aamir Khan", Genre = "Comedy", Ratings = 6},
			new Movie{Title="Interstellar", Artist = "Matthew McConaughey", Genre = "Adventure", Ratings = 7},
		};

	public static void Main()
	{

		do
		{
			System.Console.WriteLine("1. Add new Movie\n2. View movie By Genre\n3. View Movies By Ratings\n4. Exit..");
			System.Console.WriteLine("Enter your choice: ");
			int choice = Int32.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
				{
					System.Console.Write("Enter the movies details: ");
					string details = Console.ReadLine();
					AddMovie(details);
					System.Console.WriteLine();
					break;
				}
				case 2:
				{
					System.Console.Write("Enter Genre: ");
					string genre = Console.ReadLine();
					var moviesByGenre = ViewMoviesByGenre(genre);
					if (moviesByGenre.Count==0)
					{
							System.Console.WriteLine($"No movies found in genre '{genre}'");
					}
					else
					{
						foreach(var movie in moviesByGenre)
						{
							System.Console.WriteLine($"Title: {movie.Title}\tArtist: {movie.Artist}\tGenre: {movie.Genre}\tRatings: {movie.Ratings}");		
						}
		
					}
					
					break;
				}
				case 3:
				{
					var moviesByRatings = ViewMoviesByRatings();
					foreach(var movie in moviesByRatings)
					{
						System.Console.WriteLine($"Title: {movie.Title}\tArtist: {movie.Artist}\tGenre: {movie.Genre}\tRatings: {movie.Ratings}");		
					}
					
					break;
				}
				case 4:
				{
					return;			
				}
				default:
				{
					System.Console.WriteLine("Invalid choice");
					break;	
				}

			}
		}while(true);
		
	}
	
	public static void AddMovie(string movieDetails)
	{
		string[] details = movieDetails.Split(',');
		Movie movieDetail = new Movie(){
			Title = details[0],
			Artist = details[1],
			Genre = details[2],
			Ratings = int.Parse(details[3])
			};
		MovieList.Add(movieDetail);
	}
	
	public static List<Movie> ViewMoviesByGenre(string genre)
	{
		var movies = MovieList.Where(m => m.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
		
		return movies;
	}
	
	public static List<Movie> ViewMoviesByRatings()
	{
		List<Movie> sortedList = MovieList.OrderBy(m => m.Ratings).ToList();
		return sortedList;
	}
}