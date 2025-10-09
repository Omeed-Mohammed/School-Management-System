using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Dashboard.controls
{
    public partial class ucCard : UserControl
    {
        #region Properies
        public string Title
        { 
            get=> lblTitle.Text; 
            set => lblTitle.Text = value; 
        }

        public int Value
        {
            get => int.Parse(lblCount.Text);
            set => lblCount.Text = value.ToString();
        }

        public Image Icon
        {
            get => pbImage.Image;
            set => pbImage.Image = value;
        }

        #endregion


        public ucCard()
        {
            InitializeComponent();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(240, 240, 240);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.White;
        }
    }
}
