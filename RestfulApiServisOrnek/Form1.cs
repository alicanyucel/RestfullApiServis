using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestfulApiServisOrnek.Model.JsonModelleri;
using RestfulApiServisOrnek.Model.JsonModelleri.TekKisiModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Uygulamaya Nuget Galeriden Newtonsoft.Json paketi yüklenmiştir.....

namespace RestfulApiServisOrnek
{
    public partial class Form1 : Form
    {
        private readonly string baseURL = "https://reqres.in/api/";
        string gelenCevap = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTumKullaniciBilgileriniAl_Click(object sender, EventArgs e)
        {            
            txtBilgi.Clear();

            txtBilgi.Text = @"
https://reqres.in/api/ adresinde kullanıma sunulmuş olan ücretsiz api servisinde users isimli bir controller vardır.
Bu controller kullanıcı bilgilerini bir sayfada 6 kullanıcı olacak şekilde sayfalar halinde döndürmektedir.
GET LIST USERS için ana adrese eklenecek Request parametresi  users olacaktır gelen cevabın üst kısmında toplam sayfa sayısı bilgisi bulunmaktadır bu sayfalardan;
1. sayfadaki kullanıcıların gösterilmesini istiyorsak;
users?page=1 parametresini adrese eklememiz gerekecektir.
2. sayfadaki kullanıcıların gösterilmesini istiyorsak;
users?page=2 parametresini adrese eklememiz gerekecektir.
";
            txtCevap.Clear();
            txtCevap.Text = "Veriler alınıyor. Lütfen Bekleyiniz...";
            var cevap = await TumKullaniciBilgileriniAl(cmbSayfaNo.SelectedItem.ToString());
            txtCevap.Text = cevap.ToString();
        }
        private async void btnKullaniciBilgiAl_Click(object sender, EventArgs e)
        {
            if (txtKullaniciID.Text.Trim().Length > 0)
            {
                txtCevap.Clear();
                txtCevap.Text = "Veriler alınıyor. Lütfen Bekleyiniz...";
                var cevap = await KullaniciBilgisiAl(txtKullaniciID.Text.Trim());
                txtCevap.Text = cevap.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen bir kullanıcı id'si giriniz..!");
            }
            
        }

