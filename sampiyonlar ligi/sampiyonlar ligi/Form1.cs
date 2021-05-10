using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampiyonlar_ligi
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }
        int bayernpuan = 0;
        int ajaxpuan = 0;
        int kievpuan = 0;
        int ferenpuan = 0;

        int sevillanpuan = 0;
        int shakhtarnpuan = 0;
        int redbullpuan = 0;
        int rennespuan = 0;

        int realpuan = 0;
        int dortmundpuan = 0;
        int krasnodarpuan = 0;
        int midtypuan = 0;

        int liverpuan = 0;
        int atleticopuan = 0;
        int interpuan = 0;
        int gspuan = 0;

        int juvepuan = 0;
        int unitedpuan = 0;
        int olimpuan = 0;
        int möncpuan = 0;

        int parispuan = 0;
        int citypuan = 0;
        int laziopuan = 0;
        int clubpuan = 0;

        int zenitpuan = 0;
        int chelseapuan = 0;
        int leipziguan = 0;
        int marseipuan = 0;

        int portopuan = 0;
        int barcepuan = 0;
        int atalantapuan = 0;
        int moskovapuan = 0;

        int av1 = 0;
        int av2 = 0;
        int av3 = 0;
        int av4 = 0;
        int av5 = 0;
        int av6 = 0;
        int av7 = 0;
        int av8 = 0;
        int av9 = 0;
        int av10 = 0;
        int av11 = 0;
        int av12 = 0;

        int av13 = 0;
        int av14 = 0;
        int av15 = 0;
        int av16 = 0;
        int av17 = 0;
        int av18 = 0;
        int av19 = 0;
        int av20 = 0;
        int av21 = 0;
        int av22 = 0;
        int av23 = 0;
        int av24 = 0;

        int av25 = 0;
        int av26= 0;
        int av27= 0;
        int av28= 0;
        int av29= 0;
        int av30= 0;
        int av31= 0;
        int av32= 0;



        Random rd = new Random();

        private void button3_Click(object sender, EventArgs e)
        {
            label73.Text = rd.Next(0, 9).ToString();
            label74.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label73.Text) > Convert.ToInt32(label74.Text))
            {
                bayernpuan += 3;
                label9.Text = bayernpuan.ToString();
            }
            else if (Convert.ToInt32(label73.Text) == Convert.ToInt32(label74.Text))
            {
                bayernpuan += 1;
                ajaxpuan += 1;
                label9.Text = bayernpuan.ToString();
                label10.Text = ajaxpuan.ToString();
            }
            else
            {
                ajaxpuan += 3;
                label10.Text = ajaxpuan.ToString();
            }

            av1 = Convert.ToInt32(label73.Text) - Convert.ToInt32(label74.Text);
            label162.Text = av1.ToString();

            av2 = Convert.ToInt32(label74.Text) - Convert.ToInt32(label73.Text);
            label170.Text = av2.ToString();

            label75.Text = rd.Next(0, 9).ToString();
            label85.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label75.Text) > Convert.ToInt32(label85.Text))
            {
                kievpuan += 3;
                label11.Text = kievpuan.ToString();
            }
            else if (Convert.ToInt32(label75.Text) == Convert.ToInt32(label85.Text))
            {
                kievpuan += 1;
                ferenpuan += 1;
                label11.Text = kievpuan.ToString();
                label12.Text = ferenpuan.ToString();
            }
            else
            {
                ferenpuan += 3;
                label12.Text = ferenpuan.ToString();
            }

            av3 = Convert.ToInt32(label75.Text) - Convert.ToInt32(label85.Text);
            label172.Text = av3.ToString();

            av4 = Convert.ToInt32(label85.Text) - Convert.ToInt32(label75.Text);
            label171.Text = av4.ToString();

            label121.Text = rd.Next(0, 9).ToString();
            label122.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label121.Text) > Convert.ToInt32(label122.Text))
            {
                sevillanpuan += 3;
                label16.Text = sevillanpuan.ToString();
            }
            else if (Convert.ToInt32(label121.Text) == Convert.ToInt32(label122.Text))
            {
                sevillanpuan += 1;
                shakhtarnpuan += 1;
                label16.Text = sevillanpuan.ToString();
                label15.Text = shakhtarnpuan.ToString();
            }
            else
            {
                shakhtarnpuan += 3;
                label15.Text = shakhtarnpuan.ToString();
            }

            av5 = Convert.ToInt32(label121.Text) - Convert.ToInt32(label122.Text);
            label181.Text = av5.ToString();

            av6 = Convert.ToInt32(label122.Text) - Convert.ToInt32(label121.Text);
            label182.Text = av6.ToString();

            label123.Text = rd.Next(0, 9).ToString();
            label157.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label123.Text) > Convert.ToInt32(label157.Text))
            {
                redbullpuan += 3;
                label14.Text = redbullpuan.ToString();
            }
            else if (Convert.ToInt32(label123.Text) == Convert.ToInt32(label157.Text))
            {
                redbullpuan += 1;
                shakhtarnpuan += 1;
                label14.Text = redbullpuan.ToString();
                label13.Text = rennespuan.ToString();
            }
            else
            {
                rennespuan += 3;
                label13.Text = rennespuan.ToString();
            }

            av7 = Convert.ToInt32(label123.Text) - Convert.ToInt32(label157.Text);
            label183.Text = av7.ToString();

            av8 = Convert.ToInt32(label157.Text) - Convert.ToInt32(label123.Text);
            label184.Text = av8.ToString();

            label113.Text = rd.Next(0, 9).ToString();
            label114.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label113.Text) > Convert.ToInt32(label114.Text))
            {
                realpuan += 3;
                label24.Text = realpuan.ToString();
            }
            else if (Convert.ToInt32(label113.Text) == Convert.ToInt32(label114.Text))
            {
                realpuan += 1;
                dortmundpuan += 1;
                label24.Text = realpuan.ToString();
                label23.Text = dortmundpuan.ToString();
            }
            else
            {
                dortmundpuan += 3;
                label23.Text = dortmundpuan.ToString();
            }

            av9 = Convert.ToInt32(label113.Text) - Convert.ToInt32(label114.Text);
            label185.Text = av9.ToString();

            av10 = Convert.ToInt32(label114.Text) - Convert.ToInt32(label113.Text);
            label186.Text = av10.ToString();

            label115.Text = rd.Next(0, 9).ToString();
            label116.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label115.Text) > Convert.ToInt32(label116.Text))
            {
                krasnodarpuan += 3;
                label22.Text = krasnodarpuan.ToString();
            }
            else if (Convert.ToInt32(label115.Text) == Convert.ToInt32(label116.Text))
            {
                krasnodarpuan += 1;
                midtypuan += 1;
                label22.Text = krasnodarpuan.ToString();
                label21.Text = midtypuan.ToString();
            }
            else
            {
                midtypuan += 3;
                label21.Text = midtypuan.ToString();
            }

            av11 = Convert.ToInt32(label115.Text) - Convert.ToInt32(label116.Text);
            label187.Text = av11.ToString();

            av12 = Convert.ToInt32(label116.Text) - Convert.ToInt32(label115.Text);
            label188.Text = av12.ToString();

            label129.Text = rd.Next(0, 9).ToString();
            label130.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label129.Text) > Convert.ToInt32(label130.Text))
            {
                liverpuan += 3;
                label32.Text = liverpuan.ToString();
            }
            else if (Convert.ToInt32(label129.Text) == Convert.ToInt32(label130.Text))
            {
                liverpuan += 1;
                atleticopuan += 1;
                label32.Text = liverpuan.ToString();
                label31.Text = atleticopuan.ToString();
            }
            else
            {
                atleticopuan += 3;
                label31.Text = atleticopuan.ToString();
            }

            av13 = Convert.ToInt32(label129.Text) - Convert.ToInt32(label130.Text);
            label189.Text = av13.ToString();

            av14 = Convert.ToInt32(label130.Text) - Convert.ToInt32(label129.Text);
            label190.Text = av14.ToString();

            label131.Text = rd.Next(0, 9).ToString();
            label132.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label131.Text) > Convert.ToInt32(label132.Text))
            {
                interpuan += 3;
                label30.Text = interpuan.ToString();
            }
            else if (Convert.ToInt32(label131.Text) == Convert.ToInt32(label132.Text))
            {
                interpuan += 1;
                gspuan += 1;
                label30.Text = interpuan.ToString();
                label29.Text = gspuan.ToString();
            }
            else
            {
                gspuan += 3;
                label29.Text = gspuan.ToString();
            }

            av15 = Convert.ToInt32(label131.Text) - Convert.ToInt32(label132.Text);
            label191.Text = av15.ToString();

            av16 = Convert.ToInt32(label132.Text) - Convert.ToInt32(label131.Text);
            label192.Text = av16.ToString();

            label137.Text = rd.Next(0, 9).ToString();
            label138.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label137.Text) > Convert.ToInt32(label138.Text))
            {
                juvepuan += 3;
                label40.Text = juvepuan.ToString();
            }
            else if (Convert.ToInt32(label137.Text) == Convert.ToInt32(label138.Text))
            {
                juvepuan += 1;
                unitedpuan += 1;
                label40.Text = juvepuan.ToString();
                label39.Text = unitedpuan.ToString();
            }
            else
            {
                unitedpuan += 3;
                label39.Text = unitedpuan.ToString();
            }

            av17 = Convert.ToInt32(label137.Text) - Convert.ToInt32(label138.Text);
            label173.Text = av17.ToString();

            av18 = Convert.ToInt32(label138.Text) - Convert.ToInt32(label137.Text);
            label174.Text = av18.ToString();

            label139.Text = rd.Next(0, 9).ToString();
            label140.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label139.Text) > Convert.ToInt32(label140.Text))
            {
                olimpuan += 3;
                label38.Text = olimpuan.ToString();
            }
            else if (Convert.ToInt32(label139.Text) == Convert.ToInt32(label140.Text))
            {
                olimpuan += 1;
                möncpuan += 1;
                label38.Text = olimpuan.ToString();
                label37.Text = möncpuan.ToString();
            }
            else
            {
                möncpuan += 3;
                label37.Text = möncpuan.ToString();
            }

            av19 = Convert.ToInt32(label139.Text) - Convert.ToInt32(label140.Text);
            label176.Text = av19.ToString();

            av20 = Convert.ToInt32(label140.Text) - Convert.ToInt32(label139.Text);
            label175.Text = av20.ToString();

            label104.Text = rd.Next(0, 9).ToString();
            label103.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label104.Text) > Convert.ToInt32(label103.Text))
            {
                parispuan += 3;
                label48.Text = parispuan.ToString();
            }
            else if (Convert.ToInt32(label104.Text) == Convert.ToInt32(label103.Text))
            {
                parispuan += 1;
                citypuan += 1;
                label48.Text = parispuan.ToString();
                label47.Text = citypuan.ToString();
            }
            else
            {
                citypuan += 3;
                label47.Text = citypuan.ToString();
            }

            av21 = Convert.ToInt32(label104.Text) - Convert.ToInt32(label103.Text);
            label177.Text = av21.ToString();

            av22 = Convert.ToInt32(label103.Text) - Convert.ToInt32(label104.Text);
            label178.Text = av22.ToString();

            label102.Text = rd.Next(0, 9).ToString();
            label76.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label102.Text) > Convert.ToInt32(label76.Text))
            {
                laziopuan += 3;
                label46.Text = laziopuan.ToString();
            }
            else if (Convert.ToInt32(label102.Text) == Convert.ToInt32(label76.Text))
            {
                laziopuan += 1;
                clubpuan += 1;
                label46.Text = laziopuan.ToString();
                label45.Text = clubpuan.ToString();
            }
            else
            {
                clubpuan += 3;
                label45.Text = clubpuan.ToString();
            }

            av23 = Convert.ToInt32(label102.Text) - Convert.ToInt32(label76.Text);
            label180.Text = av23.ToString();

            av24 = Convert.ToInt32(label76.Text) - Convert.ToInt32(label102.Text);
            label179.Text = av24.ToString();

            label144.Text = rd.Next(0, 9).ToString();
            label143.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label144.Text) > Convert.ToInt32(label143.Text))
            {
                zenitpuan += 3;
                label56.Text = zenitpuan.ToString();
            }
            else if (Convert.ToInt32(label144.Text) == Convert.ToInt32(label143.Text))
            {
                zenitpuan += 1;
                chelseapuan += 1;
                label56.Text = zenitpuan.ToString();
                label55.Text = chelseapuan.ToString();
            }
            else
            {
                chelseapuan += 3;
                label55.Text = chelseapuan.ToString();
            }

            av25 = Convert.ToInt32(label144.Text) - Convert.ToInt32(label143.Text);
            label197.Text = av25.ToString();

            av26 = Convert.ToInt32(label143.Text) - Convert.ToInt32(label144.Text);
            label198.Text = av26.ToString();

            label142.Text = rd.Next(0, 9).ToString();
            label141.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label142.Text) > Convert.ToInt32(label141.Text))
            {
                leipziguan += 3;
                label54.Text = leipziguan.ToString();
            }
            else if (Convert.ToInt32(label142.Text) == Convert.ToInt32(label141.Text))
            {
                leipziguan += 1;
                marseipuan += 1;
                label54.Text = leipziguan.ToString();
                label53.Text = marseipuan.ToString();
            }
            else
            {
                marseipuan += 3;
                label53.Text = marseipuan.ToString();
            }

            av27 = Convert.ToInt32(label142.Text) - Convert.ToInt32(label141.Text);
            label200.Text = av27.ToString();

            av28 = Convert.ToInt32(label141.Text) - Convert.ToInt32(label142.Text);
            label199.Text = av28.ToString();

            label152.Text = rd.Next(0, 9).ToString();
            label151.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label152.Text) > Convert.ToInt32(label151.Text))
            {
                portopuan += 3;
                label64.Text = portopuan.ToString();
            }
            else if (Convert.ToInt32(label152.Text) == Convert.ToInt32(label151.Text))
            {
                portopuan += 1;
                barcepuan += 1;
                label64.Text = portopuan.ToString();
                label63.Text = barcepuan.ToString();
            }
            else
            {
                barcepuan += 3;
                label63.Text = barcepuan.ToString();
            }

            av29 = Convert.ToInt32(label152.Text) - Convert.ToInt32(label151.Text);
            label193.Text = av29.ToString();

            av30 = Convert.ToInt32(label151.Text) - Convert.ToInt32(label152.Text);
            label194.Text = av30.ToString();

            label150.Text = rd.Next(0, 9).ToString();
            label149.Text = rd.Next(0, 9).ToString();

            if (Convert.ToInt32(label150.Text) > Convert.ToInt32(label149.Text))
            {
                atalantapuan += 3;
                label62.Text = atalantapuan.ToString();
            }
            else if (Convert.ToInt32(label150.Text) == Convert.ToInt32(label149.Text))
            {
                atalantapuan += 1;
                moskovapuan += 1;
                label62.Text = atalantapuan.ToString();
                label61.Text = moskovapuan.ToString();
            }
            else
            {
                moskovapuan += 3;
                label61.Text = moskovapuan.ToString();
            }

            av31 = Convert.ToInt32(label150.Text) - Convert.ToInt32(label149.Text);
            label195.Text = av31.ToString();

            av32 = Convert.ToInt32(label149.Text) - Convert.ToInt32(label150.Text);
            label196.Text = av32.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;

            takimlar = new List<Takim>();

            yenitakim = new Takim("Bayern Münih", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Sevilla", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Paris Saint-Germain", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Zenit", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Barcelona", "ispanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atlético Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Shakhtar Donetsk", "Ukranya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Chelsea", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Hollanda");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Dynamo Kiev", "Ukranya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Red Bull Salzburg", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("RB Leipzig", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Internazionale", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Olympiacos", "Yunanistan");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lazio", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Krasnodar", "Rusaya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atalanta", "İtalya");
            takimlar.Add(yenitakim);

            yenitakim = new Takim("Lokomotiv Moskova", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Marseille", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Club Brugge", "Belçika");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Sevilla", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Bor.Mönchengladbach", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Midtjylland", "Danimarka");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Rennes", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ferencvaros", "Macaristan");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilentakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgele.Next(0, takimlar.Count / 4);
                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool aynıulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    aynıulkedentakimvar = Aynıulkedentakimvarmi(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takim);
                    if (aynıulkedentakimvar)
                        break;
                }
                if (!aynıulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Takim);
                }
                else
                {
                    j--;
                }
            }
        }
        private bool Aynıulkedentakimvarmi(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if (gruptakim.TakimUlkesi == takim.TakimUlkesi)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            List<int> secilentakimlar = new List<int>();
            for (int i = 0; i < takimlar.Count; i++)
            {
                if (i < 8)
                {
                    LstTorba1.Items.Add(takimlar[i]);
                }
                else if (i < 16)
                {
                    LstTorba2.Items.Add(takimlar[i]);
                }
                else if (i < 24)
                {
                    LstTorba3.Items.Add(takimlar[i]);
                }
                else
                {
                    LstTorba4.Items.Add(takimlar[i]);
                }
                
            }
            for (int i = 0; i < secilentakimlar.Count; i++)
            {
                if (i < 8)
                {
                    LstTorba1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 16)
                {
                    LstTorba2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    LstTorba3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else
                {
                    LstTorba4.Items.Add(takimlar[secilentakimlar[i]]);
                }
            }
            torbalar.Add(LstTorba1);
            torbalar.Add(LstTorba2);
            torbalar.Add(LstTorba3);
            torbalar.Add(LstTorba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void porto_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox17_Enter(object sender, EventArgs e)
        {

        }
    }
}
