using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    public class UploadResult
    {
        public bool Uploaded { get; set; }
        public string? FileName { get; set; }
        public string? StoredFileName { get; set; }
        public int ErrorCode { get; set; }
    }
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
        private class File
        {
            public string? Name { get; set; }
        }
        public IList<IBrowserFile> Files = new List<IBrowserFile>();
        public List<IFormFile> FormFiles = new();

        private List<File> files = new();
        private List<UploadResult> uploadResults = new();
        private int maxAllowedFiles = 3;
        public MultipartFormDataContent content = new();
        private bool shouldRender;
        public bool upload = false;

        public void UploadFiles(InputFileChangeEventArgs e)
        {
            upload = false;
            shouldRender = false;
            long maxFileSize = 1024 * 1024 * 15;

            foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
            {
                if (uploadResults.SingleOrDefault( f => f.FileName == file.Name) is null)
                {
                    //try
                    //{
                        var fileContent =
                            new StreamContent(file.OpenReadStream(maxFileSize));

                        fileContent.Headers.ContentType =
                            new MediaTypeHeaderValue(file.ContentType);

                        files.Add(new() { Name = file.Name });

                        content.Add(
                            content: fileContent,
                            name: "\"files\"",
                            fileName: file.Name);

                        upload = true;
                }
            }
         
            shouldRender = true;
        }
        private void BrowserFileToFormFile()
        {
            if(Files.Count > 0)
            {
                foreach(var file in Files)
                {
                    var stream = file.OpenReadStream();
                    IFormFile newFormFile = new FormFile(stream, 0, file.Size, file.Name, file.Name);
                    FormFiles.Add(newFormFile);
                }
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
