using Analyzia.Models;
using FluentValidation;

namespace Analyzia.Validations
{
    public class HabitValidator : AbstractValidator<Habits>
    {
        public HabitValidator()
        {
            RuleFor(c => c.Title).Must(n => ValidateStringEmpty(n)).WithMessage("Habit title should not be empty.");
        }

        bool ValidateStringEmpty(string stringValue)
        {
            if (!string.IsNullOrEmpty(stringValue))
                return true;
            return false;
        }
    }
}
