using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime self)
        {
            var today = DateTime.Today;
            var age = today.Year - self.Year;
            if (self.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}