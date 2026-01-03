// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

FilmLibrary library = new FilmLibrary();
do
{
    Console.WriteLine("--------------------------- MENU -------------------------------------");
    Console.WriteLine("1. Add Film");
    Console.WriteLine("2. Remove Film");
    Console.WriteLine("3. Search Film");
    Console.WriteLine("4. Show all films");
    Console.WriteLine("5. Total Film Count");
    Console.WriteLine("6. Exit");
    Console.WriteLine("------------------------------------------------------------------------");

    Console.Write("Enter your choice: ");
    int choice = Int32.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();

            Console.Write("Enter director: ");
            string director = Console.ReadLine();

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Film film = new Film(title, director, year);
            library.AddFilm(film);

            Console.WriteLine("Film Added Successfully!!");

            break;
        }
        case 2:
        {
            Console.Write("Enter title to remove: ");
            string removeTitle = Console.ReadLine();

            bool removed = library.RemoveFilm(removeTitle);
            if (removed)
            {
                Console.WriteLine("Film removed.");
            }
            else
            {
                Console.WriteLine("Film not exist");
            }
            break; 
        }
        case 3:
        {
            Console.Write("Enter search word: ");
            string query = Console.ReadLine();

            var results = library.SearchFilms(query);
            if (results.Count == 0)
            {
                Console.WriteLine("Film not found");
            }
            else
            {
                foreach(var film in results)
                {
                    Console.WriteLine($"{film.Title} - {film.Director} ({film.Year})");   
                }
            }
            break;
        }
        case 4:
        {
            var films = library.GetFilms();
            if (films.Count == 0)
            {
                Console.WriteLine("No files in library.");
            }
            else
            {
                foreach(var film in films)
                {
                    Console.WriteLine($"{film.Title} - {film.Director} ({film.Year})");   
                }  
            }
            break;
        }
        case 5:
        {
            Console.WriteLine("Total Films: "+library.GetTotalFilmCount());
            break;
        }
        case 6:
        {
            Console.WriteLine("Thank you! Exiting...");
            return;   
        }
        default:
        {
            Console.WriteLine("Invalid Choice. Try Again");
            break; 
        }
        
    }
}
while(true);