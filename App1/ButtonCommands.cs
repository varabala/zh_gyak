using System;
using System.Windows.Input;

public class ButtonCommand : ICommand
{
    public event EventHandler CanExecuteChanged;

    private readonly Action _action;
    private bool _canExecute;

    public ButtonCommand(Action action, bool canExecute = true)
    {
        _action = action;
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        return _canExecute;
    }

    public void Execute(object parameter)
    {
        _action();
    }

    public void OnCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public void SetCanExecute(bool canExecute)
    {
        if (_canExecute != canExecute)
        {
            _canExecute = canExecute;
            OnCanExecuteChanged();
        }
    }
}
