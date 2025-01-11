using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOyunOdevi
{
    public partial class Form1 : Form
    {
        private int yanlisHarfSayisi = 0; // Yanlış tahmin sayısı
        private int attemptCount = 1; // Kullanıcının girdiği harf sayısını takip etmek için (yani deneme sayisi)

        private bool drawCircle = false; // Daire çizim durumu
        private bool drawLine1 = false; // 1. Çizgi çizim durumu
        private bool drawLine2 = false; // 1. Çizgi çizim durumu
        private bool drawLine3 = false; // 1. Çizgi çizim durumu
        private bool drawLine4 = false; // 1. Çizgi çizim durumu
        private bool drawLine5 = false; // 1. Çizgi çizim durumu
        private bool drawLine6 = false; // 1. Çizgi çizim durumu
        private bool drawLine7 = false; // 1. Çizgi çizim durumu
        private bool drawLine8 = false; // 1. Çizgi çizim durumu
        private bool drawLine9 = false; // 1. Çizgi çizim durumu


        static Random rastgele = new Random();
        static private string sehirler = "Adana,Adıyaman,Afyon,Ağrı,Aksaray,Amasya,Ankara,Antalya,Ardahan,Artvin,Aydın," +
            "Balıkesir,Bartın,Batman,Bayburt,Bilecik,Bingöl,Bitlis,Bolu,Burdur,Bursa,Çanakkale,Çankırı,Çorum,Denizli,Diyarbakır," +
            "Düzce,Edirne,Elazığ,Erzincan,Erzurum,Eskişehir,Gaziantep,Giresun,Gümüşhane,Hakkari,Hatay,Iğdır,Isparta,İstanbul,İzmir," +
            "Kahramanmaraş,Karabük,Karaman,Kars,Kastamonu,Kayseri,Kırıkkale,Kırklareli,Kırşehir,Kilis,Kocaeli,Konya,Kütahya,Malatya," +
            "Manisa,Mardin,Mersin,Muğla,Muş,Nevşehir,Niğde,Ordu,Osmaniye,Rize,Sakarya,Samsun,Siirt,Sinop,Sivas,Şanlıurfa,Şırnak," +
            "Tekirdağ,Tokat,Trabzon,Tunceli,Uşak,Van,Yalova,Yozgat,Zonguldak";

        static String sehir = sehirler.Split(',')[rastgele.Next(0, 81)];
        int sehirLength = sehir.Length;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessage.Text = $"Şehir {sehirLength} harften oluşuyor. Lütfen 1. harfi girin:"; // Başlangıç mesajını ayarla
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Daire çizme durumu
            if (drawCircle)
            {
                g.DrawEllipse(Pens.Red, 430, 60, 100, 100); // Belirtilen konumda daire çizer
            }



            //259, 27
            // Çizgi çizme durumu
          
            if (drawLine1)
            {
                g.DrawLine(Pens.Red, 480, 160, 480, 250); // Belirtilen konumda çizgi çizer
            }
          
            
            
        
            if (drawLine2)
            {
                g.DrawLine(Pens.Red, 480, 160, 400, 250); // Belirtilen konumda çizgi çizer
            }
            if (drawLine3)
            {
                g.DrawLine(Pens.Red, 480, 160, 560, 250); // Belirtilen konumda çizgi çizer
            }
            if (drawLine4)
            {
                g.DrawLine(Pens.Red, 480, 250, 400, 340); // Belirtilen konumda çizgi çizer
            }
            if (drawLine5)
            {
                g.DrawLine(Pens.Red, 480, 250, 560, 340); // Belirtilen konumda çizgi çizer
            }
            if (drawLine6)
            {
                g.DrawLine(Pens.Red, 300, 30, 300, 400); // Belirtilen konumda çizgi çizer
            }
            if (drawLine7)
            {
                g.DrawLine(Pens.Red, 300, 30, 480, 30); // Belirtilen konumda çizgi çizer
            }
            if (drawLine8)
            {
                g.DrawLine(Pens.Red, 330, 30, 300, 60); // Belirtilen konumda çizgi çizer
            }
            if (drawLine9)
            {
                g.DrawLine(Pens.Red, 480, 160, 480, 30); // Belirtilen konumda çizgi çizer
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBoxInput.Text.ToUpper(); // Kullanıcı girdisini al ve büyük harfe çevir
            sehir = sehir.ToUpper(); // Şehri de büyük harfe çevir

            if ( yanlisHarfSayisi < 10 || attemptCount < sehir.Length) // Hala harf girmeye devam edebilir
            {

               
                if (userInput.Equals(sehir[attemptCount - 1].ToString()) && attemptCount < sehir.Length) // Eğer doğru harfse
                {
                   
                    MessageBox.Show("Doğru harf girdiniz!"); // Doğru harf girdisi için kullanıcıya mesaj göster
                    attemptCount++; // Bir sonraki harfe geç
                  
                }
                else // Eğer yanlış harfse
                {

                    yanlisHarfSayisi++;

                    switch (yanlisHarfSayisi)
                    {

                        case 1:
                            drawCircle = true; // Daire çizilecek
                            break;

                        case 2:
                            drawCircle = true; // Daire çizilecek                           
                            drawLine1 = true; // Çizgi çizilecek
                                break;

                            case 3:
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;
                        case 4:
                            drawLine3 = true; // Çizgi çizilecek
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;
                        case 5:
                            drawLine4 = true; // Çizgi çizilecek
                            drawLine3 = true; // Çizgi çizilecek
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;
                        case 6:
                            drawLine5 = true; // Çizgi çizilecek
                            drawLine4 = true; // Çizgi çizilecek
                            drawLine3 = true; // Çizgi çizilecek
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;
                        case 7:
                            drawLine6 = true; // Çizgi çizilecek
                            drawLine5 = true; // Çizgi çizilecek
                            drawLine4 = true; // Çizgi çizilecek
                            drawLine3 = true; // Çizgi çizilecek
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;
                        case 8:
                            drawLine7 = true; // Çizgi çizilecek
                            drawLine6 = true; // Çizgi çizilecek
                            drawLine5 = true; // Çizgi çizilecek
                            drawLine4 = true; // Çizgi çizilecek
                            drawLine3 = true; // Çizgi çizilecek
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;
                        case 9:
                            drawLine8 = true; // Çizgi çizilecek
                            drawLine7 = true; // Çizgi çizilecek
                            drawLine6 = true; // Çizgi çizilecek
                            drawLine5 = true; // Çizgi çizilecek
                            drawLine4 = true; // Çizgi çizilecek
                            drawLine3 = true; // Çizgi çizilecek
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;
                        case 10:
                            drawLine8 = true; // Çizgi çizilecek
                            drawLine7 = true; // Çizgi çizilecek
                            drawLine6 = true; // Çizgi çizilecek
                            drawLine9 = true; // Çizgi çizilecek
                            drawLine5 = true; // Çizgi çizilecek
                            drawLine4 = true; // Çizgi çizilecek
                            drawLine3 = true; // Çizgi çizilecek
                            drawLine2 = true; // Çizgi çizilecek
                            drawCircle = true; // Daire çizilecek
                            drawLine1 = true; // Çizgi çizilecek
                            break;

                    }

                    if (yanlisHarfSayisi >= 10) {
                        MessageBox.Show($"Oyun bitti!\nŞehir: {sehir}"); // Oyun bittiğinde mesaj göster
    // ?                    labelMessage.Text = ("****** OYUN BİTTİ ******"); //bunu neden uygulamıyor ??????
  //    ?                  labelMessage.Refresh(); // Bu satırın çalışmasına rağmen yenilenmezse:
    //   ?                 Application.DoEvents(); // UI thread'ini serbest bırakır ve ekranda anında gösterir
                        textBoxInput.Enabled = false; // Giriş alanını kapat
                        buttonSubmit.Enabled = false;      // Butonu devre dışı bırak
                    }

                    else
                    MessageBox.Show($"Yanlış harf! {10-yanlisHarfSayisi} deneme hakkınız kaldı."); // Yanlış harf girdisi için kullanıcıya mesaj göster
                }

               
                textBoxInput.Clear(); // Kullanıcının girdiği harfi temizle
                this.Invalidate(); // Ekranı yeniden çiz (Paint olayını tetikler)

                // Kullanıcıya yeni mesajı göster
                if (attemptCount <= sehir.Length || yanlisHarfSayisi<10)
                {
                    labelMessage.Text = $"şehir {sehir.Length} harften oluşuyor. Lütfen {attemptCount}. harfi girin:"; // Mesajı güncelle
                }
             
            }
          
               
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {
        }
    }
} 