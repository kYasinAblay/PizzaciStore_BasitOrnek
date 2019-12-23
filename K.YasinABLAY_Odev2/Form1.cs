using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K.YasinABLAY_Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal a = 0, genelToplam = 0, cesitFiyatToplami = 0, toplamTutar = 0, adetCarpimiyleTutar = 0, m = 0;



        int adet = 0, k = 0, secilenIndis = 0, n = 0, deger1 = 0;

        private void nmricAdet_ValueChanged(object sender, EventArgs e)
        {
            lblToplamTutar.Text = toplamTutar.ToString();
            if (int.TryParse(lblToplamTutar.Text, out n) == false)
            {
                return;
            }
            deger1 = Convert.ToInt32(nmricAdet.Value);


            adetCarpimiyleTutar = Convert.ToDecimal(lblToplamTutar.Text);


            m = (adetCarpimiyleTutar * deger1);


            lblToplamTutar.Text = m.ToString();


        }

        private void cmbEbat_SelectedIndexChanged(object sender, EventArgs e)
        {

            toplamTutar = 0;
            if (listCesitler.SelectedIndex == 0 || listCesitler.SelectedIndex == 1)
            {
                toplamTutar += 12;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 6;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 18;
                }

            }
            if (listCesitler.SelectedIndex == 2 || listCesitler.SelectedIndex == 3 || listCesitler.SelectedIndex == 4)
            {
                toplamTutar += 14;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 7;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 21;
                }
            }
            if (listCesitler.SelectedIndex == 5 || listCesitler.SelectedIndex == 6)
            {
                toplamTutar += 16;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 8;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 24;
                }
            }
            lblToplamTutar.Text = toplamTutar.ToString();
        }

        private void listCesitler_SelectedIndexChanged(object sender, EventArgs e)
        {
            toplamTutar = 0;
            if (listCesitler.SelectedIndex == 0 || listCesitler.SelectedIndex == 1)
            {
                toplamTutar += 12;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 6;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 18;
                }

            }
            if (listCesitler.SelectedIndex == 2 || listCesitler.SelectedIndex == 3 || listCesitler.SelectedIndex == 4)
            {
                toplamTutar += 14;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 7;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 21;
                }
            }
            if (listCesitler.SelectedIndex == 5 || listCesitler.SelectedIndex == 6)
            {
                toplamTutar += 16;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 8;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 24;
                }
            }
            lblToplamTutar.Text = toplamTutar.ToString();
        }

        private void btnSiparisToplaminiHesapla_Click(object sender, EventArgs e)
        {
            lblSiparisToplami.Text = "";
            genelToplam = 0;
            
            for (int i = 0; i < listSiparisDetayi.Items.Count; i++)
            {

                string siparisVerisi = listSiparisDetayi.Items[i].ToString();
                string[] siparisKalemi = siparisVerisi.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);


                for (int j = 0; j < 1; j++)
                {
                    string[] kalemDetay = siparisKalemi[2].Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);


                    string siparisAdedi = kalemDetay[0];
                    string[] Tutar = kalemDetay[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    a = Convert.ToDecimal(Tutar[0]);

                    genelToplam += a;


                }
            }
            lblSiparisToplami.Text = genelToplam.ToString() + " TL";
        }

        string cesit = "", ebat = "", detay = "";

       

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listSiparisDetayi.SelectedIndex == -1)
            {
                return;
            }
            else if (listSiparisDetayi.SelectedItems.Count==1)
            {
                listSiparisDetayi.Items.Remove(listSiparisDetayi.SelectedItem);
            }
            else
            {
                if (MessageBox.Show("Seçili siparişleri silmek mi istiyorsunuz?", "Silme İşlemi", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    while (listSiparisDetayi.SelectedItems.Count > 0)
                    {
                        listSiparisDetayi.Items.Remove(listSiparisDetayi.SelectedItems[0]);
                    }
                }
            }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (listSiparisDetayi.Items.Count > 0)
            {

                toplamTutar = 0;
                if (listCesitler.SelectedIndex > 0)
                {
                    cesit = listCesitler.SelectedItem.ToString();
                }
                else
                {
                    cesit = listCesitler.Items[0].ToString();
                    listCesitler.SelectedIndex++;
                }

                if (cmbEbat.SelectedIndex == -1)
                {
                    ebat = cmbEbat.Items[0].ToString();
                }
                else
                {
                    ebat = cmbEbat.SelectedItem.ToString();
                }
                adet = Convert.ToInt32(nmricAdet.Value);
                if (listCesitler.SelectedIndex == 0 || listCesitler.SelectedIndex == 1)
                {
                    toplamTutar += 12;
                    if (cmbEbat.SelectedIndex == 1)
                    {
                        toplamTutar += 6;
                    }

                    else if (cmbEbat.SelectedIndex == 0)
                    {
                        toplamTutar += 18;
                    }

                }
                if (listCesitler.SelectedIndex == 2 || listCesitler.SelectedIndex == 3 || listCesitler.SelectedIndex == 4)
                {
                    toplamTutar += 14;
                    if (cmbEbat.SelectedIndex == 1)
                    {
                        toplamTutar += 7;
                    }

                    else if (cmbEbat.SelectedIndex == 0)
                    {
                        toplamTutar += 21;
                    }
                }
                if (listCesitler.SelectedIndex == 5 || listCesitler.SelectedIndex == 6)
                {
                    toplamTutar += 16;
                    if (cmbEbat.SelectedIndex == 1)
                    {
                        toplamTutar += 8;
                    }

                    else if (cmbEbat.SelectedIndex == 0)
                    {
                        toplamTutar += 24;
                    }
                }

                if (rbtninceKenar.Checked)
                {
                    toplamTutar += 2;
                }
                if (cBSalam.Checked)
                {
                    toplamTutar += 0.5M;
                }
                if (cBSosis.Checked)
                {
                    toplamTutar += 0.5M;
                }
                if (cBSucuk.Checked)
                {
                    toplamTutar += 0.5M;
                }
                if (cBJalepeno.Checked)
                {
                    toplamTutar += 0.5M;
                }
                if (cBAncuez.Checked)
                {
                    toplamTutar += 0.5M;
                }
                if (cBZeytin.Checked)
                {
                    toplamTutar += 0.5M;
                }



                if (listSiparisDetayi.SelectedIndex > 0)
                {
                    secilenIndis = listSiparisDetayi.SelectedIndex;
                }
                else
                {
                    secilenIndis = 0;
                }
                lblToplamTutar.Text = toplamTutar.ToString();

                listSiparisDetayi.Items.RemoveAt(secilenIndis);
                detay = adet + " Adet/" + ebat + " Boy " + cesit + "/" + toplamTutar * adet + " TL;";
                listSiparisDetayi.Items.Insert(secilenIndis, detay);

                secilenIndis = 0;
            }
        }
        private void btnSecilenOzelliktekiPizzayiEkle_Click(object sender, EventArgs e)
        {

            toplamTutar = 0;
            if (listCesitler.SelectedIndex > 0)
            {
                cesit = listCesitler.SelectedItem.ToString();
            }


            if (cmbEbat.SelectedIndex == -1)
            {
                ebat = cmbEbat.Items[0].ToString();
            }
            else
            {
                ebat = cmbEbat.SelectedItem.ToString();
            }
            adet = Convert.ToInt32(nmricAdet.Value);
            if (listCesitler.SelectedIndex == 0 || listCesitler.SelectedIndex == 1)
            {
                toplamTutar += 12;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 6;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 18;
                }

            }
            if (listCesitler.SelectedIndex == 2 || listCesitler.SelectedIndex == 3 || listCesitler.SelectedIndex == 4)
            {
                toplamTutar += 14;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 7;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 21;
                }
            }
            if (listCesitler.SelectedIndex == 5 || listCesitler.SelectedIndex == 6)
            {
                toplamTutar += 16;
                if (cmbEbat.SelectedIndex == 1)
                {
                    toplamTutar += 8;
                }

                else if (cmbEbat.SelectedIndex == 0)
                {
                    toplamTutar += 24;
                }
            }

            if (rbtninceKenar.Checked)
            {
                toplamTutar += 2;
            }
            if (cBSalam.Checked)
            {
                toplamTutar += 0.5M;
            }
            if (cBSosis.Checked)
            {
                toplamTutar += 0.5M;
            }
            if (cBSucuk.Checked)
            {
                toplamTutar += 0.5M;
            }
            if (cBJalepeno.Checked)
            {
                toplamTutar += 0.5M;
            }
            if (cBAncuez.Checked)
            {
                toplamTutar += 0.5M;
            }
            if (cBZeytin.Checked)
            {
                toplamTutar += 0.5M;
            }

            detay = adet + " Adet/" + ebat + " Boy " + cesit + "/" + toplamTutar * adet + " TL;";
            lblToplamTutar.Text = (toplamTutar * adet).ToString();
            listSiparisDetayi.Items.Add(detay);
            cBAncuez.Checked = false;
            cBJalepeno.Checked = false;
            cBSalam.Checked = false;
            cBSosis.Checked = false;
            cBSucuk.Checked = false;
            cBZeytin.Checked = false;

        }

    }
}



