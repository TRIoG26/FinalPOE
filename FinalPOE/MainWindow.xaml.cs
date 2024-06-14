using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FinalPOE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // private variables
        private String item;
        private double quant;
        private String units;
        private double unit_number;
        private int step_number;
        private String name_of_recipee;
        private double calo;
        private String food;
        private String prep_step;

        // global lists
        public List<String> ingredient = new List<String>();
        public List<double> Quantity = new List<double>();
        public List<String> unit = new List<String>();
        public List<double> unit_num = new List<double>();
        public List<int> step_num = new List<int>();
        public List<String> name_of_recipe = new List<String>();
        public List<String> prep_steps = new List<String>();
        public List<double> calories = new List<double>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(Recipename.Text) ||
                string.IsNullOrWhiteSpace(item_.Text) ||
                string.IsNullOrWhiteSpace(quantity.Text) ||
                string.IsNullOrWhiteSpace(unit_.Text) ||
                string.IsNullOrWhiteSpace(Unit_measure.Text) ||
                string.IsNullOrWhiteSpace(step.Text) ||
                string.IsNullOrWhiteSpace(calory.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                name_of_recipee = Recipename.Text;
                item = item_.Text;
                quant = Convert.ToDouble(quantity.Text);
                units = unit_.Text;
                unit_number = Convert.ToDouble(Unit_measure.Text);
                step_number = Convert.ToInt32(step.Text);
                calo = Convert.ToDouble(calory.Text);
                prep_step = prep.Text;

                if (name_of_recipe.Count == 0 || !(name_of_recipe.Contains(name_of_recipee)))
                {
                    name_of_recipe.Add(name_of_recipee);
                }

                ingredient.Add(item);
                Quantity.Add(quant);
                unit.Add(units);
                unit_num.Add(unit_number);
                step_num.Add(step_number);
                calories.Add(calo);
                prep_steps.Add(prep_step);

                // Display all entries for debugging
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Delete del = new Delete();
            this.Visibility = Visibility.Hidden;
            del.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder message = new StringBuilder();
                for (int i = 0; i < name_of_recipe.Count; i++)
                {
                    message.AppendLine($"Recipename: {name_of_recipe[i]}, Ingredient: {ingredient[i]}, Quantity: {Quantity[i]}, Units: {unit[i]}, Unit Number: {unit_num[i]}, Step: {step_num[i]}, Calories: {calories[i]}, How to prepare: {prep_steps[i]}");
                }

                MessageBox.Show(message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Recipename.Clear();
            item_.Clear();
            unit_.Clear();
            Unit_measure.Clear();
            prep.Clear();
            step.Clear();
            calory.Clear();
            quantity.Clear();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit();
            this.Visibility = Visibility.Hidden;
            edit.Show();
        }
    }
}
