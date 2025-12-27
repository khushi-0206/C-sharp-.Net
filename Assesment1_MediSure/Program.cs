// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.Marshalling;

while (true)
{
    Console.WriteLine("-------------MENU-------------");
    Console.WriteLine("1. Create New Bill\n2.View Last Bill\n3.Clear Last Bill\n4.Exit");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter choice: ");
    int choice = Int32.Parse(Console.ReadLine());
    PatientBill pbObj = null;
    switch (choice)
    {
        case 1:
        {
            Console.Write("Enter Bill id: ");
            pbObj = new PatientBill();
            pbObj.BillId = Console.ReadLine();

            Console.Write("Enter Pateint Name: ");
            pbObj.PatientName = Console.ReadLine();

            Console.Write("Has Insurance {y/n}: ");
            pbObj.HasInsurance = bool.Parse(Console.ReadLine());

            Console.Write("Enter Consultation fee: ");
            pbObj.ConsultationFee = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Lab charges: ");
            pbObj.LabCharges = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Medicine charges: ");
            pbObj.MedicineCharges = decimal.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            PatientBill.lastBill = pbObj;
            PatientBill.hasLastBill = true;
            Console.WriteLine("Bill created successfully.");
            Console.WriteLine("Gross Amount: {0:F2}",pbObj.GrossAmount);
            Console.WriteLine("Discount Amount: {0:F2}",pbObj.DiscountAmount);
            Console.WriteLine("Final Payable: {0:F2}",pbObj.FinalPayable);
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        }
        case 2:
        {
                if (PatientBill.hasLastBill)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------------------- Last Bill--------------------------");
                    Console.WriteLine("BillId: {0:F2}",PatientBill.lastBill.BillId);
                    Console.WriteLine("Pateint: {0:F2}",PatientBill.lastBill.PatientName);
                    Console.WriteLine("Insured: {0:F2}",PatientBill.lastBill.HasInsurance);
                    Console.WriteLine("Consultation Fee: {0:F2}",PatientBill.lastBill.ConsultationFee);
                    Console.WriteLine("Lab charges: {0:F2}",PatientBill.lastBill.LabCharges);
                    Console.WriteLine("Medicine Charges: {0:F2}",PatientBill.lastBill.MedicineCharges);
                    Console.WriteLine("Gross Amount: {0:F2}",PatientBill.lastBill.GrossAmount);
                    Console.WriteLine("Discount Amount: {0:F2}",PatientBill.lastBill.DiscountAmount);
                    Console.WriteLine("Final Payable: {0:F2}",PatientBill.lastBill.FinalPayable);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine("No bill available. Please create a new bill first");
                }
            break;
        }
        case 3:
        {
            PatientBill.lastBill = null;
            PatientBill.hasLastBill = false;
            Console.WriteLine("Last bill cleared");
            break;
        }
        case 4:
        {
            Console.WriteLine("Thank you. Application Closed normally");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        default:
        {
            Console.WriteLine("Invalid choice!!");
            break;
        }
    }
}
