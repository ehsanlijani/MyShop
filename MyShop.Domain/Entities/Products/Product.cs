using MyShop.Domain.Entities.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Domain.Entities.Products;
public class Product : BaseEntity<long>
{
    #region Properties
    public long ProductCategoryId { get; set; }

    [DisplayName("نام محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(255, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر داشته باشد")]
    public string Name { get; set; }

    [DisplayName("تصویر محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(255, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر داشته باشد")]
    public string ImageName { get; set; }


    [DisplayName("قیمت")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int Price { get; set; }


    [DisplayName("تعداد موجودی")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public int Quantity { get; set; }


    [DisplayName("توضیحات محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(5000, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر داشته باشد")]
    public string Description { get; set; }

    #endregion

    #region Relations

    public ProductCategory ProductCategory { get; set; }

    #endregion
}

