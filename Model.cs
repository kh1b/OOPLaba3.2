using System;
using System.ComponentModel;

namespace OOPLaba3._2
{
    public class NumberModel : INotifyPropertyChanged
    {
        private int _a = 0;
        private int _b = 0;
        private int _c = 0;

        // Событие для уведомления о изменении модели
        public event PropertyChangedEventHandler? PropertyChanged;

        // Защитный метод для вызова события PropertyChanged
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Конструктор с загрузкой значений из файла
        public NumberModel()
        {
            LoadValues();
        }

        // Геттеры и сеттеры для A, B, C
        public int A
        {
            get => _a;
            set
            {
                if (_a != value)
                {
                    _a = value;
                    AdjustValues(); // Пересчет после изменения A
                    SaveValues();   // Сохранение значений
                    OnPropertyChanged(nameof(A));
                    OnPropertyChanged(nameof(AllNumbers)); // Уведомление о глобальном изменении
                }
            }
        }

        public int B
        {
            get => _b;
            set
            {
                if (_b != value)
                {
                    _b = value;
                    AdjustValues(); // Пересчет после изменения B
                    SaveValues();   // Сохранение значений
                    OnPropertyChanged(nameof(B));
                    OnPropertyChanged(nameof(AllNumbers)); // Уведомление о глобальном изменении
                }
            }
        }

        public int C
        {
            get => _c;
            set
            {
                if (_c != value)
                {
                    _c = value;
                    AdjustValues(); // Пересчет после изменения C
                    SaveValues();   // Сохранение значений
                    OnPropertyChanged(nameof(C));
                    OnPropertyChanged(nameof(AllNumbers)); // Уведомление о глобальном изменении
                }
            }
        }

        // Комбинированное свойство для всех чисел
        public (int A, int B, int C) AllNumbers => (_a, _b, _c);

        // Метод для пересчета значений
        private void AdjustValues()
        {
            // Убедимся, что A <= B <= C
            if (_a > _b)
            {
                _b = _a; // Если B меньше A, то B становится равным A
            }
            if (_b > _c)
            {
                _c = _b; // Если C меньше B, то C становится равным B
            }
        }

        // Сохранение значений в файл
        private void SaveValues()
        {
            System.IO.File.WriteAllText("values.txt", $"{_a},{_b},{_c}");
        }

        // Загрузка значений из файла
        private void LoadValues()
        {
            try
            {
                string[] values = System.IO.File.ReadAllText("values.txt").Split(',');
                if (values.Length == 3)
                {
                    _a = int.Parse(values[0]);
                    _b = int.Parse(values[1]);
                    _c = int.Parse(values[2]);
                }
            }
            catch
            {
                _a = 10;
                _b = 50;
                _c = 90;
            }
        }
    }
}