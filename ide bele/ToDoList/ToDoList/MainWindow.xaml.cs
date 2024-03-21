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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    using System.Collections.Generic;
    using System.IO;
    using System.Windows;

    namespace ToDoListApp
    {
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
                string todo = tbHozzaad.Text.Trim();
                if (!string.IsNullOrEmpty(todo))
                {
                    todoList.Add(todo);
                    RefreshTodoListBox();
                    tbHozzaad.Clear();
                }
            }

            private void DeleteTodoButton_Click(object sender, RoutedEventArgs e)
            {
                if (lblTeendo.SelectedIndex != -1)
                {
                    todoList.RemoveAt(lblTeendo.SelectedIndex);
                    RefreshTodoListBox();....
                }
            }

            private void RefreshTodoListBox()
            {
                todoListBox.Items.Clear();
                foreach (string todo in todoList)
                {
                    todoListBox.Items.Add(todo);
                }
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
                MessageBox.Show("TeendĹ‘k sikeresen mentve.", "MentĂ©s", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            private void LoadButton_Click(object sender, RoutedEventArgs e)
            {
                LoadTodoList();
                RefreshTodoListBox();
                MessageBox.Show("TeendĹ‘k sikeresen betĂ¶ltve.", "BetĂ¶ltĂ©s", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }