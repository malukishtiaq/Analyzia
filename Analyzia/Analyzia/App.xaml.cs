using Analyzia.Database;
using Analyzia.Models;
using Analyzia.Validations;
using Analyzia.PageModels;
using FluentValidation;
using FreshMvvm;
using Xamarin.Forms;

namespace Analyzia
{
    public partial class App : Application
    {
        /// <summary>
        /// this is just empty commit.
        /// </summary>
        public App()
        {
            InitializeComponent();

            FreshIOC.Container.Register<IValidator, HabitValidator>();
            RegisterRepository<Habits>();
            try
            {

                Page mainPage = FreshPageModelResolver.ResolvePageModel<AddHabitsPageModel>();
                MainPage = new FreshNavigationContainer(mainPage);
            }
            catch (System.Exception Exception)
            {

            }
        }
        public static void RegisterRepository<TKey>() where TKey : class
        {
            FreshIOC.Container.Register<IDatabaseHelper<TKey>, DatabaseHelper<TKey>>();
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
