namespace AvaloniaApplication3;

//public enum State {Default, State1, State2}

public class MainWindowViewModel : BaseViewModel
{
    /*private State _state;
    public State State
    {
        get => _state; 
        set => SetField(ref _state, value);
    }*/

    private bool _isUpdated;
    
    public bool IsUpdated
    {
        get => _isUpdated;
        set => SetField(ref _isUpdated, value);
    }

    private string _text;
    public string Text
    {
        get => _text;
        set
        {
            SetField(ref _text, value);
            IsUpdated = _text == "12345";
        }
    }
}