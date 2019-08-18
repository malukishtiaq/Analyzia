using Analyzia.Database;
using Analyzia.Models;
using FluentValidation;
using FreshMvvm;
using PropertyChanged;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Analyzia.PageModels
{
    [AddINotifyPropertyChangedInterface]
    public class AddHabitsPageModel : FreshBasePageModel
    {
        IDatabaseHelper<Habits> _databaseService;
        private readonly IValidator validator;
        public Habits _habits;

        public AddHabitsPageModel(IDatabaseHelper<Habits> databaseService, IValidator validator)
        {
            _databaseService = databaseService;
            this.validator = validator;
        }
        public override void Init(object initData)
        {
        }

        protected override void ViewIsAppearing(object sender, System.EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
        }

        protected override void ViewIsDisappearing(object sender, System.EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
        }
        public override void ReverseInit(object value)
        {

        }
        public string Title
        {
            get => _habits.Title;
            set
            {
                _habits.Title = value;
            }
        }
        public ICommand AddHabitCommand => new Command(async () => await AddHabits());

        private Task AddHabits()
        {
            var result = validator.Validate(_habits);
            if (result.IsValid)
            {
                int value = _databaseService.Insert(_habits);
            }
            return default;
        }
    }
}
