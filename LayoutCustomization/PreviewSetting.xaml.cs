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

namespace LayoutCustomization
{
    /// <summary>
    /// Interaction logic for PreviewSetting.xaml
    /// </summary>
    public partial class PreviewSetting : Window
    {
        public PreviewSetting()
        {
            InitializeComponent();
            InitialiseTab();

        }

        private void InitialiseTab()
        {
           
                    colorManagementTab colorManagement = new colorManagementTab();
                    object content = colorManagement.Content;
                    colorManagement.Content = null;
                    panelColorManagementProperties.Children.Add(content as UIElement);

            spotColorsTab spotColor = new spotColorsTab();
            object contentSpotColor = spotColor.Content;
            spotColor.Content = null;
            panelSpotColorProperties.Children.Add(contentSpotColor as UIElement);


        }
    }
}
