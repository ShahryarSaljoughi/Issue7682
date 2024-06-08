namespace Issue7682.Shared.Extensions;

public static class EnumPresentationExtensions
{
    public static string ToFarsi(this EducationLevel educationLevel)
    {
        return educationLevel switch
        {
            EducationLevel.HighSchool => "دیپلم",
            EducationLevel.Bachelor => "لیسانس",
            EducationLevel.Master => "فوق لیسانس",
            EducationLevel.Doctorate => "دکتری",
            _ => throw new NotSupportedException()
        };
    }
    public static string ToFarsi(this CustomerPhoneType type)
    {
        return type switch
        {
            CustomerPhoneType.Landline => "تلفن",
            CustomerPhoneType.Mobile => "موبایل",
            CustomerPhoneType.Fax => "فکس",
            CustomerPhoneType.Telefax => "تلفکس",
            _ => throw new NotSupportedException()
        };
    }
    public static string ToFarsi(this CustomerIntroductionMethod method)
    {
        return method switch
        {
            CustomerIntroductionMethod.Ads => "تبلیغات محیطی",
            CustomerIntroductionMethod.Coworkers => "همکاران",
            CustomerIntroductionMethod.Directly => "مستقیما",
            CustomerIntroductionMethod.Email => "ایمیل",
            CustomerIntroductionMethod.Fax => "فکس",
            CustomerIntroductionMethod.Friends => "معرفی دوستان",
            CustomerIntroductionMethod.Personnel => "پرسنل",
            CustomerIntroductionMethod.Phone => "تلفن",
            CustomerIntroductionMethod.Sms => "پیام کوتاه",
            CustomerIntroductionMethod.SocialMedia => "شبکه های اجتماعی",
            CustomerIntroductionMethod.Website => "وبسایت",
            _ => throw new NotSupportedException()
        };
    }

    public static string ToFarsi(this MaritalStatus status)
    {
        return status switch
        {
            MaritalStatus.Married => "متاهل",
            MaritalStatus.Single => "مجرد",
            _ => throw new NotSupportedException()
        };
    }

    public static string ToFarsi(this ApprovalState status)
    {
        return status switch
        {
            ApprovalState.Pending=> "در انتظار تایید",
            ApprovalState.Approved => "تایید شده",
            ApprovalState.Rejected => "تایید نشده",
            _ => throw new NotSupportedException()
        };
    }
}
