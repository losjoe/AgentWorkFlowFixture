using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using StatusLamp.Wpf.Commands;

namespace StatusLamp.Wpf.ViewModels;

public sealed class MainWindowViewModel : INotifyPropertyChanged
{
    private bool _isOn;

    public MainWindowViewModel()
    {
        ToggleCommand = new RelayCommand(_ => IsOn = !IsOn);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public bool IsOn
    {
        get => _isOn;
        private set
        {
            if (_isOn == value)
            {
                return;
            }

            _isOn = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(StatusText));
            OnPropertyChanged(nameof(StatusColor));
        }
    }

    public string StatusText => IsOn ? "1" : "0";

    public string StatusColor => IsOn ? "Green" : "Red";

    public ICommand ToggleCommand { get; }

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
