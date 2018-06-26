using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Todo
{
	public class App : Application
	{
		static TodoItemDatabase database;

		public App()
		{
			Resources = new ResourceDictionary();
            Resources.Add("primaryBlue", Color.FromHex("4767CA"));
            Resources.Add("primaryDarkBlue", Color.FromHex("1C29DB"));

			var nav = new NavigationPage(new TodoListPage());
			nav.BarBackgroundColor = (Color)App.Current.Resources["primaryBlue"];
			nav.BarTextColor = Color.White;

			MainPage = nav;
		}

		public static TodoItemDatabase Database
		{
			get
			{
				if (database == null)
				{
					
					var databasePath = DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db");
					Debug.WriteLine("databasePath: " + databasePath);
					database = TodoItemDatabase.Create(databasePath);
				}
				return database;
			}
		}

		public int ResumeAtTodoId { get; set; }

		protected override void OnStart()
		{
			
		}

		protected override void OnSleep()
		{
			
		}

		protected override void OnResume()
		{
			
		}
	}
}

