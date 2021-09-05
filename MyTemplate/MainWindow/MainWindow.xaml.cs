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

using MyTemplate.ViewModels;

namespace MyTemplate.Views {

	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window {

		/// <summary>
		/// ctor
		/// </summary>
		public MainWindow()
		#region
		{
			InitializeComponent();
		}
		#endregion

		/// <summary>
		/// ビューモデル
		/// </summary>
		public MainWindowViewModel ViewModel => DataContext as MainWindowViewModel;

	}
}
