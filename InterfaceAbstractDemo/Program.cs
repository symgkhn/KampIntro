using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

//Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
//Starbucks ve Nero Firması için çalışıyoruz.
//İki firma da müşterilerini veri tabanına kaydetmek istiyor.
//Starbucks müşterilerini kaydederken, mutlaka mernis doğrulaması istiyor.
//Nero müşterileri kaydederken böyle birşey istemiyor.
//Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new  MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });
            //Console.ReadLine();
        }
    }
}
//Adım 1 de, Customer class'ı oluşturuldu ardından Entities, Concrete ve Abstract
//klasörleri oluşturuldu.
//Ardından Customer class ını, Resharper(açılır liste) den move to Customer.cs'i
//seçtik ve ayrı sayfaya alıp Entities klasörüne attık.
//Customeri Entities klasörüne attığımız için namespace ismini de klasöre göre
//değiştirdik.

//2.Adımda ICustomerService interfacesi oluşturduk.
//Bir Customer nesnesi var ise
//interface'si(ICustomerService) de olmak zorundadır.

//Adım 3
//Önemli Not;Somut sınıflar eğer çıplak kalıyorsa, yani inheritance ya da 
//implementasyon almıyorsa ilerde nesnellik zafiyeti yaşarsın.
//Bu nedenle Customer class ına IEntity interfacesini implemente ettik
//ve oluştuduğumuz interfaceyi, ayrı sayfaya alıp, Abstract klasörüne taşıdık.
//Namespacesini de düzeltmeyi unutmadık.
//Adım 4 
//İki firma da müşterilerini veri tabanına kaydetmek istiyor.Bu nedenle
//ICustomerService'de bir metot yazılır.("void Save(Customer customer);")
//Katmanlı yapılarda accessibility(Erişilebilirlik)
//problemi yaşamamak için public ekledik.("public interface ICustomerService") gibi.
//void Save(Customer customer); metodunda "Customer'i", 
//using InterfaceAbstractDemo.Entities; ekleyince kabbul etti.
//İki firmada da bu metot kullanılıyor,
//Bu nedenle interface(ICustomerService) de kullanıp soyutlamış olduk.
//Over design zafiyetine dikkat!!
//ICustomerService interfacesinin implementasyonunu yapan herkes
//void Save(Customer customer); metodunu kullanmak zorundadır.

//Adım 5
//Concrete klasörü içinde, NeroCustomerManager ve StarbucksCustomerManager
//classları oluşturduk.(Publicleri unutmadık)
//Multi tenant:tek bir yazılım kopyası üzerinde birden çok firmaya (kiracı),
//hizmet verebilme amaçlı üretilmiş yazılım mimarisi.

//Adım 6
//NeroCustomerManager ve StarbucksCustomerManager bu iki classda da aynı kod
//interface nedeniyle implemente edileceği için abstract class oluşturduk.
//BaseCustomerManager adında class oluşturduk.Ardından BaseCustomerManagere
//ICustomerService interfacesini implemente edip metodu çağırdık.

//Adım 7
//StarbucksCustomerManager ve NeroCustomerManager classlarına,
//BaseCustomerManager abstract classını implemente ettik.
//BaseCustomerManager e abstract imzasını ekledik,
//aslında en başta yapmak gerekiyordu.
//Program.cs de, StarbucksCustomerManager ve NeroCustomerManager in müşteri,
//bilgilerini çağırmak için save metodunu çalıştırdık.

//Adım 8 
//Starbucks mernis doğrulaması istiyor!!İnterfaceleri ve abstract classları kullanamıyoruz
//çünkü ortak metotlar var.

//Adım 9
//BaseCustomManager de metoda virtual keyini ekledik.
////Virtual, metodlara uygulanan anahtar bir sözcüktür.
//Ve Virtual olarak tanımladığımız metodlarımızı,
//diğer class larda override edebiliriz.
//Yani, kalıtıldığı(miras alındığı) sınıfta metodun gövdesini
//( süslü parantezlerin içi) değiştirebileceğimiz anlamına gelir.
//StarbucksCustomerManagere gelip, override yazıp Save metodunu içeren
//başka bir metot implemente ediyoruz.
//Burada override yazınca seçenekler gelmedi, kodlarım kendim yazdım.!!!
//Yukarıda kşi bahsettiğim metodun üstüne CheckIfRealPerson(customer); yazdık.
//ve bunu bir başka metoda dönüştürdük.

//Adım 10
//ICustomerCheckService interface sini oluşturduk.İçine;
//"void CheckIfRealPerson(Customer customer);" yazdık.
//Ardından;StarbucksCustomerManager classında.
//ICustomerCheckService _customerCheckService;

//public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
//{
//_customerCheckService = customerCheckService;
//}
//Böyle bir işlem yaptık anlamadım!!

//Adım 11
//Concrete klasörü içinde CustomerCheckManager classı oluşturduk.42'burdan tekrar izle.
//https://www.youtube.com/watch?v=2EkMrrX9sYY&t=17333s

//Dependency Injection (Bağımlılık Enjeksiyonu)
//Dependency Injection, S.O.L.I.D prensiplerinin 5. ayağını oluşturan
//“Dependency Inversion” prensibinin uygulanmasını içeren bir patterndir.
//Dependency Injection temel olarak;
//bağımlılıkların kontrolü ve yönetimi için kullanılmaktadır.

//Adım 12
//CustomerCheckManager e ICustomerCheckService yi inherit ettik.İnterface olduğu
//için içindeki metodu implemente ettik.
//CustomerCheckManager e bu yapıya dönüştürdük.

//public bool CheckIfRealPerson(Customer customer)
//{
//return true;
//}

//Adım 13
//Starbucks ın mernis doğrulamasına ihtiyacı olduğu için;
//Save metodunun içine if - else komutu yazdık.

//Adım 14
//Browser'KPSPublic yazıp aratıyoruz.Çıkan sayfada
//https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx
//linkini asmx den itibaren kopyalıyoruz.
//InterfaceAbstractDemo da add i seçip, service referance ye geliyoruz.
//Gelen ekranda address bölümüne linkşi yapıştırıyoruz.Go diyip, yeni isim veriyoruz.
//MernisServiceReferance ismini verdik.

//Adım 15
//CustomerCheckManager içinde doğrudan aşağıda ki new lemeyi kullanmıyoruz.
//Çünkü bizi Mernis e bağımlı yapıyor.Bu yapı bu şekilde kullanılırsa;
//Örneğin; Mernis çalışmazsa sistem de çalışmaz.

//public class CustomerCheckManager : ICustomerCheckService
//{
//    public bool CheckIfRealPerson(Customer customer)
//    {
//        //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
//        
//    }
//}

//Adım 16
//Burada Adapter adlı yeni bir klasör oluşturduk.
//İçinde de MernisServiceAdapter classı oluşturduk.(Public'i unutma)
//MernisServiceAdapter e ICustomerCheckService yi implemente ettik.
//İçindeki metoda da Mernis bilgilerini gönderdik.

//Adım 17
//CustomerCheckManager "return true;" ekledik.
//Bu aşamadan sonra test yapılabilir.
