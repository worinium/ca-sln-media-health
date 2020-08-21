using ca_sln_media_health.Application.Common.Interfaces;
using System;

namespace ca_sln_media_health.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
