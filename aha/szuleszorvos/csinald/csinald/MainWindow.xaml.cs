using System;
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
using System.IO;

namespace csinald
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> todoList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            LoadTodoList();
            RefreshTodoListBox();
        }
        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todo = todoTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(todo))
            {
                todoList.Add(todo);
                RefreshTodoListBox();
                todoTextBox.Clear();
            }
        }
        private void DeleteTodoButton_Click(object sender, RoutedEventArgs e)
        {
            if (todoListBox.SelectedIndex != -1)
            {
                todoList.RemoveAt(todoListBox.SelectedIndex);
                RefreshTodoListBox();
            }
        }
        private void RefreshTodoListBox()
        {
            todoListBox.ItemsSource = null;
            todoListBox.ItemsSource = todoList;
        }
        private void LoadTodoList()
        {
            if (File.Exists("todolist.txt"))
            {
                todoList = new List<string>(File.ReadAllLines("todolist.txt"));
            }
        }
        private void SaveTodoList()
        {
            File.WriteAllLines("todolist.txt", todoList);
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveTodoList();
            MessageBox.Show("Teendők sikeresen mentve.", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            LoadTodoList();
            RefreshTodoListBox();
            MessageBox.Show("Teendők sikeresen betöltve.", "Betöltés", MessageBoxButton.OK, MessageBoxImage.Information);
        }




    }
}
