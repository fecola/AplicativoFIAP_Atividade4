using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XF.AplicativoFIAP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeApplication();

            MainPage = new NavigationPage(new View.ListaProfessorView { BindingContext = App.ProfessorVM });
        }

        private void InitializeApplication()
        {
            if (ProfessorVM == null) ProfessorVM = new ProfessorViewModel();
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
