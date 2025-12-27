using System.Dynamic;

class PatientBill
{
    private string billId;
    private bool hasInsurance;
    private decimal consultationFee;
    private decimal labCharges;
    private decimal medicineCharges;

    public string BillId
    {
        get
        {
            return billId;
        }
        set
        {
            if (value != null)
            {
                billId = value;
            }
        }
    }
    public string PatientName{get;set;}
    public bool HasInsurance
    {
        get
        {
            return hasInsurance;
        }
        set
        {
            hasInsurance = value;
        }
    }
    public decimal ConsultationFee
    {
        get
        {
            return consultationFee;
        }
        set
        {
            if (value > 0)
            {
                consultationFee = value;
            }
        }
    }
    public decimal LabCharges
    {
        get
        {
            return labCharges;
        }
        set
        {
            if (value >= 0)
            {
                labCharges = value;
            }
        }
    }
    public decimal MedicineCharges
    {
        get
        {
            return medicineCharges;
        }
        set
        {
            if (value >= 0)
            {
                medicineCharges = value;
            }
        }
    }  
    public static PatientBill lastBill; 
    public static bool hasLastBill;   
    
    public decimal GrossAmount
    {
        get
        {
            return ConsultationFee + LabCharges + MedicineCharges;
        }
        
    }
    public decimal DiscountAmount
    {
        get
        {
            return GrossAmount * 10/100;
        }
        
    }
    public decimal FinalPayable
    {
        get
        {
            return GrossAmount - DiscountAmount;
        }
    }
    
}
