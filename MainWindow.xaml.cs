/*
Ethan Shipston
2/15/2018
u1_03_ShipstonComputer
A program that tells you about a few computer part costs.
*/
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

namespace u1_03_ShipstonComputer
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

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "GIGABYTE GA-B250M-DS3H (rev. 1.0) LGA 1151 Intel B250 HDMI SATA 6Gb/s USB 3.1" + System.Environment.NewLine + "Micro ATX Intel Motherboard";
            BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImageCompressAll1280/13-128-980_R01.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.com/Product/Product.aspx?Item=N82E16813128980";
            txtPrice.Text = "Price: 59.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Visible;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Hidden;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnGPU_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "GIGABYTE GeForce GTX 1050 OC Low Profile 2GB Video Card, GBTGV-N1050OC-2GL";
            BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImageCompressAll1280/14-125-951-Z01.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.com/Product/Product.aspx?Item=N82E16814125951";
            txtPrice.Text = "Price: 149.99$";
            btnCpu1.Visibility = Visibility.Visible;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Hidden;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnRAM_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "CORSAIR Vengeance LPX 16GB (2 x 8GB) 288-Pin DDR4 SDRAM DDR4 3000 (PC4 24000)" + System.Environment.NewLine + "Desktop Memory Model CMK16GX4M2L3000C15";
            BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImageCompressAll1280/20-236-282-Z01.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.com/Product/Product.aspx?Item=N82E16820236282";
            txtPrice.Text = "Price: 199.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Visible;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Hidden;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnCase_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Rosewill FBM-X1 Black Steel / Plastic ATX Mini Tower Case with Side Panel Window";
            BitmapImage bi = new BitmapImage(new Uri("http://assets.coolermaster.com/global/uploadfile/fileproduct_list/P13032100103176/PRDPIC/290_13_cf4a8c68b75b54b35c6525deec1c6ee5_1363828660.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: http://www.coolermaster.com/case/mid-tower/k350-rc-k350-kwn2-en/";
            txtPrice.Text = "Price: 29.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Visible;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Hidden;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnCost_Click(object sender, RoutedEventArgs e)
        {
            txtTotalPrice.Visibility = Visibility.Visible;
            btnGoBack.Visibility = Visibility.Visible;
        }

        private void btnCpu_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Intel® Core™ i5-6500 Skylake Processor - UP TO 3.2GHZ - BX80662I56500";
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/gallery/large/GNT-103000693_gallery01x_JT_gl_9788450.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117563";
            txtPrice.Text = "Price: 259.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnCpu2_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Intel® Core™ i5-6500 Skylake Processor - UP TO 3.2GHZ - BX80662I56500";
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/gallery/large/GNT-103000693_gallery01x_JT_gl_9788450.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117563";
            txtPrice.Text = "Price: 259.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnCpu3_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Intel® Core™ i5-6500 Skylake Processor - UP TO 3.2GHZ - BX80662I56500";
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/gallery/large/GNT-103000693_gallery01x_JT_gl_9788450.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117563";
            txtPrice.Text = "Price: 259.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnCpu4_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Intel® Core™ i5-6500 Skylake Processor - UP TO 3.2GHZ - BX80662I56500";
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/gallery/large/GNT-103000693_gallery01x_JT_gl_9788450.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117563";
            txtPrice.Text = "Price: 259.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "CORSAIR CX series CX550 550W ATX12V 80 PLUS BRONZE Certified Active PFC Power Supply";
            BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/NeweggImage/ProductImage/17-139-202-V01.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16817139202&ignorebbr=1";
            txtPrice.Text = "Price: 79.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Visible;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Hidden;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnStorage_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Seagate BarraCuda ST2000DM006 2TB 64MB Cache SATA 6.0Gb/s 3.5 Inch Hard Drive Bare Drive";
            BitmapImage bi = new BitmapImage(new Uri("https://images10.newegg.com/ProductImage/22-178-993-V01.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16822178993&cm_re=sata_hdd-_-22-178-993-_-Product";
            txtPrice.Text = "Price: 69.49$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Visible;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Hidden;
        }

        private void btnCpu5_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Intel® Core™ i5-6500 Skylake Processor - UP TO 3.2GHZ - BX80662I56500";
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/gallery/large/GNT-103000693_gallery01x_JT_gl_9788450.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117563";
            txtPrice.Text = "Price: 259.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnCpu6_Click(object sender, RoutedEventArgs e)
        {
            lblComponent.Content = "Intel® Core™ i5-6500 Skylake Processor - UP TO 3.2GHZ - BX80662I56500";
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/gallery/large/GNT-103000693_gallery01x_JT_gl_9788450.jpg"));
            imgPicture.Source = bi;
            txtLink.Text = "Link to item: https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117563";
            txtPrice.Text = "Price: 259.99$";
            btnCpu1.Visibility = Visibility.Hidden;
            btnCpu2.Visibility = Visibility.Hidden;
            btnCpu3.Visibility = Visibility.Hidden;
            btnCpu4.Visibility = Visibility.Hidden;
            btnCpu5.Visibility = Visibility.Hidden;
            btnCpu6.Visibility = Visibility.Hidden;
            btnGPU.Visibility = Visibility.Visible;
            btnMotherboard.Visibility = Visibility.Visible;
            btnRAM.Visibility = Visibility.Visible;
            btnCase.Visibility = Visibility.Visible;
            btnPower.Visibility = Visibility.Visible;
            btnStorage.Visibility = Visibility.Visible;
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            txtTotalPrice.Visibility = Visibility.Hidden;
            btnGoBack.Visibility = Visibility.Hidden;
        }
    }
}