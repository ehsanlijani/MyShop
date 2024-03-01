using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Domain.Entities.Common;

public class BaseEntity<T>
{
    #region Properties

    [Key]
    public T Id { get; set; }
    public bool IsDelete { get; set; }

    [DisplayName("تاریخ ایجاد")]
    [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
    public DateTime CreateDate { get; set; }

    #endregion
}

