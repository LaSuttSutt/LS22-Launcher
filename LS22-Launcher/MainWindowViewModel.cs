using System.ComponentModel;
using System.Windows.Controls;
using LS22_Launcher.ModDb;

namespace LS22_Launcher
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Declarations

        public event PropertyChangedEventHandler PropertyChanged;

        public UserControl ModDbMainView { get; set; }
        
        #endregion

        #region C´tor

        public MainWindowViewModel()
        {
            ModDbMainView = new ModDbMainView() {DataContext = new ModDbMainViewModel()};
            RaisePropertyChanged(nameof(ModDbMainView));
        }

        #endregion

        #region Private methods

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}