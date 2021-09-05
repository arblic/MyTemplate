using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MyTemplate {

	/// <summary>
	/// App.xaml の相互作用ロジック
	/// </summary>
	public partial class App : Application {

		/// <summary>
		/// 開始オーバーライド
		/// </summary>
		protected override void OnStartup( StartupEventArgs e )
		#region
		{
			/* 多重起動を禁止する場合 */
			/*
			var mutex = new Mutex( false, Assembly.GetExecutingAssembly().GetName().Name );
			if( !mutex.WaitOne( 0, false ) ) {
				MessageBox.Show( "このアプリケーションは多重起動出来ません。" );
				Shutdown();
			}
			*/
		}
		#endregion
	}
}
