using System;
using System.Reflection.Metadata.Ecma335;

namespace Day5Assingnment;

public class Desktop:Computer
{
    //fields

    public int monitorSize;
    public int powerSupplyVolt;

    //child class constructor 
    public Desktop(string processor, int ramSize,int hardDiskSize, int graphicCard,int monitorSize, int powerSupplyVolt) :
        base(processor, ramSize,hardDiskSize, graphicCard)
    {
        this.monitorSize = monitorSize;
        this.powerSupplyVolt = powerSupplyVolt;
    }

    //Desktop price calculation function
    public double DesktopPriceCalculation()
    {
        int processorCost = 0;
        switch (processor)
        {
            case "i3":
            {
                processorCost = 1500;
                break;  
            }
            case "i5":
            {
                processorCost = 3000;
                break;  
            }
            case "i7":
            {
                processorCost = 4500;
                break;  
            }
        }
        double desktopPrice = processorCost + (ramSize * 200) + (hardDiskSize * 1500) + (graphicCard * 2500) + (powerSupplyVolt * 20) + (monitorSize * 250);
        return desktopPrice;

    }
}
