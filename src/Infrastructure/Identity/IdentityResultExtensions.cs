using ca_sln_media_health.Application.Common.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace ca_sln_media_health.Infrastructure.Identity
{
    public static class IdentityResultExtensions
    {
        public static Result ToApplicationResult(this IdentityResult result)
        {
            return result.Succeeded
                ? Result.Success()
                : Result.Failure(result.Errors.Select(e => e.Description));
        }
    }
}