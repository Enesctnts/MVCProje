Asp.Net(.Net Framework) C# olan app i seçelim.
MVC(Model-View-Controller)

Deneme Controller ına view eklemek için 
Deneme Metoduna sağ tık yapıp view i seçiyoruz.
View-Shared klasörü altında pencerede layout page i seçiyoruz 
	<li>@Html.ActionLink("İletişim", "Contact", "Home")</li>
	1.Tırnak-Butonun üzerine yazmak istediğim ad
	2.Tırnak-Controller içindeki methodumun içine
	3.Tırnak-View içindeki hangi klasörde belirtiyorum.

<li>@Html.ActionLink("Deneme", "Deneme", "Home")</li>
Deneme sayfasını  önce _layouta a yukarıdaki gibi ekledik.
Yeni bir layout page yaptık.
Layout Page içine diğer sayfaların hangi alanda görüntüleneceğini belirtmek için @RenderBod() kodunu kullandık.

Yeni bir layout nasıl oluşturduk ? 
Shared folder ina sağ tıklayıp view i seçtik.
ALtta seçenekler seçili değildi
Oluşan Layout Page a Body tagı içinde istediğimiz div içerisine  @renderBOdy() kodunu yazdık.

	OLuşturlulacak Tablolar
   1)Writer(Yazar)
   2)Category()
   3)Heading()
   4)Content
   5)About()
   6)Contaxt()

İlişki Oluşturma
-------------
Bire çok ilişkide bir olan tarafa Koleksion ekliyoruz.
        public ICollection<Heading> Headings { get; set; }
Çok tarafına bağlanılacak olan tablonun classı ve sutunu eklenir
		public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

EntityLayer ın içindeki referance a nuget packacge den entityframework u indirdik.(6.4.4)

DataLayer
Concrete klasörü ekledik
Context Classı ekledik
Nuget den Ef son sürümünü yüklüyoruz
Referanslardan EntityLayer katmanını ekledik
DbContext i katılım olara aldık


----UI----
Webconfig in içine connectionString ekledik
initial catalog içine veritabanını vermek istediğimiz name i verdik

Migrations Ekleme işlemi

View - other Windows Package Manager console a tıklıyoruz.

