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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for windowMain.xaml
    /// </summary>
    public partial class windowMain : MetroWindow
    {
        public windowMain()
        {
            InitializeComponent();
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            pgeStudent oood = new pgeStudent();
            wew.NavigationService.Navigate(oood);

        }

        private void TabItem_Loaded_1(object sender, RoutedEventArgs e)
        {
            pageEnlist pgE = new pageEnlist();
            enlist.NavigationService.Navigate(pgE);
        }

        private void TabItem_Loaded_2(object sender, RoutedEventArgs e)
        {
            pageHome phome = new pageHome();
            home_frame.NavigationService.Navigate(phome);
        }

        private void TabItem_Loaded_3(object sender, RoutedEventArgs e)
        {
            pageGrades pg = new pageGrades();
            grades_frame.NavigationService.Navigate(pg);
        }
    }
}
