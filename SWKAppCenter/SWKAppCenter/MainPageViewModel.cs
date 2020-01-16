using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace SWKAppCenter
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand NewAccount => new Command(NewAccountExecute);
        public ICommand AddTransaction => new Command(AddTransactionExecute);
        public ICommand OpenReports => new Command(OpenReportsExecute);

        public event PropertyChangedEventHandler PropertyChanged;

        private void OpenReportsExecute(object obj)
        {
            try
            {
                throw new ArgumentNullException();
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
        }

        private void NewAccountExecute(object obj)
        {
            Analytics.TrackEvent("New Account created");
        }

        private void AddTransactionExecute(object obj)
        {
            Analytics.TrackEvent("Transaction added");

        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}