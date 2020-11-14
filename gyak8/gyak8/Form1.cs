using gyak8.Abstractions;
using gyak8.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak8
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();

        private IToyFactory _factory;

        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var Toy = Factory.CreateNew();
            _toys.Add(Toy);
            Toy.Left = -Toy.Width;
            mainPanel.Controls.Add(Toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var legjobbpozi = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left>legjobbpozi)
                {
                    legjobbpozi = toy.Left;
                }
                if (legjobbpozi>1000)
                {
                    var regiball = _toys[0];
                    mainPanel.Controls.Remove(regiball);
                    _toys.Remove(regiball);
                }

            }
        }
    }
}
