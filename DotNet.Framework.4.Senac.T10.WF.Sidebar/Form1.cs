using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet.Framework._4.Senac.T10.WF.Sidebar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // criei uma variavel booleana que tem o valor true
        bool sidebarExpandida = true;
        bool submenuExpandido = false;

        private void dashboard_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerSubmenu.Start();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpandida)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 73)
                {
                    sidebarExpandida = false;
                    timerSidebar.Stop();
                    return;
                }

            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 280)
                {
                    sidebarExpandida = true;
                    timerSidebar.Stop();
                    return;
                }

            }
        }

        private void timerSubmenu_Tick(object sender, EventArgs e)
        {
            if(submenuExpandido)
            {
                submenu.Height -= 10;   

                if(submenu.Height <= 86)
                {
                    submenuExpandido = false;
                    timerSubmenu.Stop();
                }
            }
            else
            {
                submenu.Height += 10;

                if(submenu.Height >= 280)
                {
                    submenuExpandido = true;
                    timerSubmenu.Stop();
                
                }
               
            }
        }

    
    }
}
