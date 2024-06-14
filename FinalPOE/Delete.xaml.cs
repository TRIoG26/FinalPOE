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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            String delete = deletebox.Text;

            for (int i = 0; i < main.name_of_recipe.Count; i++)
            {
                if (main.name_of_recipe[i].Equals(delete, StringComparison.OrdinalIgnoreCase))
                {
                    main.name_of_recipe.RemoveAt(i);
                    main.Quantity.RemoveAt(i);
                    main.unit.RemoveAt(i);
                    main.unit_num.RemoveAt(i);
                    main.calories.RemoveAt(i);
                    main.step_num.RemoveAt(i);
                    main.prep_steps.RemoveAt(i);
                }
            }
            MessageBox.Show("Recipe deleted");
            
            this.Visibility = Visibility.Hidden;
            main.Show();
        }
    }
}
