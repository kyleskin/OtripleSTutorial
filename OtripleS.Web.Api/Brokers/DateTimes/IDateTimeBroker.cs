namespace OtripleS.Web.Api.Brokers.DateTimes;

public interface IDateTimeBroker
{
    DateTimeOffset GetCurrentDateTime();
}