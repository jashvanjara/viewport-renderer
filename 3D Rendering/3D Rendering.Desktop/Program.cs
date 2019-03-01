using Eto.Gl;
using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3D_Rendering.Desktop
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var platform = new Eto.WinForms.Platform();
            platform.Add<GLSurface.IHandler>(() => new Eto.Gl.Windows.WinGLSurfaceHandler());

            new Application(platform).Run(new MainForm());
        }
    }
}