using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Forms;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    // IsBusy 같은 경우에는 Post 하는 동안 화면을 제어하지 못하도록
    // 만드는데 이용할만 하다.
    public enum ModeView { Table, Card, Dashboard}
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetValue(ref isBusy, value);
            }
        }
        public IList<IBrowserFile> Files = new List<IBrowserFile>();
        private void UploadFiles(InputFileChangeEventArgs e)
        {
            foreach (var file in e.GetMultipleFiles())
            {
                Files.Add(file);
            }
        }
        public IDictionary<string, Stream> BrowserFileToDTO()
        {
            IDictionary<string, Stream> BrowserFileStreams = new Dictionary<string, Stream>();
            if(Files.Count > 0)
            {
                foreach(var file in Files)
                {
                    BrowserFileStreams.Add(file.Name, file.OpenReadStream());
                }
            }
            return BrowserFileStreams;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetValue<T>(ref T backingFiled, T value, [CallerMemberName] string propertyName =null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFiled, value)) return;
            backingFiled = value;
            OnPropertyChanged(propertyName);
        }
    }
}
