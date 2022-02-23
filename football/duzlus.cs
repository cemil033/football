using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Media;

namespace football
{
    public partial class duzlus : Form
    {
        public duzlus()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void duzlus_Load(object sender, EventArgs e)
        {
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);
                if (!(comboBox1.Items.Contains(region.EnglishName)))
                {
                    comboBox1.Items.Add(region.EnglishName);
                }
            }
            comboBox2.Items.Add("4-3-3");
            comboBox2.Items.Add("4-4-2");
            comboBox2.Items.Add("4-3-1-2");
            comboBox2.Items.Add("5-3-2");
            comboBox2.Items.Add("3-4-3");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                label4.Text = "F";
                label5.Text = "F";
                label6.Text = "F";
                label7.Text = "MD";
                label8.Text = "MD";
                label9.Text = "MD";
                label10.Text = "DD";
                label11.Text = "DD";
                label12.Text = "DD";
                label13.Text = "DD";
                label14.Text = "GK";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                label4.Text = "F";
                label5.Text = "F";
                label6.Text = "MD";
                label7.Text = "MD";
                label8.Text = "MD";
                label9.Text = "MD";
                label10.Text = "DD";
                label11.Text = "DD";
                label12.Text = "DD";
                label13.Text = "DD";
                label14.Text = "GK";
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                label4.Text = "F";
                label5.Text = "F";
                label6.Text = "MD";
                label7.Text = "MD";
                label8.Text = "MD";
                label9.Text = "MD";
                label10.Text = "DD";
                label11.Text = "DD";
                label12.Text = "DD";
                label13.Text = "DD";
                label14.Text = "GK";
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                label4.Text = "F";
                label5.Text = "F";
                label6.Text = "MD";
                label7.Text = "MD";
                label8.Text = "MD";
                label9.Text = "DD";
                label10.Text = "DD";
                label11.Text = "DD";
                label12.Text = "DD";
                label13.Text = "DD";
                label14.Text = "GK";
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                label4.Text = "F";
                label5.Text = "F";
                label6.Text = "F";
                label7.Text = "MD";
                label8.Text = "MD";
                label9.Text = "MD";
                label10.Text = "MD";
                label11.Text = "DD";
                label12.Text = "DD";
                label13.Text = "DD";
                label14.Text = "GK";
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                var t = new _4_3_3();
                t.label23.Text =comboBox1.SelectedItem.ToString();
                t.label1.Text = textBox14.Text;
                t.label2.Text = textBox11.Text;
                t.label4.Text= textBox17.Text;
                t.label3.Text= textBox8.Text;
                t.label6.Text= textBox15.Text;
                t.label5.Text = textBox10.Text;
                t.label8.Text = textBox16.Text;
                t.label7.Text = textBox9.Text;
                t.label10.Text = textBox18.Text;
                t.label9.Text = textBox7.Text;
                t.label12.Text= textBox20.Text;
                t.label11.Text = textBox5.Text;
                t.label14.Text = textBox19.Text;
                t.label13.Text = textBox6.Text;
                t.label16.Text = textBox21.Text;
                t.label15.Text = textBox4.Text;
                t.label18.Text = textBox22.Text;
                t.label17.Text = textBox3.Text;
                t.label20.Text = textBox24.Text;
                t.label19.Text = textBox1.Text;
                t.label22.Text = textBox23.Text;
                t.label21.Text = textBox2.Text;
                CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
                string temp="";
                foreach (CultureInfo culture in cultures)
                {
                    RegionInfo region = new RegionInfo(culture.LCID);
                    if (region.EnglishName==comboBox1.SelectedItem.ToString())
                    {
                        temp = region.TwoLetterISORegionName.ToString();
                    }
                }
                string link = "https://flagpedia.net/data/flags/w580/" + temp.ToLower() + ".png";
                t.pictureBox13.LoadAsync(link);                
                SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\User\source\repos\football\football\bin\Debug\chb.wav");
                simpleSound.Play();
                t.ShowDialog();
                if(t.DialogResult == DialogResult.Cancel)
                {
                    simpleSound.Stop();
                }
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                var t = new _4_4_2();
                t.label23.Text = comboBox1.SelectedItem.ToString();
                t.label1.Text = textBox14.Text;
                t.label2.Text = textBox11.Text;
                t.label4.Text = textBox17.Text;
                t.label3.Text = textBox8.Text;
                t.label6.Text = textBox15.Text;
                t.label5.Text = textBox10.Text;
                t.label8.Text = textBox16.Text;
                t.label7.Text = textBox9.Text;
                t.label10.Text = textBox18.Text;
                t.label9.Text = textBox7.Text;
                t.label12.Text = textBox20.Text;
                t.label11.Text = textBox5.Text;
                t.label14.Text = textBox19.Text;
                t.label13.Text = textBox6.Text;
                t.label16.Text = textBox21.Text;
                t.label15.Text = textBox4.Text;
                t.label18.Text = textBox22.Text;
                t.label17.Text = textBox3.Text;
                t.label20.Text = textBox24.Text;
                t.label19.Text = textBox1.Text;
                t.label22.Text = textBox23.Text;
                t.label21.Text = textBox2.Text;
                CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
                string temp = "";
                foreach (CultureInfo culture in cultures)
                {
                    RegionInfo region = new RegionInfo(culture.LCID);
                    if (region.EnglishName == comboBox1.SelectedItem.ToString())
                    {
                        temp = region.TwoLetterISORegionName.ToString();
                    }
                }
                string link = "https://flagpedia.net/data/flags/w580/" + temp.ToLower() + ".png";
                t.pictureBox13.LoadAsync(link);
                t.ShowDialog();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                var t = new _4_3_1_2();
                t.label23.Text = comboBox1.SelectedItem.ToString();
                t.label1.Text = textBox14.Text;
                t.label2.Text = textBox11.Text;
                t.label4.Text = textBox17.Text;
                t.label3.Text = textBox8.Text;
                t.label6.Text = textBox15.Text;
                t.label5.Text = textBox10.Text;
                t.label8.Text = textBox16.Text;
                t.label7.Text = textBox9.Text;
                t.label10.Text = textBox18.Text;
                t.label9.Text = textBox7.Text;
                t.label12.Text = textBox20.Text;
                t.label11.Text = textBox5.Text;
                t.label14.Text = textBox19.Text;
                t.label13.Text = textBox6.Text;
                t.label16.Text = textBox21.Text;
                t.label15.Text = textBox4.Text;
                t.label18.Text = textBox22.Text;
                t.label17.Text = textBox3.Text;
                t.label20.Text = textBox24.Text;
                t.label19.Text = textBox1.Text;
                t.label22.Text = textBox23.Text;
                t.label21.Text = textBox2.Text;
                CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
                string temp = "";
                foreach (CultureInfo culture in cultures)
                {
                    RegionInfo region = new RegionInfo(culture.LCID);
                    if (region.EnglishName == comboBox1.SelectedItem.ToString())
                    {
                        temp = region.TwoLetterISORegionName.ToString();
                    }
                }
                string link = "https://flagpedia.net/data/flags/w580/" + temp.ToLower() + ".png";
                t.pictureBox13.LoadAsync(link);
                t.ShowDialog();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                var t = new _5_3_2();
                t.label23.Text = comboBox1.SelectedItem.ToString();
                t.label1.Text = textBox14.Text;
                t.label2.Text = textBox11.Text;
                t.label4.Text = textBox17.Text;
                t.label3.Text = textBox8.Text;
                t.label6.Text = textBox15.Text;
                t.label5.Text = textBox10.Text;
                t.label8.Text = textBox16.Text;
                t.label7.Text = textBox9.Text;
                t.label10.Text = textBox18.Text;
                t.label9.Text = textBox7.Text;
                t.label12.Text = textBox20.Text;
                t.label11.Text = textBox5.Text;
                t.label14.Text = textBox19.Text;
                t.label13.Text = textBox6.Text;
                t.label16.Text = textBox21.Text;
                t.label15.Text = textBox4.Text;
                t.label18.Text = textBox22.Text;
                t.label17.Text = textBox3.Text;
                t.label20.Text = textBox24.Text;
                t.label19.Text = textBox1.Text;
                t.label22.Text = textBox23.Text;
                t.label21.Text = textBox2.Text;
                CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
                string temp = "";
                foreach (CultureInfo culture in cultures)
                {
                    RegionInfo region = new RegionInfo(culture.LCID);
                    if (region.EnglishName == comboBox1.SelectedItem.ToString())
                    {
                        temp = region.TwoLetterISORegionName.ToString();
                    }
                }
                string link = "https://flagpedia.net/data/flags/w580/" + temp.ToLower() + ".png";
                t.pictureBox13.LoadAsync(link);
                t.ShowDialog();
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                var t = new _3_4_3();
                t.label23.Text = comboBox1.SelectedItem.ToString();
                t.label1.Text = textBox14.Text;
                t.label2.Text = textBox11.Text;
                t.label4.Text = textBox17.Text;
                t.label3.Text = textBox8.Text;
                t.label6.Text = textBox15.Text;
                t.label5.Text = textBox10.Text;
                t.label8.Text = textBox16.Text;
                t.label7.Text = textBox9.Text;
                t.label10.Text = textBox18.Text;
                t.label9.Text = textBox7.Text;
                t.label12.Text = textBox20.Text;
                t.label11.Text = textBox5.Text;
                t.label14.Text = textBox19.Text;
                t.label13.Text = textBox6.Text;
                t.label16.Text = textBox21.Text;
                t.label15.Text = textBox4.Text;
                t.label18.Text = textBox22.Text;
                t.label17.Text = textBox3.Text;
                t.label20.Text = textBox24.Text;
                t.label19.Text = textBox1.Text;
                t.label22.Text = textBox23.Text;
                t.label21.Text = textBox2.Text;
                CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
                string temp = "";
                foreach (CultureInfo culture in cultures)
                {
                    RegionInfo region = new RegionInfo(culture.LCID);
                    if (region.EnglishName == comboBox1.SelectedItem.ToString())
                    {
                        temp = region.TwoLetterISORegionName.ToString();
                    }
                }
                string link = "https://flagpedia.net/data/flags/w580/" + temp.ToLower() + ".png";
                t.pictureBox13.LoadAsync(link);
                t.ShowDialog();
            }
        }
    }
}
