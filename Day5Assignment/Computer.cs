using System;
using System.Dynamic;

namespace Day5Assingnment;

public class Computer
{
    //fields
    public string processor;
    public int ramSize;
    public int hardDiskSize;
    public int graphicCard;
    
    //parent class constructor
    public Computer(string processor, int ramSize,int hardDiskSize, int graphicCard)
    {
        this.processor = processor;
        this.ramSize = ramSize;
        this.hardDiskSize = hardDiskSize;
        this.graphicCard = graphicCard;
    }

    
}
