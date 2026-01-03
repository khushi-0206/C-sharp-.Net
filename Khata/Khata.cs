public class Khata
{
    private Dictionary<string, int> record;
    public Khata()
    {
        this.record = new Dictionary<string, int>();
    }
    public void AddItem(string item, int amount)
    {
        if (record.ContainsKey(item))
        {
            record[item] += amount;   // update amount
        }
        else
        {
            record.Add(item, amount); // add new item
        }
    }
    public int getTotal()
    {
        int sumOfAmount = 0;
        foreach(var item in record)
        {
            sumOfAmount = sumOfAmount + item.Value;
        }
        return sumOfAmount;
    }
    public int getRepeatAmount()
    {
        return record.Keys.Count;
    }
}