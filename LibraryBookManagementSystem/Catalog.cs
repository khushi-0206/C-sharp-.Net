public class Catalog<T> where T : Book
{
    private List<T> _items = new List<T>();
    private HashSet<string> _isbnSet = new HashSet<string>();
    private SortedDictionary<string, List<T>> _genreIndex = new SortedDictionary<string,List<T>>();

    public bool AddItem(T item)
    {
        if(item ==null || string.IsNullOrWhiteSpace(item.ISBN))
        {
            return false;
        }
        if(_isbnSet.Contains(item.ISBN)) return false;

        _items.Add(item);
        _isbnSet.Add(item.ISBN);
        if (!_genreIndex.ContainsKey(item.Genre))
        {
            _genreIndex[item.Genre] = new List<T>();
        }
        _genreIndex[item.Genre].Add(item);
        return true;
    }

    public List<T> this[string genre]
    {
        get
        {
            if(string.IsNullOrWhiteSpace(genre)) return new List<T>();
            if(_genreIndex.TryGetValue(genre, out var books))
            {
                return books;
            }
            return new List<T>();

        }
    }

    public IEnumerable<T> FindBooks(Func<T, bool> predicate)
    {
        if(predicate==null) return Enumerable.Empty<T>();
        return _items.Where(predicate);
    }
    
}