class HotelRoom : Room
{
    string roomType;
    double ratePerNight;
    string guestName;

    public HotelRoom(string roomType, double ratePerNight, string guestName)
    {
        this.roomType = roomType;
        this.ratePerNight = ratePerNight;
        this.guestName = guestName;
    }
    public int CalculateMembershipYears(int joiningYear)
    {
        return DateTime.Now.Year - joiningYear;
    }

    public double CalculateTotalBill(int nightsStayed, int joiningYear)
    {
        double totalBill = nightsStayed * ratePerNight;

        if (CalculateMembershipYears(joiningYear)>3)
        {
            totalBill *= 0.9; // 10% discount
        }

        return Math.Round(totalBill);
    }

    public void DisplaySummary(int joiningYear)
    {
        Console.WriteLine($"{roomType} Room: {guestName}, {ratePerNight:F1} per night, Membership: {CalculateMembershipYears(joiningYear)} years");
    }
}
