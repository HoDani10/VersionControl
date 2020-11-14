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
        private List<Ball> _balls = new List<Ball>();

        private BallFactory _factory;

        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var Ball = Factory.CreateNew();
            _balls.Add(Ball);
            Ball.Left = -Ball.Width;
            mainPanel.Controls.Add(Ball);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var legjobbpozi = 0;
            foreach (var ball in _balls)
            {
                ball.MoveBall();
                if (ball.Left>legjobbpozi)
                {
                    legjobbpozi = ball.Left;
                }
                if (legjobbpozi>1000)
                {
                    var regiball = _balls[0];
                    mainPanel.Controls.Remove(regiball);
                    _balls.Remove(regiball);
                }

            }
        }
    }
}
