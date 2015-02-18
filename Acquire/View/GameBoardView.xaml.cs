﻿using Acquire.Model;
using Acquire.ViewModel;
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

namespace Acquire.View
{
	/// <summary>
	/// Interaction logic for GameBoardView.xaml
	/// </summary>
	public partial class GameBoardView : UserControl
	{
		public GameBoardView(GameBoardViewModel VM)
		{
			this.DataContext = VM;
			
			InitializeComponent();
		}

		internal GameBoardView()
		{
			this.DataContext = new GameBoardViewModel( new GameEngine());
			InitializeComponent();
		}
	}
}
