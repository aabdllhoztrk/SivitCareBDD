using OpenQA.Selenium;
using SivitCareBDD.Generators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SivitCareBDD.Pages
{
    public class HemsireIslemleriPage : BasePage
    {
        public HemsireIslemleriPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// Agri Takibi Elementleri
        /// </summary>
        private IWebElement btn_AgriTakibi => FindElementByXPath("//i[contains(@class,'agri')]");
        private IWebElement btn_AgriEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-agri-takip/div[1]/div/div/button[1]");
        private IWebElement btn_YuzSkalasi => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-agri-dialog/div[1]/mat-button-toggle-group/mat-button-toggle[3]/button");
        private IWebElement btn_AgriDurumu => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-agri-dialog/div[2]/mat-button-toggle-group/mat-button-toggle[3]/button");
        private IWebElement btn_PupilSkalasi => FindElementByXPath("//span[text()='6']");
        private IWebElement btn_AgriTakibiKaydet => FindElementByXPath("//span[text()=' Kaydet ']");
        private IWebElement validatePupilSkalasi => FindElementByXPath("//div[text()=' 6 ']");
        private IWebElement btn_AgriTakibiSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-agri-takip/div[2]/table/tbody/mat-row[2]/mat-cell[1]/div/button[2]");


        /// <summary>
        /// Basi Yarası Elementleri
        /// </summary>
        private IWebElement btn_BasiYarasi => FindElementByXPath("//i[contains(@class,'basi')]");
        private IWebElement btn_BasiYarasiEkle => FindElementByXPath("(//MAT-ICON[@role='img'][text()='add_circle_outline'])[1]");
        private IWebElement olusmaYeridropdown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-basi-yarasi-dialog/div[1]/mat-form-field[1]/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement txt_Evde => FindElementByXPath("//span[contains(text(),'Hastanede')]");
        private IWebElement bolgeDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-basi-yarasi-dialog/div[1]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement txt_Dirsekler => FindElementByXPath("//span[contains(text(),'Dirsekler')]");
        private IWebElement txt_Boyutu => FindElementByXPath("//input[@data-placeholder='Boyutu']");
        private IWebElement txt_Acıklama => FindElementByXPath("//input[@data-placeholder='Açıklama']");
        private IWebElement evreDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-basi-yarasi-dialog/div[1]/mat-form-field[3]/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement txt_DerinDoku => FindElementByXPath("//span[contains(text(),'Derin')]");
        private IWebElement btn_BasiYarasiKyadet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validateRandomBoyut => FindElementByXPath("//P[@class='p-over'][text()=' Boyut : " + randomBoyut + " ']");
        private IWebElement validateBolge => FindElementByXPath("//P[@class='p-over'][text()=' Bölge : Dirsekler ']");
        private IWebElement validateEvre => FindElementByXPath("(//P[@class='p-over'][text()=' Evre : Evre I '])[1]");
        private IWebElement fotoSec => FindElementByXPath("(//IMG[@class='inner-image'])[1]");
        private IWebElement btn_yaraBakimiEkle => FindElementByXPath("(//MAT-ICON[@role='img'][text()='add_circle_outline'])[2]");
        private IWebElement sonucDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-yarabakim-dialog/div[1]/mat-form-field[1]/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement txt_Kismen => FindElementByXPath("//span[contains(text(),'Kısmen İyileşti')]");
        private IWebElement degerlendirmeDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-yarabakim-dialog/div[1]/mat-form-field[2]/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement txt_hastaTekrar => FindElementByXPath("//span[contains(text(),'Tekrar Değerlendir')]");
        private IWebElement txt_Genislik => FindElementByXPath("//input[@data-placeholder='Genişlik']");
        private IWebElement txt_Uzunluk => FindElementByXPath("//input[@data-placeholder='Uzunluk']");
        private IWebElement btn_YaraTakibiKaydet => FindElementByXPath("//span[text()=' Kaydet ']");
        private IWebElement validateSonuc => FindElementByXPath("//TD[text()='Kısmen İyileşti']");
        private IWebElement validateDegerlerndirme => FindElementByXPath("//TD[text()='Tekrar Değerlendir']");
        private IWebElement validateYaraBakimiBoyut => FindElementByXPath("//TD[text()='2 X 3']");
        private IWebElement silBasiYarasi => FindElementByXPath("(//MAT-ICON[@role='img'][text()='delete'])[1]");

        /// <summary>
        /// Cilt Tanımlama Elements
        /// </summary>
        private IWebElement btn_CiltTanimlama => FindElementByXPath("//i[contains(@class,'cilt')]");
        private IWebElement btn_CiltTanimlamaEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-cilt-tanilama/div[1]/div/div/button[1]");
        private IWebElement txt_Diger => FindElementByXPath("(//SPAN[@class='mat-radio-label-content'])[1]/..//SPAN[@class='mat-radio-outer-circle']");
        private IWebElement txt_DeriAcilmis => FindElementByXPath("(//SPAN[@class='mat-radio-label-content'])[11]/..//SPAN[@class='mat-radio-outer-circle']");
        private IWebElement btn_CiltTanimlamaKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validateAgriSkalasi => FindElementByXPath("//div[contains(text(),' Deri Açılmış ')]");
        private IWebElement validateDeger=> FindElementByXPath("//div[contains(text(),' Solgun ')]");

        /// <summary>
        /// Hasta Kısıtlama
        /// </summary>       
        private IWebElement btn_HareketKisitlama => FindElementByXPath("//i[@class='kisitlama']");
        private IWebElement btn_HareketKisitlamaEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hasta-kisitlama/div[1]/div/div/button[1]");
        private IWebElement cb_SedatifIlacUygulama => FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[4]");
        private IWebElement cb_VentilatorAyrilma => FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[9]");
        private IWebElement cb_SolAltExtremite => FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[14]");
        private IWebElement btn_HareketKisitlamaKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validateAlinanOnlemler => FindElementByXPath("//div[text() =' Sedatif İlaç Uygulama ']");
        private IWebElement validateKisitlamaNedenleri => FindElementByXPath("//div[text() =' Ventilatörden Ayrılma ']");
        private IWebElement validateKisitlamaBolgesi => FindElementByXPath("//div[text() =' Sol Alt Extremite ']");
        private IWebElement btn_Kaldir => FindElementByXPath("(//MAT-ICON[@role='img'][text()='power_off'])[1]");
        private IWebElement cb_KisitlamadanDolayi => FindElementByXPath("(//SPAN[@class='mat-checkbox-inner-container'])[4]");
        private IWebElement btn_KisitlamaKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validateKisitlamaKaldirmaKriteri => FindElementByXPath("//div[text() =' Kısıtlamadan Dolayı Zarar Oluştu ']");

        /// <summary>
        /// Hasta Nifrisyonu
        /// </summary>
        private IWebElement btn_HastaNutrisyon => FindElementByXPath("//i[@class='hastabeslenme']");
        private IWebElement btn_HastaNutrisyonEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-nutrition/div[1]/div/div/button[1]/span[1]/mat-icon");
        private IWebElement dropdown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-nutrition-dialog/div[1]/mat-form-field/div/div[1]/div/mat-select/div/div[2]");
        private IWebElement btn_BeslenmeSekliKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement lblOral => FindElementByXPath("//SPAN[@class='mat-option-text'][text()='Oral']");
        private IWebElement validateBeslenmeKodu => FindElementByXPath("//DIV[@class='ng-star-inserted'][text()=' Oral '][1]");

        /// <summary>
        /// Hasta İzalasyonu Ekle/Düzenle/sil/dogrula
        /// </summary>
        private IWebElement btn_HastaIzolastonu => FindElementByXPath("//i[@class='hastaizolasyon']");
        private IWebElement btn_HastaIzolastonuEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-itaki/div[1]/div/div/button[1]");
        private IWebElement btn_Yok => FindElementByXPath("(//DIV[@class='col-sm-12'])[3]//SPAN[@class='mat-button-toggle-label-content'][text()=' Yok ']");
        private IWebElement btn_HastaIzolasyonKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement btn_HastaIzolasyonDuzenle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-itaki/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[1]");
        private IWebElement btn_HastaIzolasyonVar => FindElementByXPath("(//DIV[@class='col-sm-12'])[3]//SPAN[@class='mat-button-toggle-label-content'][text()=' Var ']");
        private IWebElement chkboxSolunum => FindElementByXPath("((//DIV[@class='col-sm-6'])[1]//SPAN[@class='mat-checkbox-inner-container'])[2]");
        private IWebElement chkboxDiger => FindElementByXPath("((//DIV[@class='col-sm-6'])[1]//SPAN[@class='mat-checkbox-inner-container'])[4]");
        private IWebElement txt_areaAciklama => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-izolasyon-dialog/div[2]/div[2]/mat-form-field/div/div[1]/div/textarea");
        private IWebElement btn_HastaIzolastonuSil => FindElementByXPath("(//MAT-CELL[@role='gridcell'])[1]//MAT-ICON[@role='img'][text()='delete']");
        private IWebElement validateIzalasyonIhtiyaciYok => FindElementByXPath("(//MAT-CELL[@role='gridcell'])[5]//DIV[@class='ng-star-inserted'][text()=' Yok ']");
        private IWebElement validateIzalasyonIhtiyaciVar => FindElementByXPath("(//MAT-CELL[@role='gridcell'])[5]//DIV[@class='ng-star-inserted'][text()=' Var ']");
        private IWebElement validateHastaIzolasyonSekliSolunum => FindElementByXPath("//DIV[@class='ng-star-inserted'][text()=' Solunum ']");

        /// <summary>
        /// Hemşire Değerlendirme elements
        /// </summary>
        private IWebElement btn_HemsireDegerlendirme => FindElementByXPath("//i[contains(@class,'degerlendirme')]");
        private IWebElement btn_HemsireDegerlendirmeEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hemsire-degerlendirme/div[1]/div/div/button[1]");
        private IWebElement txt_areaDegerlendirmeNotu => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-degerlendirme-dialog/div[2]/mat-form-field/div/div[1]/div/textarea");
        private IWebElement btn_HemsireDegerlendirmeKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validateHemsireDegerlendir => FindElementByXPath("//div[contains(text(),'Death')]");
        private IWebElement btn_HemsireDegerlendirmeDuzenle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hemsire-degerlendirme/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[1]");
        private IWebElement validateHemsireDegerlendirafterDuzenle => FindElementByXPath("//div[contains(text(),'Alive')]");
        private IWebElement btn_HemsireDegerlendirmeSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-hemsire-degerlendirme/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[2]");

        /// <summary>
        /// invaziv Girisimler Ekleme
        /// </summary>
        private IWebElement btn_InvazivGirisimler => FindElementByXPath("//i[contains(@class,'invaziv')]");
        private IWebElement btn_InvazivEkle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[1]/div/div/button[1]");
        private IWebElement txt_TupNo => FindElementByXPath("//input[@data-placeholder='Tüp No']");
        private IWebElement invaziGirisimDropDown => FindElementByXPath("/html/body/div[2]/div[2]/div/mat-dialog-container/app-invasiv-dialog/div[3]/mat-form-field/div/div[1]/div/mat-select");
        private IWebElement txt_Peg => FindElementByXPath("//span[contains(text(),'Peg')]");
        private IWebElement btn_InvaziKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement validateTarih => FindElementByXPath("//div[contains(text(),'Şu anda')]");
        private IWebElement validateTupNo => FindElementByXPath("//div[contains(text(),'1258')]");
        private IWebElement validateInvaziGiris => FindElementByXPath("//div[contains(text(),'Peg')]");

        /// <summary>
        /// Invaziv Düzenle/Sil/Cikar
        /// </summary>
        private IWebElement btn_InvazivDuzenle => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row[1]/mat-cell[1]/div/button[1]");
        private IWebElement txt_FoleySonda => FindElementByXPath("//span[contains(text(),'Foley Sonda')]");
        private IWebElement validateTupNoDuzenle => FindElementByXPath("//div[contains(text(),'1259')]");
        private IWebElement validateInvaziGirisimDuzenle => FindElementByXPath("//div[contains(text(),' Foley Sonda ')]");
        private IWebElement btn_InvazivSil => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row/mat-cell[1]/div/button[2]");
        private IWebElement btn_InvaziveCikar => FindElementByXPath("/html/body/app-root/app-details/mat-tab-group/div/mat-tab-body[5]/div/app-nurse-main/mat-drawer-container/mat-drawer-content/div/app-invaziv/div[2]/table/tbody/mat-row[1]/mat-cell[5]/div[1]/button");
        private IWebElement btn_InvaziveCikarKaydet => FindElementByXPath("//span[contains(text(),'Kaydet')]");
        private IWebElement btn_InvaziveCikarAciklama => FindElementByXPath("//textarea[@data-placeholder='Açıklama']");
        private IWebElement validate_AciklamaonTable => FindElementByXPath("//div[contains(text(),' DenemeTest ')]");
        private IWebElement validate_CikaranonTable => FindElementByXPath("//div[contains(text(),' abdullah öztürk ')]");


        /// <summary>
        /// Agri takibi methodları
        /// </summary>
        public void SetAgriTakibi()
        {
            Thread.Sleep(3000);
            btn_AgriTakibi.Click();
            btn_AgriEkle.Click();
            btn_YuzSkalasi.Click();
            btn_AgriDurumu.Click();
            btn_PupilSkalasi.Click();
            btn_AgriTakibiKaydet.Click();                        
        }
        public void ValidateAgriTakibi() 
        {
            ValidateElementExisting(validatePupilSkalasi);
        }
        public void AgriTakibiSil() 
        {
            Sil();
        }
        public void ValidateaAgriTakibinotExist() 
        {
            ValidateElementNotExist("Pupil Skalasi", "//div[text()=' 6 ']");
            Thread.Sleep(2000);
        }


        /// <summary>
        /// Bası yarası ve agrı takibi methodları
        /// </summary>        
        public void SetBasiYarasi()
        {
            Thread.Sleep(2000);
            btn_BasiYarasi.Click();
            btn_BasiYarasiEkle.Click();
            olusmaYeridropdown.Click();
            txt_Evde.Click();
            bolgeDropDown.Click();
            txt_Dirsekler.Click();
            sendKeys(txt_Boyutu, randomBoyut);
            evreDropDown.Click();
            txt_DerinDoku.Click();
            sendKeys(txt_Acıklama, "Büyük Bir Yara");
            btn_BasiYarasiKyadet.Click();                       
        }

        public static int randomnum1 = BasiYarasiGenerator.GetRandom();
        string randomBoyut = randomnum1.ToString();
        public void ValidateBasiYarasi() 
        {
            ValidateElementExist(validateRandomBoyut, "Boyut : " + randomBoyut + "");
            ValidateElementExisting(validateBolge);
            ValidateElementExisting(validateEvre);           
        }

        public void SetYaraBakimi() 
        {
            fotoSec.Click();
            btn_yaraBakimiEkle.Click();
            sonucDropDown.Click();
            txt_Kismen.Click();
            degerlendirmeDropDown.Click();
            txt_hastaTekrar.Click();
            sendKeys(txt_Genislik, "2");
            sendKeys(txt_Uzunluk, "3");
            sendKeys(txt_Acıklama, "Deneme");
            btn_YaraTakibiKaydet.Click();
        }
        public void ValidateYaraBakimi()
        {
            
            ValidateElementExisting(validateSonuc);
            ValidateElementExisting(validateDegerlerndirme);
            ValidateElementExisting(validateYaraBakimiBoyut);
        }
        public void BasiYarasiSil() 
        {
            Sil();
        }

        public void ValidateBasiYarasiandYaraBakiminotExist()
        {
            ValidateElementNotExist("Boyut from patient card", "//P[@class='p-over'][text()=' Boyut : " + randomBoyut + " ']");
            ValidateElementNotExist("Sonuc from right side", "//TD[text()='Kısmen İyileşti']");
        }

        /// <summary>
        /// Cilt Tanımlama Methodları
        /// </summary>
        public void SetCiltTanimlama() 
        {
            Thread.Sleep(1000);
            btn_CiltTanimlama.Click();
            btn_CiltTanimlamaEkle.Click();
            Thread.Sleep(500);
            txt_Diger.Click();
            txt_DeriAcilmis.Click();
            btn_CiltTanimlamaKaydet.Click();
        }
        public void ValidateCiltTanimlama() 
        {
            ValidateElementExisting(validateAgriSkalasi);
            ValidateElementExisting(validateDeger);
        }
        public void CiltTanimlamaSil()
        {
            Sil();
        }
        public void ValidateCiltTanimlamanotExist()
        {
            ValidateElementNotExist("Agri Skalasi", "//div[contains(text(),' Deri Açılmış ')]");
            ValidateElementNotExist("Değer", "//div[contains(text(),' Diğer ')]");
        }

        /// <summary>
        /// Hareket Kısıtlama Methodları
        /// </summary>
        public void SetHareketKisitlama() 
        {
            Thread.Sleep(1000);
            btn_HareketKisitlama.Click();
            btn_HareketKisitlamaEkle.Click();
            cb_SedatifIlacUygulama.Click();
            cb_VentilatorAyrilma.Click();
            cb_SolAltExtremite.Click();
            btn_HareketKisitlamaKaydet.Click();
        }
        public void ValidateHareketKisitlama()
        {
            ValidateElementExisting(validateAlinanOnlemler);
            ValidateElementExisting(validateKisitlamaNedenleri);
            //ValidateElementExisting(validateKisitlamaBolgesi);
        }
        public void RemoveHareketKisitlama()
        {
            btn_Kaldir.Click();
            cb_KisitlamadanDolayi.Click();
            btn_KisitlamaKaydet.Click(); ;
        }
        public void ValidateReasonofRemovedHareketKisitlama()
        {
            ValidateElementExist(validateKisitlamaKaldirmaKriteri, "Kısıtlamadan Dolayı Zarar Oluştu");
        }

        public void ValidateKisitlamaKaldirmaKriteri()
        {
            ValidateElementExist(validateKisitlamaKaldirmaKriteri, "Kısıtlamadan Dolayı Zarar Oluştu");
        }

        public void DeleteHareketKisitlama()
        {
            Sil();
        }

        public void ValidateHareketKisitlamanotExist()
        {
            ValidateElementNotExist("Ventilatörden Ayrılma", "//div[text() =' Ventilatörden Ayrılma ']");
            ValidateElementNotExist("Kısıtlamadan Dolayı Zarar Oluştu", "//div[text() =' Kısıtlamadan Dolayı Zarar Oluştu ']");
        }

        /// <summary>
        ///HastaNitrusyon METHODLARI 
        /// </summary>
        public void SetHastaNitrusyon() 
        {
            Thread.Sleep(1000);
            btn_HastaNutrisyon.Click();
            btn_HastaNutrisyonEkle.Click();
            dropdown.Click();
            lblOral.Click();
            btn_BeslenmeSekliKaydet.Click();
        }

        public void ValiadreHastaNitrusyonExist()
        {
            ValidateElementExist(validateBeslenmeKodu, "Oral");
        }

        public void RemoveHastaNitrusyon()
        {
            Sil();
        }
        public void ValidateHastaNitrusyonnotExist()
        {
            ValidateElementNotExist("Oral", "//DIV[@class='ng-star-inserted'][text()=' Oral ']");
            ValidateElementNotExist("Kullanıcı Adı", "//DIV[@class='ng-star-inserted'][text()=' abdullah öztürk ']");           
        }

        /// <summary>
        /// Hasta izolasyonu mehtodları
        /// </summary>
        public void SetHastaIzalasyonu()
        {
            Thread.Sleep(1000);
            btn_HastaIzolastonu.Click();
            btn_HastaIzolastonuEkle.Click();
            btn_Yok.Click();
            btn_HastaIzolasyonKaydet.Click();
            Thread.Sleep(1000);                                
        }

        public void ValidateIzolasyonIhtiyaciasYok() 
        {
            ValidateElementExisting(validateIzalasyonIhtiyaciYok);
        }
        public void EditHastaIzolasyonu()
        {
            btn_HastaIzolasyonDuzenle.Click();
            Thread.Sleep(1000);
            btn_HastaIzolasyonVar.Click();
            chkboxSolunum.Click();
            btn_HastaIzolasyonKaydet.Click();
        }
        public void ValidateHastaIzalasyonuasVar()
        {
            ValidateElementExisting(validateIzalasyonIhtiyaciVar);           
        }

        public void ValidateHastaIzalasyonSekli()
        {
            ValidateElementExisting(validateHastaIzolasyonSekliSolunum);

        }
        public void HastaIzalasyonuSil()
        {
            Sil();
        }
        public void ValidateHastaIzolasyonunotExist()
        {
            ValidateElementNotExist("İzolasyon İhtiyacı as Var", "(//MAT-CELL[@role='gridcell'])[5]//DIV[@class='ng-star-inserted'][text()=' Var ']");
            ValidateElementNotExist("İzolasyon Seklli as Temas", "//DIV[@class='ng-star-inserted'][text()=' Temas ']");
        }

        /// <summary>
        /// Hemsire Degerlendirme Methodlari
        /// </summary>
        public void SetHemsireDegerlendirme()
        {
            Thread.Sleep(2000);
            btn_HemsireDegerlendirme.Click();
            btn_HemsireDegerlendirmeEkle.Click();
            sendKeys(txt_areaDegerlendirmeNotu, "Death");
            btn_HemsireDegerlendirmeKaydet.Click();              
        }
        public void ValidateHemsireDegerlendirmeNotu() 
        {
            ValidateElementExisting(validateHemsireDegerlendir);
        }
        public void EditHemsireDegerlendirme()
        {
            btn_HemsireDegerlendirmeDuzenle.Click();
            sendKeys(txt_areaDegerlendirmeNotu, "Alive");
            btn_HemsireDegerlendirmeKaydet.Click();
        }
        public void ValidateHemsireDegerlendirmeNotuAfterEdit()
        {
            ValidateElementExisting(validateHemsireDegerlendirafterDuzenle);
            Thread.Sleep(1000);
        }
        public void RemoveHemsireDegerlendirme()
        {
            Sil();
        }
        public void ValidateHemsireDegerlendirmenotExist()
        {
            ValidateElementNotExist("Değerlendirme", "//div[contains(text(),'Alive')]");
        }

        /// <summary>
        /// Invaziv Girismler Methodlari
        /// </summary>
        public void SetInvazivGirisimler() 
        {
            Thread.Sleep(2000);
            btn_HemsireDegerlendirme.Click();
            btn_InvazivGirisimler.Click();
            btn_InvazivEkle.Click();
            sendKeys(txt_TupNo, "1258");
            Thread.Sleep(500);
            invaziGirisimDropDown.Click();
            txt_Peg.Click();
            btn_InvaziKaydet.Click();
        }

        public void ValidateTupNo()
        {
            ValidateElementExisting(validateTarih);
            ValidateElementExisting(validateTupNo);
        }
        public void ValiateInvazivGirisim()
        {
            ValidateElementExisting(validateInvaziGiris);
        }
        public void TakeoutInvazivGirisim()
        {
            Thread.Sleep(1000);
            btn_InvaziveCikar.Click();
            sendKeys(btn_InvaziveCikarAciklama, "DenemeTest");
            btn_InvaziveCikarKaydet.Click();
        }
        public void ValiateCikaran()
        {
            ValidateElementExisting(validate_CikaranonTable);
        }
        public void ValiateAciklama()
        {
            ValidateElementExisting(validate_AciklamaonTable);            
        }
        public void EditInvazivGirisimler()
        {
            btn_InvazivDuzenle.Click();
            sendKeys(txt_TupNo, "1259");
            invaziGirisimDropDown.Click();
            Thread.Sleep(500);
            txt_FoleySonda.Click();
            btn_InvaziKaydet.Click();
        }
        public void ValidateTupNoAfterEdit()
        {
            ValidateElementExisting(validateTupNoDuzenle);
        }
        public void ValiateInvazivGirisimAfterEdit()
        {
            ValidateElementExisting(validateInvaziGirisimDuzenle);
        }
        public void RemoveInvazivGirisimler()
        {
            Sil();
        }
        public void ValidateInvazivGirisimlernotExist()
        {
            ValidateElementNotExist("Tüp No", "//div[contains(text(),'1259')]");
            ValidateElementNotExist("Foley Sonda", "//div[contains(text(),' Foley Sonda ')]");
            ValidateElementNotExist("Aciklama", "//div[contains(text(),' DenemeTest ')]");
        }
    }
}
