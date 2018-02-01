using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StockManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Item> items= new ObservableCollection<Item>();
        int count = 1;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        public MainWindow()
        {
            InitializeComponent();
            items.Add(new Item { Компания="TOO Алматы", Количество = 1, Имя = "Помидоры" });
            
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            count++;
            foreach (var m in items)
            {
                if (m.Имя == "Помидоры")
                {
                    m.Количество = count;
                    return;
                }
            }

            items.Add(new Item { Компания = "TOO Алматы", Количество = count, Имя = "Помидоры" });
            dataGrid.ItemsSource = items;

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            count += 5;
            foreach (var m in items)
            {
                if (m.Имя == "Помидоры")
                {
                    m.Количество = count;
                    return;
                }
            }

            items.Add(new Item { Компания = "TOO Алматы", Количество = count, Имя = "Помидоры" });
            dataGrid.ItemsSource = items;

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            count += 10;
            foreach (var m in items)
            {
                if (m.Имя == "Помидоры")
                {
                    m.Количество = count;
                    return;
                }
            }

            items.Add(new Item { Компания = "TOO Алматы", Количество = count, Имя = "Помидоры" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            count += 100;
            foreach (var m in items)
            {
                if (m.Имя == "Помидоры")
                {
                    m.Количество = count;
                    return;
                }
            }

            items.Add(new Item { Компания = "TOO Алматы", Количество = count, Имя = "Помидоры" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            count += 1000;
            foreach (var m in items)
            {
                if (m.Имя == "Помидоры")
                {
                    m.Количество = count;
                    return;
                }
            }

            items.Add(new Item { Компания= "TOO Алматы", Количество = count, Имя = "Помидоры" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            count2 += 1;
            foreach (var m in items)
            {
                if (m.Имя == "Картошка")
                {
                    m.Количество = count2;
                    return;
                }
            }

            items.Add(new Item { Компания = "Аламат", Количество = count2, Имя = "Картошка" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            count2 += 5;
            foreach (var m in items)
            {
                if (m.Имя == "Картошка")
                {
                    m.Количество = count2;
                    return;
                }
            }

            items.Add(new Item { Компания = "Аламат", Количество = count2, Имя = "Картошка" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            count2 += 10;
            foreach (var m in items)
            {
                if (m.Имя == "Картошка")
                {
                    m.Количество = count2;
                    return;
                }
            }

            items.Add(new Item { Компания = "Аламат", Количество = count2, Имя = "Картошка" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            count2 += 100;
            foreach (var m in items)
            {
                if (m.Имя == "Картошка")
                {
                    m.Количество = count2;
                    return;
                }
            }

            items.Add(new Item { Компания = "Аламат", Количество = count2, Имя = "Картошка" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            count2 += 1000;
            foreach (var m in items)
            {
                if (m.Имя == "Картошка")
                {
                    m.Количество = count2;
                    return;
                }
            }

            items.Add(new Item { Компания = "Аламат", Количество = count2, Имя = "Картошка" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            count3 += 1;
            foreach (var m in items)
            {
                if (m.Имя == "Рис")
                {
                    m.Количество = count3;
                    return;
                }
            }

            items.Add(new Item { Компания = "АОО Карапай", Количество = count3, Имя = "Рис" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            count3 += 5;
            foreach (var m in items)
            {
                if (m.Имя == "Рис")
                {
                    m.Количество = count3;
                    return;
                }
            }

            items.Add(new Item { Компания = "АОО Карапай", Количество = count3, Имя = "Рис" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            count3 += 10;
            foreach (var m in items)
            {
                if (m.Имя == "Рис")
                {
                    m.Количество = count3;
                    return;
                }
            }

            items.Add(new Item { Компания = "АОО Карапай", Количество = count3, Имя = "Рис" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            count3 += 100;
            foreach (var m in items)
            {
                if (m.Имя == "Рис")
                {
                    m.Количество = count3;
                    return;
                }
            }

            items.Add(new Item { Компания = "АОО Карапай", Количество = count3, Имя = "Рис" });
            dataGrid.ItemsSource = items;

        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            count3 += 1000;
            foreach (var m in items)
            {
                if (m.Имя == "Рис")
                {
                    m.Количество = count3;
                    return;
                }
            }

            items.Add(new Item { Компания = "АОО Карапай", Количество = count3, Имя = "Рис" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_15(object sender, RoutedEventArgs e)
        {
            count4 += 1;
            foreach (var m in items)
            {
                if (m.Имя == "Капуста")
                {
                    m.Количество = count4;
                    return;
                }
            }

            items.Add(new Item { Компания = "АОО Карапай", Количество = count4, Имя = "Капуста" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_16(object sender, RoutedEventArgs e)
        {
            count4 +=5;
            foreach (var m in items)
            {
                if (m.Имя == "Капуста")
                {
                    m.Количество = count4;
                    return;
                }
            }

            items.Add(new Item { Компания = "Кирилл и Ко", Количество = count4, Имя = "Капуста" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_17(object sender, RoutedEventArgs e)
        {
            count4 += 10;
            foreach (var m in items)
            {
                if (m.Имя == "Капуста")
                {
                    m.Количество = count4;
                    return;
                }
            }

            items.Add(new Item {Компания = "Кирилл и Ко", Количество = count4, Имя = "Капуста" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_18(object sender, RoutedEventArgs e)
        {
            count4 += 100;
            foreach (var m in items)
            {
                if (m.Имя == "Капуста")
                {
                    m.Количество = count4;
                    return;
                }
            }

            items.Add(new Item { Компания = "Кирилл и Ко", Количество = count4, Имя = "Капуста" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_19(object sender, RoutedEventArgs e)
        {
            count4 += 1000;
            foreach (var m in items)
            {
                if (m.Имя == "Капуста")
                {
                    m.Количество = count4;
                    return;
                }
            }

            items.Add(new Item { Компания = "Кирилл и Ко", Количество= count4,Имя = "Капуста" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_20(object sender, RoutedEventArgs e)
        {
            count5 += 1;
            foreach (var m in items)
            {
                if (m.Имя == "Тыква")
                {
                    m.Количество = count5;
                    return;
                }
            }

            items.Add(new Item { Компания= "Бидек", Количество = count5, Имя = "Тыква" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_21(object sender, RoutedEventArgs e)
        {
            count5 += 5;
            foreach (var m in items)
            {
                if (m.Имя == "Тыква")
                {
                    m.Количество = count5;
                    return;
                }
            }

            items.Add(new Item { Компания = "Бидек", Количество = count5, Имя = "Тыква" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_22(object sender, RoutedEventArgs e)
        {
            count5 += 10;
            foreach (var m in items)
            {
                if (m.Имя == "Тыква")
                {
                    m.Количество = count5;
                    return;
                }
            }

            items.Add(new Item { Компания = "Бидек", Количество = count5, Имя = "Тыква" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_23(object sender, RoutedEventArgs e)
        {
            count5 += 100;
            foreach (var m in items)
            {
                if (m.Имя == "Тыква")
                {
                    m.Количество = count5;
                    return;
                }
            }

            items.Add(new Item {Компания = "Бидек", Количество = count5, Имя = "Тыква" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_24(object sender, RoutedEventArgs e)
        {
            count5 += 1000;
            foreach (var m in items)
            {
                if (m.Имя == "Тыква")
                {
                    m.Количество= count5;
                    return;
                }
            }

            items.Add(new Item { Компания = "Бидек", Количество = count5, Имя= "Тыква" });
            dataGrid.ItemsSource = items;
        }

        private void MenuItem_Click_25(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = items;

            if (dataGrid.SelectedItem != null)
            {
                int c = dataGrid.SelectedIndex;
                if (items.ElementAt(c).Имя == "Помидоры")
                {
                    count = 0;
                }
                if (items.ElementAt(c).Имя == "Картошка")
                {
                    count2 = 0;
                }
                if (items.ElementAt(c).Имя == "Рис")
                {
                    count3 = 0;
                }
                if (items.ElementAt(c).Имя == "Капуста")
                {
                    count4 = 0;
                }
                if (items.ElementAt(c).Имя == "Тыква")
                {
                    count5 = 0;
                }
                items.RemoveAt(c);
                
                dataGrid.ItemsSource = items;

            }   
        }

        private void MenuItem_Click_26(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = items.OrderBy(x => x.Имя);
        }

        private void MenuItem_Click_27(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource= items.OrderByDescending(x => x.Количество);

        }
    }
}
