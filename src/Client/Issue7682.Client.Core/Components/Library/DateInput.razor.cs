namespace Issue7682.Client.Core.Components.Library;

public partial class DateInput
{
    private int Year;
    private int Month;
    private int Day;

    [Parameter] public DateTimeOffset? Date { get; set; }
    [Parameter] public EventCallback<DateTimeOffset?> DateChanged { get; set; }
    [Parameter] public string Title { get; set; } = "";

    PersianCalendar persianCalendar = new PersianCalendar();

    private void UpdateDate()
    {
        if (int.TryParse(Year.ToString(), out int year) && year > 0 &&
            int.TryParse(Month.ToString(), out int month) && 0 < month && month < 13 &&
            int.TryParse(Day.ToString(), out int day) && 0 < day && day < 32)
        {
            try
            {
                var newDate = persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
                if (newDate != Date)
                {
                    Date = newDate;
                    DateChanged.InvokeAsync(Date);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                
            }
        }
    }
}
