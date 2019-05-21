using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid_Calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        String eklenecek;
        int fareSayac=0;
        int peynirSayac = 0;
        int farex;
        int farey;
     
        private void btn_labirentOlustur_Click(object sender, EventArgs e)
        {

            

            int buyukluk;
            int.TryParse(txtBuyukluk.Text, out buyukluk);

            dgv_labirent.Columns.Clear();
            dgv_labirent.Rows.Clear();

            if (String.IsNullOrEmpty(txtBuyukluk.Text)) { 
                MessageBox.Show("Lutfen labirent boyutunu giriniz! ");
            }
            else if (buyukluk > 0)
            {
                for (int i = 0; i < buyukluk; i++)
                {
                    DataGridViewImageColumn resim = new DataGridViewImageColumn();
                    resim.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dgv_labirent.Columns.Add(resim);
                }
                dgv_labirent.Rows.Add(buyukluk);
            }


            dgv_labirent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewRow item in dgv_labirent.Rows)
            {
                item.Height = dgv_labirent.Columns[0].Width;
            }
            
            if (dgv_labirent.Rows.Count > 0)
            {
                foreach (DataGridViewImageCell item in dgv_labirent.Rows[0].Cells)
                {
                    item.Value = pB_duvar.Image;
                    item.Tag = 100;
                }

                foreach (DataGridViewImageCell item in dgv_labirent.Rows[dgv_labirent.Rows.Count - 1].Cells)
                {
                    item.Value = pB_duvar.Image;
                    item.Tag = 100;
                }
            }
            
            for (int i = 0; i < dgv_labirent.Rows.Count - 1; i++)
            {
                dgv_labirent[0, i].Value = pB_duvar.Image;
                dgv_labirent[0, i].Tag = 100;
                dgv_labirent[dgv_labirent.Columns.Count - 1, i].Value = pB_duvar.Image;
                dgv_labirent[dgv_labirent.Columns.Count - 1, i].Tag = 100;
            }
            
            for (int i = 1; i < dgv_labirent.Columns.Count - 1; i++)
            {
                for (int j = 1; j < dgv_labirent.Rows.Count - 1; j++)
                {
                    dgv_labirent[i, j].Value = pB_yol.Image;
                    dgv_labirent[i, j].Tag =1;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zamanlayici.Interval = 200;
        }

        private void dgv_labirent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgv_labirent.CurrentCellAddress.X;

            int y = dgv_labirent.CurrentCellAddress.Y;


            int tag= int.Parse((dgv_labirent.Rows[y].Cells[x]).Tag.ToString());

            if (tag ==100 ) 
                {
                    MessageBox.Show("Burası Doludur!");
                    return;
                }
            switch (eklenecek)
            {
                case "duvar":
                    {
                        DataGridViewImageCell duvar = new DataGridViewImageCell();
                        
                        duvar.Tag = "111";
                        dgv_labirent[x, y].Value = pB_duvar.Image;
                        dgv_labirent[x, y].Tag = duvar.Tag;
                        break;
                    }
                case "yol":
                    {
                        DataGridViewImageCell yol = new DataGridViewImageCell();
                        yol.Tag = "1";
                        dgv_labirent[x, y].Value = pB_yol.Image;
                        dgv_labirent[x, y].Tag = yol.Tag;
                        break;
                    }
                case "peynir":
                    {
                        if (peynirSayac == 0)
                        {
                            DataGridViewImageCell peynir = new DataGridViewImageCell();
                            peynir.Tag = "0";
                            dgv_labirent[x, y].Value = pB_peynir.Image;
                            dgv_labirent[x, y].Tag = peynir.Tag;
                            peynirSayac++;
                        }
                        else
                            MessageBox.Show("Sadece bir tane peynir eklenebilir!");
                        break;
                    }
                case "fare":
                    {
                        if (fareSayac == 0)
                        {
                            DataGridViewImageCell fare = new DataGridViewImageCell();
                            fare.Tag = "1";
                            dgv_labirent[x, y].Value = pB_fare.Image;
                            dgv_labirent[x, y].Tag = fare.Tag;
                            fareSayac++;
                            farex = e.ColumnIndex;
                            farey = e.RowIndex;
                        }
                        else
                            MessageBox.Show("Sadece bir tane fare eklenebilir!");
                            break;
                    }
                default:
                    {
                        MessageBox.Show("Lütfen önce eklemek istediğiniz fare/peynir/yol/duvar seçiniz!");
                        break;
                    }
            }
        }

        private void btnDuvarEkle_Click(object sender, EventArgs e)
        {
            eklenecek = "duvar";

        }

        private void btnYolEkle_Click(object sender, EventArgs e)
        {
            eklenecek = "yol";
        }

        private void btnFareEkle_Click(object sender, EventArgs e)
        {
            eklenecek = "fare";
        }

        private void btnPeynir_Click(object sender, EventArgs e)
        {
            eklenecek = "peynir";
        }

        private void btnArmayiBaslat_Click(object sender, EventArgs e)
        {
            zamanlayici.Enabled = true;
            zamanlayici.Start();

            if (peynirSayac == 0 && fareSayac == 1) {

                zamanlayici.Stop();
                MessageBox.Show("Peynir eklemeden başlatılamaz!");
            }
            else if (fareSayac == 0 && peynirSayac == 1)
            {
                zamanlayici.Stop();
                MessageBox.Show("Fare eklemeden başlatılamaz!");
            }
            else if (peynirSayac == 0 && fareSayac == 0) {

                zamanlayici.Stop();
                MessageBox.Show("Fare ve Peynir eklemeden başlatılamaz!");
            }
        }

        public int GidilecekYon()
        {
            int kuzey = 0;
            int guney = 0;
            int bati = 0;
            int dogu = 0;
            int hucredegeri=0;
            DataGridViewImageCell yeniFareKonum = new DataGridViewImageCell();
            yeniFareKonum.ImageLayout = DataGridViewImageCellLayout.Stretch;
            yeniFareKonum.Value = pB_fare.Image;
            kuzey = Convert.ToInt32(dgv_labirent.Rows[farey - 1].Cells[farex].Tag);
            guney = Convert.ToInt32(dgv_labirent.Rows[farey + 1].Cells[farex].Tag);
            bati = Convert.ToInt32(dgv_labirent.Rows[farey].Cells[farex - 1].Tag);
            dogu = Convert.ToInt32(dgv_labirent.Rows[farey].Cells[farex + 1].Tag);


            if (kuzey <= bati && kuzey<= dogu && kuzey<=guney)
            {
                if (kuzey !=100 || kuzey!=111)
                {
                    hucredegeri = kuzey;
                    if (kuzey==0)
                    {
                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[farey - 1].Cells[farex] = yeniFareKonum;
                    dgv_labirent.Rows[farey].Cells[farex].Value = pB_yol.Image;
                    farey--;
                  
                }
            }
            else if (bati<= kuzey && bati<=dogu & bati<=guney)
            {
                if (bati != 100 || bati!=111)
                {
                    hucredegeri = bati;
                    if (bati==0)
                    {

                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[farey].Cells[farex - 1] = yeniFareKonum;
                    dgv_labirent.Rows[farey].Cells[farex].Value = pB_yol.Image;
                    farex--;
                }
            }
            else if (guney <= kuzey && guney <= bati && guney <= dogu)
            {
                if (guney != 100 || guney !=111)
                {
                    hucredegeri = guney;
                    if (guney == 0)
                    {

                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[farey + 1].Cells[farex] = yeniFareKonum;
                    dgv_labirent.Rows[farey].Cells[farex].Value = pB_yol.Image;
                    farey++;
                }
            }
            else if (dogu<=kuzey && dogu<=bati && dogu<=guney)
            {
                if (dogu != 100 ||dogu!=111)
                {
                    hucredegeri = dogu;
                    if (dogu==0)
                    {

                        zamanlayici.Stop();
                        zamanlayici.Enabled = false;
                        return 1;
                    }
                    hucredegeri++;
                    yeniFareKonum.Tag = hucredegeri;
                    dgv_labirent.Rows[farey].Cells[farex + 1].Value = pB_fare.Image;
                    dgv_labirent.Rows[farey].Cells[farex].Value = pB_yol.Image;
                    farex++;
                }
            }

            return 0;
        }

        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            int donenDeger;
            donenDeger= GidilecekYon();
            if(donenDeger==1)
            {
                MessageBox.Show("Peynir Bulundu!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void txtBuyukluk_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        
        private void txtBuyukluk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
