using CoreMVCModelSending_2.Models.PageVM;
using CoreMVCModelSending_2.Models.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCModelSending_2.Controllers
{
    public class ProductController : Controller
    {
        #region OnemliNotlar

        //Bir View metodunun farklı bir View döndürmesi ile Model göndermesi arasında fark vardır...Bu metodun overloadlarindan birinde acık bir şekilde bir string parametre tanımlaması yapıldıgından dolayı metodun object parametre alan bir overload'i olmasına ragmen ilgili metot bir string argümanla cagrılırsa string parametreli overload'i calısır...Onun object parametreli overload'ini calıstırmak icin string argümanı object'a acıkca cast etmeniz gerekir...Yani siz nasıl olsa her şey object'e gidiyor diye o ilgili overload'in calısacagını düsünmemelisiniz...Yani siz bu bilgiyi gözden kacırırsanız verdiginiz string argümanın veri göndermek oldugunu(model göndermek oldugunu) zannedersiniz ama aslında o isimde bir sayfa döndürme görevi yapılır...

        //Model Göndermek Front End'de göstermek veya kullanmak  istediginiz bilgileri  Back End'den Front End'e yollamak veya Front End'den almak istediginiz verileri Front End'den Back End'e göndermenin bir yoludur...Eger bu bilgi string bir tipte yollanacak ise o zaman string verisinin object'e cast edilerek argüman olarak verilmesi gerekir(Cünkü View metodunda acıkca string parametre alan bir overload vardır)


        //Bir Model gönderiliyirosa karsılanmak zorundadır...

        //Model'in karsılanması View sayfasında @model(buradaki kücük m harfine dikkat ediniz) diyerek gönderdiginiz verinin orijinal tipini yazmanız sayesinde olur...Model karsılandıktan sonra o ilgili verinin gösterilmesini istiyorsanız karsıladıgınız Model'i artık cagırmanız gerekir...Bu da @Model(büyük M harfine dikkat ediniz)



        #endregion
        public IActionResult Index()
        {
            return View("Merhaba ben veriyim" as object);
        }

        public IActionResult GetProducts()
        {
            List<Product> products = new()
            {
                new(){ID = 1, ProductName = "Tadelle",UnitPrice = 20},
                new(){ID = 2, ProductName = "Biskrem",UnitPrice = 30},
                new(){ID = 3, ProductName = "Cizi",UnitPrice = 10},
            };

            Category c = new Category();
            c.ID = 1;
            c.CategoryName = "Tatlılar";

            Employee e = new()
            {
                FirstName = "Cagri",
                LastName = "Yolyapar"
            };

            List<Supplier> suppliers = new()
            {
                new(){CompanyName="Asd"},
                new(){CompanyName="DDD"},
                new(){CompanyName="FFF"},
            };

            GetProductsPageVM gpVm = new GetProductsPageVM();
            gpVm.Products = products;
            gpVm.Category = c;
            gpVm.Employee = e;
            gpVm.Suppliers = suppliers;
            


            return View(gpVm);

          


        }



        public IActionResult CreateProduct()
        {
            //Biz eger BackEnd'den Front End'e bir model göndermiyorsak...Ama buna rağmen Front End sanki bir model karsılıyormus gibi bir ifade kullandıysa bu sefer bu demektir ki Front End Back End'e o tipte bir model gönderiyor...
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            return View();

        }

    }
}
