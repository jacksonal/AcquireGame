using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acquire.ViewModel
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Called when [property changed].
		/// </summary>
		/// <param name="PropName">Name of the property.</param>
		protected void OnPropertyChanged(string PropName)
		{
			if(PropertyChanged!=null)
			{
				PropertyChangedEventArgs args = new PropertyChangedEventArgs(PropName);
				PropertyChanged(this, args);
			}
		}
	}
}
