﻿using BookStoreClone.ViewModel;
using System.Windows.Controls;

namespace BookStoreClone.View
{
    public partial class TimKiemSachUC : UserControl
    {
        public TimKiemSachUC()
        {
            InitializeComponent();
            this.DataContext = new TimKiemSachViewModel();
        }

		private void EventTrigger_Changed(object sender, System.EventArgs e)
		{
		}
	}
}