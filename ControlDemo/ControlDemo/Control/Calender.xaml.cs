using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlDemo.Control
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calender : Grid
	{
		public Calender ()
		{
			InitializeComponent ();
		}
	}
}