        private async void btnYeniKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text.Trim().Length > 0 && txtKullaniciMeslek.Text.Trim().Length > 0)
            {
                txtCevap.Clear();
                txtCevap.Text = "Veriler gönderiliyor. Lütfen Bekleyiniz...";
                var cevap = await YeniKullaniciEkle(txtKullaniciAd.Text.ToString().Trim(), txtKullaniciMeslek.Text.ToString().Trim());
                txtCevap.Text = cevap.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Ad ve/veya Meslek Bilgilerini Giriniz..!");
            }
        }

        private async void btnKullaniciDuzenle_Click(object sender, EventArgs e)
        {
            if (txtDuzenleKulaniciId.Text.Trim().Length > 0)
            {                
                txtCevap.Clear();
                txtCevap.Text = "Veriler gönderiliyor. Lütfen Bekleyiniz...";
                var cevap = await KullaniciBilgiGuncelle(txtDuzenleKulaniciId.Text.ToString().Trim(), txtYeniAd.Text.ToString().Trim(), txtYeniMeslek.Text.ToString().Trim());
                txtCevap.Text = cevap.ToString();
                txtDuzenleKulaniciId.Clear();
                txtYeniAd.Clear();
                txtYeniMeslek.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı ID giriniz..!");
            }
        }
        private async void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (txtSilKullaniciId.Text.ToString().Trim().Length > 0)
            {
                txtCevap.Clear();                
                var cevap = await KullaniciSil(txtSilKullaniciId.Text.ToString().Trim());
                txtCevap.Text = cevap.ToString();
                txtSilKullaniciId.Clear();                
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kullanıcı ID giriniz..!");
            }
        }

        private async Task<string> TumKullaniciBilgileriniAl(string sayfaNo)
        {
            gelenCevap = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await client.GetAsync(baseURL + "users?page="+sayfaNo))
                {
                    GelenCevapKodVeBaslikBilgileriAl(responseMessage);

                    using (HttpContent content = responseMessage.Content)
                    {
                        string veri = await content.ReadAsStringAsync();
                        if (veri != null)
                        {
                            gelenCevap += "\r\nGELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += veri + "\r\n\r\n";
                            gelenCevap += "\r\nJSON OLARAK BİÇİMLENDİRİLMİŞ VERİ\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += JsonOlarakBicimlendir(veri);                            
                        }
                        else
                        {
                            gelenCevap += "\r\nGELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += ".......NULL.....";
                        }
                    }
                }
            }
            return gelenCevap;
        }


        private async Task<string> KullaniciBilgisiAl(string id)
        {
            gelenCevap = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await client.GetAsync(baseURL + "users/" + id))
                {
                    GelenCevapKodVeBaslikBilgileriAl(responseMessage);

                    using (HttpContent content = responseMessage.Content)
                    {
                        string veri = await content.ReadAsStringAsync();
                        if (veri != null)
                        {
                            gelenCevap += "\r\nGELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += veri + "\r\n\r\n";
                            gelenCevap += "\r\nJSON OLARAK BİÇİMLENDİRİLMİŞ VERİ\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += JsonOlarakBicimlendir(veri);
                            TekKisiAnaKokDizin tekKisiAnaKokDizin = JsonConvert.DeserializeObject<TekKisiAnaKokDizin>(veri);
                            if (tekKisiAnaKokDizin.data != null)
                            {
                                kisiResim.ImageLocation = tekKisiAnaKokDizin.data.avatar;
                                lblID.Text = tekKisiAnaKokDizin.data.id.ToString();
                                lblAd.Text = tekKisiAnaKokDizin.data.first_name;
                                lblSoyad.Text = tekKisiAnaKokDizin.data.last_name;
                                lblMail.Text = tekKisiAnaKokDizin.data.email;
                            }
                            else
                            {                                
                                lblID.Text = "";
                                lblAd.Text = "";
                                lblSoyad.Text = "";
                                lblMail.Text = "";
                                kisiResim.ImageLocation = "";
                                MessageBox.Show("Bu ID Numarasına Ait Kişi Bilgisi Bulunmamaktadır.");
                            }
                        }
                        else
                        {
                            gelenCevap += "\r\nGELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += ".......NULL.....";
                        }
                    }
                }
            }
            return gelenCevap;
        }

        private async Task<string> YeniKullaniciEkle(string ad, string meslek)
        {
            gelenCevap = string.Empty;
            var gonderilecekVeri = new Dictionary<string, string>
            {
                { "name",ad },
                { "job", meslek}
            };

            var gonderi = new FormUrlEncodedContent(gonderilecekVeri);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await client.PostAsync(baseURL + "users", gonderi))
                {
                    GelenCevapKodVeBaslikBilgileriAl(responseMessage);

                    using (HttpContent content = responseMessage.Content)
                    {
                        string veri = await content.ReadAsStringAsync();
                        if (veri != null)
                        {
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRASI GELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += veri + "\r\n\r\n";
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRANSI JSON OLARAK BİÇİMLENDİRİLMİŞ GELEN VERİ\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += JsonOlarakBicimlendir(veri);
                        }
                        else
                        {
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRASI GELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += ".......NULL.....";
                        }
                    }
                }
            }
            return gelenCevap;
        }

        private async Task<string> KullaniciBilgiGuncelle(string id,string ad, string meslek)
        {
            gelenCevap = string.Empty;
            var gonderilecekVeri = new Dictionary<string, string>
            {
                { "name",ad },
                { "job", meslek}
            };

            var gonderi = new FormUrlEncodedContent(gonderilecekVeri);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await client.PutAsync(baseURL + "users/"+id, gonderi))
                {
                    GelenCevapKodVeBaslikBilgileriAl(responseMessage);

                    using (HttpContent content = responseMessage.Content)
                    {
                        string veri = await content.ReadAsStringAsync();
                        if (veri != null)
                        {
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRASI GELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += veri + "\r\n\r\n";
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRANSI JSON OLARAK BİÇİMLENDİRİLMİŞ GELEN VERİ\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += JsonOlarakBicimlendir(veri);
                        }
                        else
                        {
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRASI GELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += ".......NULL.....";
                        }
                    }
                }
            }
            return gelenCevap;
        }

        private async Task<string> KullaniciSil(string id)
        {
            gelenCevap = string.Empty;
            
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await client.DeleteAsync(baseURL + "users/" + id))
                {
                    GelenCevapKodVeBaslikBilgileriAl(responseMessage);

                    using (HttpContent content = responseMessage.Content)
                    {
                        string veri = await content.ReadAsStringAsync();
                        if (veri != null)
                        {
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRASI GELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += "KULLANICI SİLME İŞLEMİ BAŞARI İLE TAMAMLANDI";
                            gelenCevap += veri + "\r\n\r\n";                            
                        }
                        else
                        {
                            gelenCevap += "\r\nGÖNDERİLEN VERİ SONRASI GELEN DATA\r\n";
                            gelenCevap += "=================================================\r\n";
                            gelenCevap += ".......NULL.....";
                        }
                    }
                }
            }
            return gelenCevap;
        }

        private void TestMetodu()
        {
            using (HttpClient client=new HttpClient())
            {
                using (HttpRequestMessage requestMsg=new HttpRequestMessage())
                {
                    requestMsg.RequestUri = new Uri(baseURL+"users");
                    requestMsg.Method = HttpMethod.Get;
                    requestMsg.Headers.Add("Accept", "application/json");
                    Task<HttpResponseMessage> httpResponse = client.SendAsync(requestMsg);

                    using (HttpResponseMessage responseMsg=httpResponse.Result)
                    {
                        txtCevap.Text += responseMsg.ToString();

                        HttpStatusCode statusKod = responseMsg.StatusCode;
                        txtCevap.Text += "\r\n===============================================================\r\n";
                        txtCevap.Text += statusKod + "\r\n";
                        txtCevap.Text += (int)statusKod + "\r\n";
                        txtCevap.Text += "\r\n===============================================================\r\n";
                        
                        using (HttpContent responseContent = responseMsg.Content)
                        {
                            Task<string> responseData = responseContent.ReadAsStringAsync();
                            string data = responseData.Result;
                            txtCevap.Text += data+"\r\n";
                            AnaKokDizin anaKokDizin= JsonConvert.DeserializeObject<AnaKokDizin>(data);
                            txtCevap.Text += "\r\n===============================================================\r\n";
                            txtCevap.Text += "Toplam Sayfa Sayısı \t: " + anaKokDizin.total_pages.ToString() + Environment.NewLine;
                            txtCevap.Text += "Şu Anki Sayfa Numarası \t: "+ anaKokDizin.page.ToString()+Environment.NewLine;
                            txtCevap.Text += "Her Sayfadaki Kayıt Sayısı \t: " + anaKokDizin.per_page.ToString() + Environment.NewLine;
                            txtCevap.Text += "Toplam Kayıt Sayısı \t\t: " + anaKokDizin.total.ToString() + Environment.NewLine;
                            txtCevap.Text += "Support Url \t\t: " + anaKokDizin.support.url + Environment.NewLine;
                            txtCevap.Text += "Support Text \t\t: " + anaKokDizin.support.text + Environment.NewLine;
                            txtCevap.Text += "\r\n===============================================================\r\n";

                            for (int i = 0; i < anaKokDizin.data.Count; i++)
                            {
                                txtCevap.Text += "ID : "+"\t\t\t"+anaKokDizin.data[i].id.ToString()+"\r\n";
                                txtCevap.Text += "E-Mail : " + "\t\t\t" + anaKokDizin.data[i].email + "\r\n";
                                txtCevap.Text += "First Name : " + "\t\t" + anaKokDizin.data[i].first_name + "\r\n";
                                txtCevap.Text += "Last Name : " + "\t\t" + anaKokDizin.data[i].last_name + "\r\n";
                                txtCevap.Text += "Avatar : " + "\t\t\t" + anaKokDizin.data[i].avatar + "\r\n";
                                txtCevap.Text += "\r\n===============================================================\r\n";

                            }

                        }
                    }
                }
            }
        }
        private void GelenCevapKodVeBaslikBilgileriAl(HttpResponseMessage msg)
        {
            gelenCevap += "GELEN STATUS KODU : " + ((int)msg.StatusCode).ToString() + " => " + msg.StatusCode.ToString() + "\r\n";
            gelenCevap += "=================================================\r\n";
            gelenCevap += "\r\nGELEN CEVAP BAŞLIK VERİLERİ\r\n";
            gelenCevap += "=================================================\r\n";
            gelenCevap += msg.Headers.ToString() + "\r\n";
        }

        private string JsonOlarakBicimlendir(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Newtonsoft.Json.Formatting.Indented);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSayfaNo.SelectedIndex = 0;
            TestMetodu();
        }

        
    }
        
}
