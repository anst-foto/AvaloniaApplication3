namespace AvaloniaApplication3;

public enum State {Default, State1, State2}

public class MainWindowViewModel : BaseViewModel
{
    private State _state;
    public State State
    {
        get => _state; 
        set => SetField(ref _state, value);
    }
}