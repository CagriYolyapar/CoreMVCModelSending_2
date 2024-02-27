using CoreMVCModelSending_2.Models.Tools;

namespace CoreMVCModelSending_2.Models.PageVM
{
    public class GetProductsPageVM
    {
        public List<Product> Products { get; set; }
        public Category Category { get; set; }
        public Employee Employee { get; set; }
        public List<Supplier> Suppliers { get; set; }


    }
}
