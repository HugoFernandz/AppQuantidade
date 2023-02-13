using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        int qtdd = 1;
        public MainPage()
        {
            InitializeComponent();


        }

        private void btnAumentar(object sender, EventArgs e)
        {
            qtdd++;
            lblQuantidade.Text = qtdd.ToString();
        }

        private void btnDiminuir(object sender, EventArgs e)
        {
            if (qtdd != 0)
            {
                qtdd--;
                lblQuantidade.Text = qtdd.ToString();
            }
        }
    }
}
