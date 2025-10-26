using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Samost_Igra
{
    public partial class Form1 : Form
    {
        private List<string> slova = new List<string>
        {
            "птичка", "ручка", "гидроэлектростанция", "трансформатор", "колбаса", "бутерброд", "программист", "будильник", "кошка", "мужик", "барсетка", "ливретка", "колобок"
        };

        private int pravOtv = 0;
        private int nepravOtv = 0;
        private string slovo = "";
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            Nachalo();
        }
        private void Nachalo()
        {
            slovo = slova[random.Next(slova.Count)];
            slovoLBL.Text = slovo;
            textVvod.Text = "";
            textVvod.Focus();
        }
        private void Proverka()
        {
            string vvedSlovo = textVvod.Text.ToLower();
            if (vvedSlovo == slovo)
            {
                pravOtv++;
                pravLBL.Text = $"Правильных слов: {pravOtv}";
            }
            else
            {
                nepravOtv++;
                nePravLBL.Text = $"Неправильных слов: {nepravOtv}";
            }
            Nachalo();
        }
        private void textVvod_KeyDown(object txt, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Proverka();
            }
        }
    }
}
