﻿using System;
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
using Acquire.ViewModel;

namespace Acquire.View
{
	/// <summary>
	/// Interaction logic for GameBoardSlotView.xaml
	/// </summary>
	public partial class GameBoardSlotView : UserControl
	{
		public GameBoardSlotView()
		{
			InitializeComponent();
		}

		private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
		{
			if (this.DataContext is GameBoardSlotViewModel)
			{
				((GameBoardSlotViewModel) DataContext).IsFull = !((GameBoardSlotViewModel) DataContext).IsFull;
			}
		}
	}
}
