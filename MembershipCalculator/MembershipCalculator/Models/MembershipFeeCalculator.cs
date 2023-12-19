namespace MembershipCalculator.Models
{
    public class MembershipFeeCalculator
    {
        public decimal CalculateFee(int age, bool isStudent)
        {
            // Implementer logik for kontingentberegning baseret på alder og studerende-status
            // Returner det beregnede kontingentbeløb
            return isStudent ? 50m : (age < 18 ? 100m : 200m);
        }
    }
}
