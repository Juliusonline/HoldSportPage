using HoldSportPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HoldSportPage.Pages
{
    public class CalculateFeeModel : PageModel
    {
        private readonly MembershipFeeCalculator _calculator;

        public CalculateFeeModel(MembershipFeeCalculator calculator)
        {
            _calculator = calculator;
        }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public bool IsStudent { get; set; }

        [BindProperty]
        public decimal? Fee { get; set; }

        public void OnPost()
        {
            Fee = _calculator.CalculateFee(Age, IsStudent);
        }
    }
}
