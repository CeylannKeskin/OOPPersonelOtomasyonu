using PersonelOtomasyonu;
using System.ComponentModel.DataAnnotations;

namespace PersonelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
            cmbUnvan.DataSource = Enum.GetValues(typeof(Unvan)).Cast<Unvan>().Select(x => new { Value = x, DisplayName = GetEnumDisplayName(x) }).ToList();
            cmbUnvan.DisplayMember = "DisplayName";
            cmbUnvan.ValueMember = "Value";
            cmbUnvan.SelectedIndex = -1;
        }

        private string GetEnumDisplayName(Unvan value)//x
        {
            var fieldinfo = value.GetType().GetField(value.ToString());
            var attibute = fieldinfo.GetCustomAttributes(typeof(DisplayAttribute), false).Cast<DisplayAttribute>().FirstOrDefault();
            return attibute?.Name ?? value.ToString();
        }
        #region Resim Seçme


        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Personel Resmi(png,jpg,gif)|*.png;*.jpg;*.gif";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbResim.Image = Image.FromFile(ofd.FileName);
                pbResim.Tag = Path.GetExtension(ofd.FileName);
            }
        }
        #endregion
        #region Personel Ekleme

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p = PersonelDoldur(p);
            ListViewItem lvi = ListviewDoldur(p);  //bir listview satýrý olusturur.

            lstPersoneller.Items.Add(lvi);
            Metot.Temizle(this.Controls);
            //Metot.Temizle(groupBox1.Controls);

        }
        #endregion
        #region ListviewItem Doldurma Metodu

        private ListViewItem ListviewDoldur(Personel p)
        {
            ListViewItem lvi = new ListViewItem(p.TCKN);
            //lvi.Text=p.TCKN;
            lvi.SubItems.Add(p.Ad);
            lvi.SubItems.Add(p.Soyad);
            lvi.SubItems.Add(p.DogumTarihi.ToShortDateString());
            lvi.SubItems.Add(p.Email);
            lvi.SubItems.Add(p.IseGirisTarihi.ToShortDateString());
            lvi.SubItems.Add(GetEnumDisplayName(p.Unvan).ToString());
            lvi.Tag = p;
            return lvi;
        }
        #endregion
        #region Personel Ekleme Metodu

        private Personel PersonelDoldur(Personel p)
        {
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.TCKN = txtTCKimlikNumarasi.Text;
            p.DogumTarihi = dtDogumTarihi.Value;

            //p.Unvan = cmbUnvan.Text == "" ? Unvan.Belirtilmedi : (Unvan)Enum.Parse(typeof(Unvan), cmbUnvan.Text);

            p.Unvan = cmbUnvan.Text == "" ? Unvan.Belirtilmedi : (Unvan)cmbUnvan.SelectedValue;

            p.IseGirisTarihi = dtIseGirisTarihi.Value;
            p.Email = txtEmail.Text;
            p.Adres = txtAdres.Text;
            p.TelefonNumarasi = txtTelefonNo.Text;
            if (pbResim.Tag != null)
            {
                p.PersonelResmi = Guid.NewGuid() + pbResim.Tag.ToString();
                //Application.StartupPath veya Emvoirment.CurrentDirectory ile bin/debug a gidebiliriz
                pbResim.Image.Save(Application.StartupPath + "/Images/" + p.PersonelResmi);
            }
            return p;

        }
        #endregion
        #region Listviewde Seçilen Personeli Güncelleme

       
        Personel guncellenecekPersonel;
        int indexNo;
        private void lstPersoneller_DoubleClick(object sender, EventArgs e)
        {
            indexNo = lstPersoneller.SelectedItems[0].Index;
            guncellenecekPersonel = (Personel)lstPersoneller.SelectedItems[0].Tag;
            txtAd.Text = guncellenecekPersonel.Ad;
            txtSoyad.Text = guncellenecekPersonel.Soyad;
            txtEmail.Text = guncellenecekPersonel.Email;
            txtAdres.Text = guncellenecekPersonel.Adres;
            txtTCKimlikNumarasi.Text = guncellenecekPersonel.TCKN;
            txtTelefonNo.Text = guncellenecekPersonel.TelefonNumarasi;
            dtDogumTarihi.Value = guncellenecekPersonel.DogumTarihi;
            dtIseGirisTarihi.Value = guncellenecekPersonel.IseGirisTarihi;
            cmbUnvan.Text =GetEnumDisplayName( guncellenecekPersonel.Unvan).ToString();
            if (!string.IsNullOrEmpty(guncellenecekPersonel.PersonelResmi))
            {
                pbResim.Image = Image.FromFile("Images/" + guncellenecekPersonel.PersonelResmi);
                pbResim.Tag = Path.GetExtension(guncellenecekPersonel.PersonelResmi);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncellenecekPersonel = PersonelDoldur(guncellenecekPersonel);
            lstPersoneller.Items.RemoveAt(indexNo);//belirtilmiþ indeksteki degeri siler
            lstPersoneller.Items.Insert(indexNo, ListviewDoldur(guncellenecekPersonel));//belirtiðimiz indekse eleman ekler.Sonrakileri birsonraki indexe kaydýrýr.
            Metot.Temizle(this.Controls);
        }
        #endregion
        #region Listviewde Seçilen Personeli Silme

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItems.Count > 0)
            {
                lstPersoneller.Items.RemoveAt(indexNo);
                Metot.Temizle(this.Controls);
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(Path.Combine("Images/", guncellenecekPersonel.PersonelResmi));
            }
            else
                MessageBox.Show("Seçim yapmadýnýz");
        }
        #endregion
    }
}
