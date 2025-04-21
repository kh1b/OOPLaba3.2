using System.ComponentModel;

public class NumberModel : INotifyPropertyChanged
{
    public const int MIN_A = 0;
    public const int MAX_A = 100;

    public const int MIN_B = 0;
    public const int MAX_B = 100;

    public const int MIN_C = 0;
    public const int MAX_C = 100;

    private int _a;
    private int _b;
    private int _c;

    public event PropertyChangedEventHandler? PropertyChanged;

    public int A => _a;
    public int B => _b;
    public int C => _c;

    public NumberModel()
    {
        if (!LoadValues())
        {
            // Если не удалось загрузить — устанавливаем безопасные значения
            SetSafeDefaults();
        }
    }

    private void SetSafeDefaults()
    {
        int defaultC = Clamp(50, MIN_C, MAX_C);
        int defaultB = Clamp(30, MIN_B, Math.Min(defaultC, MAX_B));
        int defaultA = Clamp(10, MIN_A, Math.Min(defaultB, MAX_A));

        _a = defaultA;
        _b = defaultB;
        _c = defaultC;

        OnPropertyChanged(nameof(A));
        OnPropertyChanged(nameof(B));
        OnPropertyChanged(nameof(C));
    }

    public void SetA(int newValue)
    {
        newValue = Clamp(newValue, MIN_A, MAX_A);
        int targetA = newValue;
        int targetB = Math.Max(targetA, _b);
        int targetC = Math.Max(targetB, _c);

        targetB = Clamp(targetB, MIN_B, Math.Min(targetC, MAX_B));
        targetC = Clamp(targetC, MIN_C, MAX_C);

        targetB = Math.Min(targetB, targetC);
        targetA = Math.Min(targetA, targetB);

        UpdateInternalValues(targetA, targetB, targetC, _a, _b, _c);
    }

    public void SetB(int newValue)
    {
        int targetB = Clamp(newValue, Math.Max(_a, MIN_B), Math.Min(_c, MAX_B));
        UpdateInternalValues(_a, targetB, _c, _a, _b, _c);
    }

    public void SetC(int newValue)
    {
        newValue = Clamp(newValue, MIN_C, MAX_C);
        int targetC = newValue;
        int targetB = Math.Min(_b, targetC);
        int targetA = Math.Min(_a, targetB);

        targetB = Clamp(targetB, MIN_B, MAX_B);
        targetA = Clamp(targetA, MIN_A, MAX_A);

        UpdateInternalValues(targetA, targetB, targetC, _a, _b, _c);
    }

    private int Clamp(int value, int min, int max)
    {
        return Math.Max(min, Math.Min(max, value));
    }

    private void UpdateInternalValues(int newA, int newB, int newC, int oldA, int oldB, int oldC)
    {
        if (_a != newA || _b != newB || _c != newC)
        {
            _a = newA;
            _b = newB;
            _c = newC;
            OnPropertyChanged(nameof(A));
            OnPropertyChanged(nameof(B));
            OnPropertyChanged(nameof(C));
        }
    }

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void SaveValues()
    {
        try
        {
            System.IO.File.WriteAllText("values.txt", $"{_a},{_b},{_c}");
        }
        catch { }
    }

    public bool LoadValues()
    {
        try
        {
            string[] values = System.IO.File.ReadAllText("values.txt").Split(',');
            if (values.Length == 3 &&
                int.TryParse(values[0], out int loadedA) &&
                int.TryParse(values[1], out int loadedB) &&
                int.TryParse(values[2], out int loadedC))
            {
                loadedC = Clamp(loadedC, MIN_C, MAX_C);
                loadedB = Clamp(loadedB, MIN_B, Math.Min(loadedC, MAX_B));
                loadedA = Clamp(loadedA, MIN_A, Math.Min(loadedB, MAX_A));

                _a = loadedA;
                _b = loadedB;
                _c = loadedC;

                OnPropertyChanged(nameof(A));
                OnPropertyChanged(nameof(B));
                OnPropertyChanged(nameof(C));
                return true;
            }
        }
        catch { }
        return false;
    }
}
