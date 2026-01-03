public interface IFilmLibrary
{
    void AddFilm(Film film);
    bool RemoveFilm(string title);
    List<Film> GetFilms();
    List<Film> SearchFilms(string query);
    int GetTotalFilmCount();
}