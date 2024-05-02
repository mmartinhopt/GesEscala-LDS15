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
    public partial class GerirServicos : Form
    {

        private Model model;

        public GerirServicos(Model model)
        {
            InitializeComponent();
            this.model = model;
        }
    }
}
