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

namespace CRM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            //move the cursor to the current button selected
            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);


            switch (index)
            {
                case 0:
                    changePanel(GridDashboard);
                    break;
                case 1:
                    changePanel(GridProject);
                    break;
                case 2:
                    changePanel(GridCLient);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void changePanel(Grid selectedGrid)
        {
            List<Grid> gridList = new List<Grid>() 
            { GridDashboard, 
              GridProject,
              GridCLient
            }; 
          foreach (Grid grid in gridList){
                if (selectedGrid == grid)
                {
                    grid.Visibility = Visibility.Visible;
                }
                else
                {
                    grid.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
