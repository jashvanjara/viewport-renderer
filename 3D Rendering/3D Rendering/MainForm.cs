using System;
using Eto.Forms;
using Eto.Drawing;
using Eto.Gl;

namespace _3D_Rendering
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            Title = "My Eto Form";
            ClientSize = new Size(400, 350);
            var gl = new GLSurface();
            

            Content = new StackLayout
            {
                Padding = 10,
                Items =
                {
                    "Hello World!",
                    gl
					// add more controls here
				}
            };

            // create a few commands that can be used for the menu and toolbar
            var clickMe = new Command { MenuText = "Click Me!", ToolBarText = "Click Me!" };
            clickMe.Executed += (sender, e) => MessageBox.Show(this, "I was clicked!");

            var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
            quitCommand.Executed += (sender, e) => Application.Instance.Quit();

            var aboutCommand = new Command { MenuText = "About..." };
            aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

            // create menu
            Menu = new MenuBar
            {
                Items =
                {
					// File submenu
					new ButtonMenuItem { Text = "&File", Items = { clickMe } },
					// new ButtonMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new ButtonMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
                ApplicationItems =
                {
					// application (OS X) or file menu (others)
					new ButtonMenuItem { Text = "&Preferences..." },
                },
                QuitItem = quitCommand,
                AboutItem = aboutCommand
            };

            // create toolbar			
            ToolBar = new ToolBar { Items = { clickMe } };
        }
    }
}
