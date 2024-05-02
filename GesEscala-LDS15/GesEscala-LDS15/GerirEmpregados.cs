using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEscala_LDS15
{
    public partial class GerirEmpregados : Form
    {

        private Model model;

        public GerirEmpregados(Model model)
        {
            InitializeComponent();
            this.model = model; // Recebe o Model
        }
    }
}
