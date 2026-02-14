public class BookUtility
{
    public Book GetBookDetails(string id)
    {
        Book bObj = new Book();
        if (Program.bookDetails.ContainsKey(id))
        {
            bObj = Program.bookDetails[id]; 
        }
        return bObj;
    }

    public Book UpdateBookPrice(string id,int price)
    {
        Book bObj = new Book();
        if (Program.bookDetails.ContainsKey(id))
        {
            bObj = Program.bookDetails[id]; 
            bObj.Price = price;
        }
        return bObj;
    } 

    public Book UpdateBookStock(string id, int stock)
    {
        Book bObj = new Book();
        if (Program.bookDetails.ContainsKey(id))
        {
            bObj = Program.bookDetails[id]; 
            bObj.Stock = stock;
        }
        return bObj;
        
    }
}