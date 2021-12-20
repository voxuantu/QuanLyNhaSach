using System.Windows;
using System.Windows.Controls;

namespace BookStoreClone.View
{
    /// <summary>
    /// Interaction logic for QuanLyHoaDonUC.xaml
    /// </summary>
    public partial class QuanLyHoaDonUC : UserControl
    {
        private Visibility nhanvienhien { get;set; }

		public QuanLyHoaDonUC()
        {
            InitializeComponent();
        }

        private void InHoaDon_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            try
            {
			
				this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(pnlCTHD, "Hóa đơn");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }

        }

		private void btnLuuHoaDon_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            //MessageBoxResult result = MessageBox.Show("In hóa đơn để xem trước?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
            //if (result == MessageBoxResult.Yes)
            //    if (nhanvienhien==Visibility.Visible)
            //try
            //{

            //    this.IsEnabled = false;
            //    PrintDialog printDialog = new PrintDialog();
            //    if (printDialog.ShowDialog() == true)
            //    {
            //        printDialog.PrintVisual(pnlhoadon, "Hóa đơn");
            //    }
            //}
            //finally
            //{
            //    this.IsEnabled = true;
            //}

        }

		
	}
}