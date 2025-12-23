using System;

namespace Day5Assingnment;

public class Laptop:Computer
{
    //fields
    int displaySize;
    int batteryVolt;

    //constructor
    public Laptop(string processor,int ramSize, int hardDiskSize, int graphicCard, int displaySize, int batteryVolt):
        base(processor, ramSize, hardDiskSize, graphicCard)
    {
        this.displaySize = displaySize;
        this.batteryVolt = batteryVolt;
    }

    //Laptop price calcultion function

    public double LaptopPriceCalculation()
    {
        int processorCost = 0;
        switch (processor)
        {
            case "i3":
            {
                processorCost = 2500;
                break;  
            }
            case "i5":
            {
                processorCost = 5000;
                break;  
            }
            case "i7":
            {
                processorCost = 6500;
                break;  
            }
        }
        double desktopPrice = processorCost + (ramSize * 200) + (hardDiskSize * 1500) + (graphicCard * 2500) + (batteryVolt * 20) + (displaySize * 250);
        return desktopPrice;

    }
}
