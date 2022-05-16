using MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Music : ContentPage
	{
        string MusicURL = "https://theonebibleappstorage.blob.core.windows.net/music-uploads/As%20You%20Find%20Me%20(Live)%20-%20Hillsong%20UNITED.mp3";

        public Music ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                CrossMediaManager.Current.Play(MusicURL);
			}
          catch(Exception ex)
            {

            }
		}
    }
}