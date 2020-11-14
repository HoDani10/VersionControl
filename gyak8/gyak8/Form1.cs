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

        private Toy _nextToy;

        private IToyFactory _factory;

        public IToyFactory Factory
        {
            get { return _factory; }
            set 
            {
            _factory = value;
            DisplayNext();
            }
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

        private void buttoncar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void buttonball_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
            Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);



        }
}
