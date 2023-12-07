﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _227Bel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Button_Click(object sender, EventArgs e)
        {

            double nn = Convert.ToDouble(Rezult_a.Text);
            double aa = Convert.ToDouble(Rezult_b.Text);
            double bb = Convert.ToDouble(Rezult_c.Text);
            switch (nn)
            {
                case 1: aa += bb; break;
                case 2: aa -= bb; break;
                case 3: aa = aa * bb; break;
                case 4: aa = aa / bb; break;
            }

            TextBlockAnswer.Text = $"{aa}";
        }
    }
}
