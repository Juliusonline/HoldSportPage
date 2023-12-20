namespace HoldSportPage.Model
{
    public class MembershipFeeCalculator
    { 
     public decimal CalculateFee(int age, bool isStudent)
    {
        
        return isStudent ? 50m : (age < 18 ? 100m : 200m);
    }
}
}

