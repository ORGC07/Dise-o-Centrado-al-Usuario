using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Centrado_al_Usuario
{
    public partial class Padre : Form
    {
        public Padre()
        {
           
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Padre
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Padre";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResumeLayout(false);

        }
    }
}
