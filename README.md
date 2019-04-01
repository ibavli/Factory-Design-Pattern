## Factory Design Pattern

### Çalışma Mantığı
Factory design pattern, istemci tarafından verilen bilgilere göre nesne oluşumunu soyutlayarak merkezi bir yerden kontrol etmemizi sağlar. Amaç yazılımdaki değişimi kontrol altında tutmaktır. Class’lar interfaceler üzerinden türetilir. Böylece, istemci ile işi yapacak olan nesne birbirinden ayrılarak gevşek bağlılık sağlanmış olur. Oluşturulacak nesnelerden birbirine benzer olanlar aynı arayüzden türetilerek gruplandırılır. Factory deseni, aynı zamanda sistemimizde tanımladığımız soyut sınıflardan örnekler oluşturmamızı sağlar.

Kullanım şekli olarak, istemcinin verdiği bilgiye göre çalışma zamanında işi yapacak nesneyi oluşturur. Geri dönüş tipi tanımladığımız arayüzümüzdür. Geri döndürdüğü nesneler bu arayüzden türemiş olmalıdır.

### Ne zaman kullanılır?
Factory design pattern, sistemimizde belli özelliklere sahip soyut sınıfları oluşturmak istediğimizde kullanılır. Bir proje geliştiriyoruz ve istemciden gelen bilgiye göre bazı işlemler yapmamız gerekiyor. Yapacağımız işlemlerin temel seviyede aynı özelliğe sahip olduğunu ve bazı farklılaşmalar olduğunu varsayıyoruz. İşte bu gibi durumda bu tasarım desenine başvururuz.

Factory design pattern, istemcinin alt sınıf kullanımını ve bu alt sınıfı nasıl üreteceğini bilmediği durumlarda kullanılır. Bir e-ticaret platformu geliştirdiğimizi düşünelim. Bu platformun ödeme kısmının örneğini bu tasarım desenini kullanarak yapalım. Bu örneğe en başta basit bir ödeme işlemi ekleyeceğiz. Fakat zamanla gelen istekler olduğunu varsayıp onları ekleyeceğiz. Zamanla gelen isteklere nasıl hızlı ve kolay cevap verebileceğini sizde kodu inceleyip, kendiniz bir ekleme yapıp gözlemleyebilirsiniz.
