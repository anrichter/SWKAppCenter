using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
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
        }

        private void NewAccountExecute(object obj)
        {
        }

        private void AddTransactionExecute(object obj)
        {
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}