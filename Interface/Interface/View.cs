using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class View : Form
    {
        private Presenter presenter = new Presenter();

        public View()
        {
            InitializeComponent();
            textBoxCountAnimals.Text = "Animal in Zoo: " + presenter.Animals.Count;            
        }

        void buttonChooseBird_Click(object sender, EventArgs e)
        {
            presenter.AddBird();
            refreshtextBoxCountAnimals();
        }

        void buttonChooseFish_Click(object sender, EventArgs e)
        {
            presenter.AddFish();
            refreshtextBoxCountAnimals();
        }

        void buttonChooseReptilia_Click(object sender, EventArgs e)
        {
            presenter.AddReptilia();
            refreshtextBoxCountAnimals();
        }

        void refreshtextBoxCountAnimals()
        {
            textBoxCountAnimals.Text = "Animal in Zoo: " + presenter.Animals.Count;
        }
    }
}
