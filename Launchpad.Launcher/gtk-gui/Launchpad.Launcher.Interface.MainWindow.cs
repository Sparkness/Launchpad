﻿
// This file has been generated by the GUI designer. Do not modify.

using Gdk;
using Gtk;
using Stetic;
using Image = Gtk.Image;

namespace Launchpad.Launcher.Interface
{
	public sealed partial class MainWindow
	{
		private UIManager UIManager;

		private Action menuAction;

		private Action repairGameAction;

		private VBox vbox1;

		private MenuBar menuBar;

		private HBox hbox2;

		private VBox browserContainer;

		private Alignment alignment2;

		private ScrolledWindow browserWindow;

		private Alignment alignment5;

		private Image gameBanner;

		private Alignment alignment1;

		private Label indicatorLabel;

		private HBox hbox3;

		private Alignment alignment4;

		private ProgressBar mainProgressBar;

		private HBox hbox4;

		private Alignment alignment3;

		private Button primaryButton;

		private void Build ()
		{
			Gui.Initialize (this);

			// Widget Launchpad.Launcher.UnixUI.MainWindow
			this.UIManager = new UIManager ();
			ActionGroup w1 = new ActionGroup ("Default");

			this.menuAction = new Action("menuAction", LocalizationCatalog.GetString("Menu"), null, null)
			{
				ShortLabel = LocalizationCatalog.GetString("Menu")
			};
			w1.Add (this.menuAction, null);

			this.repairGameAction = new Action(
				"repairGameAction",
				LocalizationCatalog.GetString("Repair Game"),
				LocalizationCatalog.GetString("Starts a repair process for the installed game."),
				"gtk-refresh")
			{
				ShortLabel = LocalizationCatalog.GetString("Repair Game")
			};
			w1.Add (this.repairGameAction, null);

			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "Launchpad.Launcher.UnixUI.MainWindow";
			this.Title = LocalizationCatalog.GetString ("Launchpad - <GameName>");
			this.Icon = Pixbuf.LoadFromResource ("Launchpad.Launcher.Resources.RocketIcon.ico");
			this.WindowPosition = (WindowPosition)4;
			this.DefaultWidth = 755;
			this.DefaultHeight = 412;

			// Container child Launchpad.Launcher.UnixUI.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new VBox
			{
				Name = "vbox1",
				Spacing = 6
			};

			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menuBar'><menu name='menuAction' action='menuAction'><menuitem name='repairGameAction' action='repairGameAction'/></menu></menubar></ui>");
			this.menuBar = (MenuBar)this.UIManager.GetWidget ("/menuBar");
			this.menuBar.Name = "menuBar";
			this.vbox1.Add (this.menuBar);

			Box.BoxChild w2 = (Box.BoxChild)this.vbox1 [this.menuBar];
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;

			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new HBox
			{
				Name = "hbox2",
				Spacing = 6,
				BorderWidth = 4
			};

			// Container child hbox2.Gtk.Box+BoxChild
			this.browserContainer = new VBox
			{
				Name = "browserContainer",
				Spacing = 6
			};

			// Container child browserContainer.Gtk.Box+BoxChild
			this.alignment2 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				WidthRequest = 300,
				Name = "alignment2"
			};

			// Container child alignment2.Gtk.Container+ContainerChild
			this.browserWindow = new ScrolledWindow
			{
				WidthRequest = 290,
				HeightRequest = 300,
				CanFocus = true,
				Name = "browserWindow",
				ShadowType = ShadowType.In
			};
			this.alignment2.Add (this.browserWindow);
			this.browserContainer.Add (this.alignment2);

			Box.BoxChild w4 = (Box.BoxChild)this.browserContainer [this.alignment2];
			w4.Position = 0;
			this.hbox2.Add (this.browserContainer);

			Box.BoxChild w5 = (Box.BoxChild)this.hbox2 [this.browserContainer];
			w5.Position = 0;
			w5.Expand = false;

			// Container child hbox2.Gtk.Box+BoxChild
			this.alignment5 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment5"
			};

			// Container child alignment5.Gtk.Container+ContainerChild
			this.gameBanner = new Image
			{
				WidthRequest = 450,
				HeightRequest = 300,
				Name = "gameBanner",
				Pixbuf = Pixbuf.LoadFromResource("Launchpad.Launcher.Resources.RocketIcon.ico")
			};
			this.alignment5.Add (this.gameBanner);
			this.hbox2.Add (this.alignment5);

			Box.BoxChild w7 = (Box.BoxChild)this.hbox2 [this.alignment5];
			w7.Position = 1;
			this.vbox1.Add (this.hbox2);

			Box.BoxChild w8 = (Box.BoxChild)this.vbox1 [this.hbox2];
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;

			// Container child vbox1.Gtk.Box+BoxChild
			this.alignment1 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment1",
				LeftPadding = 6
			};

			// Container child alignment1.Gtk.Container+ContainerChild
			this.indicatorLabel = new Label
			{
				Name = "indicatorLabel",
				Xalign = 0F,
				LabelProp = LocalizationCatalog.GetString("Idle")
			};
			this.alignment1.Add (this.indicatorLabel);
			this.vbox1.Add (this.alignment1);

			Box.BoxChild w10 = (Box.BoxChild)this.vbox1 [this.alignment1];
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;

			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new HBox
			{
				Name = "hbox3",
				Spacing = 6,
				BorderWidth = 4
			};

			// Container child hbox3.Gtk.Box+BoxChild
			this.alignment4 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				Name = "alignment4"
			};

			// Container child alignment4.Gtk.Container+ContainerChild
			this.mainProgressBar = new ProgressBar
			{
				Name = "mainProgressBar"
			};
			this.alignment4.Add (this.mainProgressBar);
			this.hbox3.Add (this.alignment4);

			Box.BoxChild w12 = (Box.BoxChild)this.hbox3 [this.alignment4];
			w12.Position = 0;

			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox4 = new HBox
			{
				Name = "hbox4",
				Spacing = 6
			};

			// Container child hbox4.Gtk.Box+BoxChild
			this.alignment3 = new Alignment(0.5F, 0.5F, 1F, 1F)
			{
				WidthRequest = 100,
				Name = "alignment3"
			};

			// Container child alignment3.Gtk.Container+ContainerChild
			this.primaryButton = new Button
			{
				Sensitive = false,
				CanDefault = true,
				CanFocus = true,
				Name = "primaryButton",
				UseUnderline = true,
				Label = LocalizationCatalog.GetString("Inactive")
			};
			this.alignment3.Add (this.primaryButton);
			this.hbox4.Add (this.alignment3);

			Box.BoxChild w14 = (Box.BoxChild)this.hbox4 [this.alignment3];
			w14.Position = 0;
			this.hbox3.Add (this.hbox4);

			Box.BoxChild w15 = (Box.BoxChild)this.hbox3 [this.hbox4];
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox1.Add (this.hbox3);

			Box.BoxChild w16 = (Box.BoxChild)this.vbox1 [this.hbox3];
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;

			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.primaryButton.HasDefault = true;
			this.Show ();
			this.DeleteEvent += OnDeleteEvent;
			this.repairGameAction.Activated += this.OnRepairGameActionActivated;
			this.primaryButton.Clicked += this.OnPrimaryButtonClicked;
		}
	}
}
