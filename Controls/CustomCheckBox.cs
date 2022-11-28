using System.Windows.Input;

namespace TapGestureIssue.Controls;

public class CustomCheckBox : TemplatedView
{
    public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(propertyName: nameof(IsChecked), returnType: typeof(bool), declaringType: typeof(CustomCheckBox));
    public static readonly BindableProperty TextProperty = BindableProperty.Create(propertyName: nameof(Text), returnType: typeof(string), declaringType: typeof(CustomCheckBox));

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    
    public ICommand ToggleChecked { get; }

    public CustomCheckBox()
    {
        ToggleChecked = new Command(OnToggleChecked);
    }

    private void OnToggleChecked()
    {
        IsChecked = !IsChecked;
    }
}
