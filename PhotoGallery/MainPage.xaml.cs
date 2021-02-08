using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoGallery
{
    public partial class MainPage : ContentPage
    {
        private int currentImg;
        private List<string> images;
        public MainPage()
        {
            InitializeComponent();
            images = new List<string>();
            images.Add("https://lh3.googleusercontent.com/pw/ACtC-3cunmWjN3mV06a4Vr4DTLXXnaYhsvM6mOFl7nF8s2HPXWN-WPQvS-0UenxGx-DL-GBKuQa2PyJYulR9ryi67xux-zf97r4BGUPQqdDTbG6CkzB_WONcPrYjdhwcTH3bPQM3xv_a61EoULdBLWNGdJIBpw=w1174-h881-no?authuser=0");
            images.Add("https://lh3.googleusercontent.com/pw/ACtC-3dhV-xqG_lmCPsHvo8j2R5Q-6iSlOW6eJCDkIqqK3SaYNWCZvbswt-Bq_Ya_rI99QzPx_-jX8blGCHjakPCGaDQiQsmiRFHoM-pymIf28b44taUckySLjbKNmOb_bxUNkeekEuiTdi73wSW7RBXqgz4iw=w1174-h881-no?authuser=0");
            images.Add("https://lh3.googleusercontent.com/pw/ACtC-3c133IQsuZvIW6Nz7F8x6VM4umBBT-PVlOoX6sHsSTaOdhfLcy-rgoaSE-asEwdqqJxj02qlBl5T6Xkx1C2DZKU0cWJnclhyovBeH2Edboac_2UbS9JD2fyJNt4StbIkJa1SgNrwKMXVR_t6gr_x_Vwfw=w1174-h881-no?authuser=0");
            images.Add("https://lh3.googleusercontent.com/pw/ACtC-3dnBQvUJay2XTpWjMOrN4hwBOogqO9SoySn_11cPcjdaDNne1V1n1vLdA58pTiG9xQXsx9uWWDvrpWa4N92yvmo_BwwI6ODoXzB2ieDztVVaErpAgV4zxf7qYivvqecU6ugfJxN8hxoZIWNUVdujbMBTg=w1174-h881-no?authuser=0");
            img.Source = images[0];
            currentImg = 0;
            btnDown.IsEnabled = false;
            btnUp.IsEnabled = true;
        }

        
        private void btnUp_Clicked(object sender, EventArgs e)
        {
            currentImg++;
            img.Source = this.images[currentImg];
            if (currentImg == this.images.Count - 1)
                btnUp.IsEnabled = false;
            if (currentImg > 0)
                btnDown.IsEnabled = true;
        }

        private void btnDown_Clicked(object sender, EventArgs e)
        {
            currentImg--;
            img.Source = this.images[currentImg];
            if (currentImg == 0)
                btnDown.IsEnabled = false;
            if (currentImg < this.images.Count)
                btnUp.IsEnabled = true;
        }
    }
}
