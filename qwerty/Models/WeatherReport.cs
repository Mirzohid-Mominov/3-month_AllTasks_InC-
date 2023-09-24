namespace qwerty.Models;

public record WeatherReport(Guid Id, string Weather, DateTimeOffset ReportTime);