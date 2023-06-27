namespace CityCaptcha
{
    public partial class Form1 : Form
    {
        int imageCode, cityCode;
        int score_point = 9;
        public Form1()
        {
            InitializeComponent();
            score.Text = score_point.ToString();
        }

        private void p_ardebil_Click(object sender, EventArgs e)
        {
            imageCode = 1;
            if (imageCode == 1 && cityCode == 1)
            {
                p_ardebil.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_ardebil_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 1;
        }

        private void p_boshehr_Click(object sender, EventArgs e)
        {
            imageCode = 2;
            if (imageCode == 2 && cityCode == 2)
            {
                p_boshehr.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_boshehr_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 2;
        }

        private void p_esfarayen_Click(object sender, EventArgs e)
        {
            imageCode = 3;
            if (imageCode == 3 && cityCode == 3)
            {
                p_esfarayen.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_esfarayen_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 3;
        }

        private void p_gorgan_Click(object sender, EventArgs e)
        {
            imageCode = 4;
            if (imageCode == 4 && cityCode == 4)
            {
                p_gorgan.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_golestan_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 4;
        }

        private void p_khorasanR_Click(object sender, EventArgs e)
        {
            imageCode = 5;
            if (imageCode == 5 && cityCode == 5)
            {
                p_khorasanR.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_khorasanR_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 5;
        }

        private void p_tabriz_Click(object sender, EventArgs e)
        {
            imageCode = 6;
            if (imageCode == 6 && cityCode == 6)
            {
                p_tabriz.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_tabriz_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 6;
        }

        private void p_tehran_Click(object sender, EventArgs e)
        {
            imageCode = 7;
            if (imageCode == 7 && cityCode == 7)
            {
                p_tehran.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_tehran_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 7;
        }

        private void p_yazd_Click(object sender, EventArgs e)
        {
            imageCode = 8;
            if (imageCode == 8 && cityCode == 8)
            {
                p_yazd.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void p_khozestan_Click(object sender, EventArgs e)
        {
            imageCode = 9;
            if (imageCode == 9 && cityCode == 9)
            {
                p_khozestan.Visible = false;
                if (p_ardebil.Visible == false &&
                    p_boshehr.Visible == false &&
                    p_gorgan.Visible == false &&
                    p_khozestan.Visible == false &&
                    p_tabriz.Visible == false &&
                    p_khorasanR.Visible == false &&
                    p_esfarayen.Visible == false &&
                    p_tehran.Visible == false &&
                    p_yazd.Visible == false)
                {
                    MessageBox.Show($"شما برنده شدید امتیاز شما : {score_point}");
                }
            }
            else
            {
                if (score_point != 0)
                {
                    score_point -= 1;
                    score.Text = score_point.ToString();
                }
                else if (score_point <= 0)
                {
                    MessageBox.Show("باختی !");
                }
            }
        }

        private void rbtn_yazd_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 8;
        }

        private void rbtn_khozestan_CheckedChanged(object sender, EventArgs e)
        {
            cityCode = 9;
        }
    }
}