using MyShop.Domain.Entities.Common;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Domain.Entities.Products;

public class ProductCategory : BaseEntity<long>
{
    #region Properties

    [DisplayName("دسته بندی محصول")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(255, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر داشته باشد")]
    public string Title { get; set; }

    [DisplayName("دسته بندی محصول به انگلیسی")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    [MaxLength(255, ErrorMessage = "{0} نمیتواند بیشتر از {1} کارکتر داشته باشد")]
    public string TitleInUrl { get; set; }

    #endregion

    #region Relations

    public ICollection<Product> products { get; set; }

    #endregion
}
