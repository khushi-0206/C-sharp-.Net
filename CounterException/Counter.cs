public class Counter
{
    int[] data;
    public Counter(int[] data)
    {
        this.data = new int[data.Length];
        for(int i = 0; i < data.Length; i++)
        {
            this.data[i] = data[i];
        }
    }
    public string GetCount()
    {
        int zerosCount = 0;
        int onesCount = 0;
        for(int i = 0; i < data.Length; i++)
        {
            if (data[i] == 0)
            {
                zerosCount++;
            }
            else
            {
                onesCount++;
            }
        }
        if((zerosCount%2==0) && (onesCount % 2 == 0))
        {
            return "Great";
        }
        else if((zerosCount%2!=0) && (onesCount % 2 != 0))
        {
            return "Great";
        }
        else
        {
            if (zerosCount % 2 != 0)
            {
                throw new ExceptionZero("Zero comes odd times");
            }
            if(onesCount % 2 != 0)
            {
                throw new ExceptionOne("One comes odd times");
            }
            return " ";
        }

    }


}