using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OOPLaba3._2
{
    public partial class Form1 : Form
    {
        private NumberModel model;

        public Form1()
        {
            InitializeComponent();

            // Создаем экземпляр модели
            model = new NumberModel();

            // Подписываемся на событие изменения модели
            model.PropertyChanged += Model_PropertyChanged;

            // Инициализируем элементы управления начальными значениями
            UpdateControlsFromModel();
        }

        // Обновление элементов управления из модели
        private void UpdateControlsFromModel()
        {
            textBoxA.Text = model.A.ToString();
            textBoxB.Text = model.B.ToString();
            textBoxC.Text = model.C.ToString();

            numericUpDownA.Value = model.A;
            numericUpDownB.Value = model.B;
            numericUpDownC.Value = model.C;

            trackBarA.Value = model.A;
            trackBarB.Value = model.B;
            trackBarC.Value = model.C;
        }

        // Обработчик события изменения модели
        private void Model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            UpdateControlsFromModel();
        }

        // Обработчики для TextBox

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxA.Text, out int value))
            {
                model.SetA(value);
            }
            else
            {
                textBoxA.Text = model.A.ToString();
            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxB.Text, out int value))
            {
                model.SetB(value);
            }
            else
            {
                textBoxB.Text = model.B.ToString();
            }
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxC.Text, out int value))
            {
                model.SetC(value);
            }
            else
            {
                textBoxC.Text = model.C.ToString();
            }
        }

        // Обработчики для NumericUpDown

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)numericUpDownA.Value;

            // Просто устанавливаем значение через модель
            model.SetA(newValue);

            // Обновляем все контролы по текущему состоянию модели
            numericUpDownA.Value = model.A;
            numericUpDownB.Value = model.B;
            numericUpDownC.Value = model.C;

            trackBarA.Value = model.A;
            trackBarB.Value = model.B;
            trackBarC.Value = model.C;
        }





        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            // Получаем текущее значение из numericUpDownB
            int newValue = (int)numericUpDownB.Value;

            // Ограничиваем значение в пределах [A, C]
            int clampedValue = Math.Max(model.A, Math.Min(model.C, newValue));

            // Если значение вышло за пределы, корректируем его
            if (clampedValue != newValue)
            {
                numericUpDownB.Value = clampedValue; // Корректируем значение numericUpDown
            }

            // Обновляем модель только с валидным значением
            model.SetB(clampedValue);
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)numericUpDownC.Value;

            // Ограничиваем C минимумом для A
            int clampedValue = Math.Max(newValue, NumberModel.MIN_A);

            if (clampedValue != newValue)
            {
                numericUpDownC.Value = clampedValue;
            }

            model.SetC(clampedValue);

            // Если C толкает A вниз, но не ниже MIN_A
            if (clampedValue < model.A)
            {
                int newA = clampedValue;
                model.SetA(newA);
                numericUpDownA.Value = newA;
                trackBarA.Value = newA;
            }
        }


        // Обработчики для TrackBar

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            int newValue = trackBarA.Value;

            // Ограничиваем A максимумом для C
            int clampedValue = Math.Min(newValue, NumberModel.MAX_C);

            if (clampedValue != newValue)
            {
                trackBarA.Value = clampedValue;
            }

            model.SetA(clampedValue);
            numericUpDownA.Value = clampedValue;

            // Если A толкает C вверх
            if (clampedValue > model.C)
            {
                int newC = clampedValue;
                model.SetC(newC);
                numericUpDownC.Value = newC;
                trackBarC.Value = newC;
            }
        }



        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            // Проверяем, находится ли значение trackBarB в пределах [A, C]
            int newValue = trackBarB.Value;
            int clampedValue = Math.Max(model.A, Math.Min(model.C, newValue));

            // Если значение вышло за пределы, корректируем его
            if (clampedValue != newValue)
            {
                trackBarB.Value = clampedValue; // Корректируем положение trackBar
            }

            // Обновляем модель только если значение валидно
            model.SetB(clampedValue);
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            int newValue = trackBarC.Value;

            // Ограничиваем C минимумом для A
            int clampedValue = Math.Max(newValue, NumberModel.MIN_A);

            if (clampedValue != newValue)
            {
                trackBarC.Value = clampedValue;
            }

            model.SetC(clampedValue);
            numericUpDownC.Value = clampedValue;

            // Если C толкает A вниз, но не ниже MIN_A
            if (clampedValue < model.A)
            {
                int newA = clampedValue;
                model.SetA(newA);
                numericUpDownA.Value = newA;
                trackBarA.Value = newA;
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            model.SaveValues(); // Сохраняем значения перед закрытием формы
        }
    }
}