using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media;

namespace MyTemplate.ViewModels {

	public class MainWindowViewModel : INotifyPropertyChanged {

		/// <summary>
		/// ctor
		/// </summary>
		public MainWindowViewModel()
		#region
		{
			var asm = Assembly.GetExecutingAssembly();
			string titleName = "";

			var versionInfo = FileVersionInfo.GetVersionInfo( asm.Location );

			titleName += Path.GetFileNameWithoutExtension( asm.Location );
			titleName += " ver.";
			titleName += versionInfo.FileVersion;

			TitleName = titleName;
		}
		#endregion


		/// <summary>
		/// タイトルバー名
		/// </summary>
		private string m_titleName = "";
		public string TitleName
		#region
		{
			get {
				return m_titleName;
			}
			set {
				if( m_titleName != value ) {
					m_titleName = value;
					RaisePropertyChanged( nameof( TitleName ) );
				}
			}
		}
		#endregion

		/// <summary>
		/// プロパティ変更通知
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;
		private void RaisePropertyChanged( string propertyname )
		#region
		{
			PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyname ) );
		}
		#endregion

	}
}
