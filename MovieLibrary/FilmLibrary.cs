public class FilmLibrary : IFilmLibrary
{
    private List<Film> _films = null;
    public FilmLibrary()
    {
        _films = new List<Film>();
    }
    public void AddFilm(Film film)
    {
        if(film != null)
        {
            _films.Add(film);
        }
    }
    public bool RemoveFilm(string title)
    {
        bool flag = false;
        for (int i = 0; i < _films.Count; i++)
        {
            if (_films[i].Title == title)
            {
                _films.RemoveAt(i);
                flag = true;
                break;
            }
        }
        return flag;
        
    }
    public List<Film> GetFilms()
    {
        return  _films;
    }

    public List<Film> SearchFilms(string query)
    {
        List<Film> result = new List<Film>();
        foreach (Film film in _films)
        {
            if (film.Title.Contains(query) || film.Director.Contains(query))
            {
                result.Add(film);
            }
        }
        return result;
    }
    
    public int GetTotalFilmCount()
    {
        return _films.Count;
    }

}