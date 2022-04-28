using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetValue(ref isBusy, value);
            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetValue<T>(ref T backingFiled, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFiled, value)) return;
            backingFiled = value;
            OnPropertyChanged(propertyName);
        }
    }
}
