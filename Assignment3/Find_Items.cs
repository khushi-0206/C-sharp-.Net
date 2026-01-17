using System;
using System.Collections.Generic;
using System.Linq;
public class FindItems
{
	private SortedDictionary<string,long> itemDetails = null;

	public FindItems(SortedDictionary<string,long> itemDetails)
	{
		this.itemDetails = new SortedDictionary<string,long>(itemDetails);
	}

	public SortedDictionary<string,long> FindItemDetails(long soldCount)
	{
		SortedDictionary<string,long> items = new SortedDictionary<string,long>();
		foreach(var item in itemDetails)
		{
			if(item.Value == soldCount)
			{
				items.Add(item.Key,item.Value);
			}
		}
		
		return items;	
	}
	
	public List<String> FindMinAndMaxSoldItems()
	{
		List<string> minMaxSoldItemNames = new List<string>();
		long minSold = long.MaxValue;
		long maxSold = long.MinValue;
		foreach(var item in itemDetails)
		{
			if(item.Value < minSold)
			{
				minSold = item.Value;
			}
			if(item.Value > maxSold) 
			{
				maxSold = item.Value;
			}		
			
		}
		
		string minItemName = "";
		string maxItemName = "";
		foreach(var item in itemDetails)
		{
			if(item.Value == minSold)
			{
				minItemName = item.Key;
			}
			if(item.Value == maxSold)
			{
				maxItemName = item.Key;
			}
		}
		minMaxSoldItemNames.Add(minItemName);
		minMaxSoldItemNames.Add(maxItemName);
		return minMaxSoldItemNames;		
	}
		
	public Dictionary<string,long> SortByCount()
	{
		Dictionary<string, long> sorted = new Dictionary<string, long>();
		var items = itemDetails.OrderBy(i => i.Value);
		foreach(var item in items)
		{
			sorted.Add(item.Key,item.Value);
		}
		return sorted;
	}			
}

class Program
{
	public static void Main()
	{
		SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();
		Console.Write("Enter how many items you want to add: ");
		int n = Int32.Parse(Console.ReadLine());
		while(n>0)
		{
			Console.Write("Enter item name: ");
			string itemName = Console.ReadLine();
			Console.Write("Enter item sold count: ");
			long count = long.Parse(Console.ReadLine());
			itemDetails.Add(itemName, count);
			n--;
		}
		FindItems fObj = new FindItems(itemDetails);
		
		do
		{
			Console.WriteLine("1. Search item\n2. Minimum and Maximum sold item names\n3. Sorted List of items\n4.Exit");
			Console.Write("Enter your choice: ");
			int choice = Int32.Parse(Console.ReadLine());
			switch(choice)
			{
				case 1:
				{
					Console.Write("Enter sold count: ");
					long soldCount = long.Parse(Console.ReadLine());
					SortedDictionary<string,long> result = fObj.FindItemDetails(soldCount);
					foreach(var item in result)
					{
						Console.WriteLine($"Item: {item.Key}\t Count: {item.Value}");
					}
					break;
				}
				case 2:
				{
					var minMaxItemName = fObj.FindMinAndMaxSoldItems();
					foreach(var item in minMaxItemName)
					{
						Console.WriteLine(item);
					}
					break;
				}
				case 3:
				{
					var sortedDict = fObj.SortByCount();
					foreach(var item in sortedDict)
					{
						Console.WriteLine($"Item: {item.Key}\t Count: {item.Value}");
					}
					break;
				}
				case 4:
				{
					Console.WriteLine("Exiting the program");
					return;
				}
				default:
				{
					Console.WriteLine("Invalid choice");
					break;
				}
					
			}
		}while(true);			
		
	}
}
	