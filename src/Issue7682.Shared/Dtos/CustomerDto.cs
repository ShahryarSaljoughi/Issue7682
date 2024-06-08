using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issue7682.Shared.Dtos;

public class CustomerDto
{
    /*اطلاعات پایه*/
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required(ErrorMessage = "وارد کردن نام الزامی است.")]
    public string? FirstName { get; set; }
    [Required(ErrorMessage = "وارد کردن نام خانوادگی الزامی است.")]
    public string? LastName { get; set; }
    public DateTimeOffset? BirthDateTime { get; set; }
    public Gender? Gender { get; set; }
    [Required(ErrorMessage = "وارد کردن شماره موبایل الزامی است")]
    public string? MobilePhone { get; set; }


    /*اطلاعات تکمیلی*/

    /// <summary>
    /// کد مشتری
    /// </summary>
    [MaxLength(50)]
    public string? CustomerCode { get; set; }
    /// <summary>
    /// کارت مشتری
    /// </summary>
    public string? CustomerCard { get; set; }
    /// <summary>
    /// کد ملی
    /// </summary>
    [Required(ErrorMessage = "وارد کردن کدملی الزامی است")]
    public string? NationalCode { get; set; }
    /// <summary>
    /// کد پرسنلی
    /// </summary>
    public string? PersonnelCode { get; set; }
    public EducationLevel EducationLevel { get; set; }
    [Required(ErrorMessage = "وارد کردن ایمیل الزامی است.")]
    [MaxLength(50, ErrorMessage = "طول ایمیل از حد مجاز تعریف شده بیش تر است.")]
    [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد.")]
    public string? Email { get; set; }
    [Url(ErrorMessage = "وب سایت وارد شده معتبر نمی باشد")]
    public string? WebSite { get; set; }


    /*وضعیت تاهل*/
    public MaritalStatus? MaritalStatus { get; set; }
    public DateTimeOffset? MarriageAnniversary { get; set; }
    public DateTimeOffset? SpouseBirthDateTime { get; set; }


    /*نحوه آشنایی*/

    public CustomerIntroductionMethod? IntroductionMethod { get; set; }
    /// <summary>
    /// تاریخ جذب
    /// </summary>
    public DateTimeOffset? AcquisitionDateTime { get; set; }


    /*اطلاعات تماس*/
    public List<ContactInfoDto> ContactInfos { get; set; } = new();

    /*آخرین ردیف فرم:*/
    public bool IsLoyaltyProgramSmsAllowed { get; set; } = false;
    public bool IsLoyaltyRewardAllowed { get; set; } = false;
    public string? Description { get; set; }

}

