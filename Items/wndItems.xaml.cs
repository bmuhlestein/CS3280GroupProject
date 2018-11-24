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

namespace Add_Mod_Del_Invoice_Project.Items
{
    /// <summary>
    /// Interaction logic for wndItems.xaml
    /// </summary>
    public partial class wndItems : Window
    {
        private clsItemsLogic Logic = new clsItemsLogic();
        public wndItems()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Call to load Table to Initalize Grid
            
            rdoMod.IsChecked = true; 
        }
        /// <summary>
        /// Reads the Radio Button. proceeds with correct functionality.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string sSQL;
            // Which Function takes Place 
            if (rdoAdd.IsChecked)
            {
                //Get Index of checked Row. Pull out each field and add to string 
                sSQL = "Add";

            } else if (rdoMod.IsChecked)
            {
                //Get Index of checked Row. Pulls out all fields to have updated. 
                sSQL = "Modify";
            }else
            {
                //Get Index of the checked Row. 
                // Checks to see if Item can be delted. 
                // If so proceed. 
                sSQL = "Delete";

            }
        }
    }
}
