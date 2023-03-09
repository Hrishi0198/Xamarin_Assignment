using System;

using Xamarin.Forms;

namespace SampleApp.Day7Assignment.Interface
{
	public class ISQLiteDb : ContentPage
	{
		public ISQLiteDb ()
		{
            SQLiteAsyncConnection GetConnection();
            SQLiteAsyncConnection GetConnectionSearch();
        
		}
	}
}


