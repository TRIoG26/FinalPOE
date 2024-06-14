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
using System.Windows.Shapes;

namespace FinalPOE
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            String name = edit_name.Text;
            for (int i = 0; i < main.name_of_recipe.Count; i++) {
                if(main.name_of_recipe[i].Equals(name))
                {
                 //main.calories[i] = Convert.ToDouble(edit_calories);
                //edit_calories.Text = $"+{ main.calories[i]}";
                }
            }
            
        }
    }
}
