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

            // ������� ��������� ������
            model = new NumberModel();

            // ������������� �� ������� ��������� ������
            model.PropertyChanged += Model_PropertyChanged;

            // �������������� �������� ���������� ���������� ����������
            UpdateControlsFromModel();
        }

        // ���������� ��������� ���������� �� ������
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

        // ���������� ������� ��������� ������
        private void Model_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            UpdateControlsFromModel();
        }

        // ���������� ��������� TextBox
        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxA.Text, out int value))
            {
                model.A = value;
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
                model.B = value;
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
                model.C = value;
            }
            else
            {
                textBoxC.Text = model.C.ToString();
            }
        }

        // ���������� ��������� NumericUpDown
        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.A = (int)numericUpDownA.Value;
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.B = (int)numericUpDownB.Value;
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.C = (int)numericUpDownC.Value;
        }

        // ���������� ��������� TrackBar
        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            model.A = trackBarA.Value;
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.B = trackBarB.Value;
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.C = trackBarC.Value;
        }
    }
}
