using System.ComponentModel;
using StatusLamp.Wpf.ViewModels;

namespace StatusLamp.Tests;

public class MainWindowViewModelTests
{
    [Fact]
    public void InitialState_IsOff()
    {
        var viewModel = new MainWindowViewModel();

        Assert.False(viewModel.IsOn);
        Assert.Equal("0", viewModel.StatusText);
        Assert.Equal("Red", viewModel.StatusColor);
    }

    [Fact]
    public void ToggleCommand_TurnsLampOn()
    {
        var viewModel = new MainWindowViewModel();

        viewModel.ToggleCommand.Execute(null);

        Assert.True(viewModel.IsOn);
        Assert.Equal("1", viewModel.StatusText);
        Assert.Equal("Green", viewModel.StatusColor);
    }

    [Fact]
    public void ToggleCommand_TurnsLampOffAfterTurningOn()
    {
        var viewModel = new MainWindowViewModel();
        viewModel.ToggleCommand.Execute(null);

        viewModel.ToggleCommand.Execute(null);

        Assert.False(viewModel.IsOn);
        Assert.Equal("0", viewModel.StatusText);
        Assert.Equal("Red", viewModel.StatusColor);
    }

    [Fact]
    public void ToggleCommand_RaisesNotificationsForStateAndPresentationValues()
    {
        var viewModel = new MainWindowViewModel();
        var changedProperties = new List<string?>();
        viewModel.PropertyChanged += (_, args) => changedProperties.Add(args.PropertyName);

        viewModel.ToggleCommand.Execute(null);

        Assert.Equal(
            [
                nameof(MainWindowViewModel.IsOn),
                nameof(MainWindowViewModel.StatusText),
                nameof(MainWindowViewModel.StatusColor),
            ],
            changedProperties
        );
    }

    [Fact]
    public void ViewModel_ExposesPropertyChangedContract()
    {
        var viewModel = new MainWindowViewModel();

        Assert.IsAssignableFrom<INotifyPropertyChanged>(viewModel);
    }
}
