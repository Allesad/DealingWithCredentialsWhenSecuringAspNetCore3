using Microsoft.AspNetCore.Authorization;
using System;

namespace ImageGallery.API.Authorization
{
    public class SubscriptionLevelRequirement : IAuthorizationRequirement
    {
        public string RequiredSubscriptionLevel { get; }

        public SubscriptionLevelRequirement(string requiredSubscriptionLevel)
        {
            RequiredSubscriptionLevel = requiredSubscriptionLevel ?? throw new ArgumentNullException(nameof(requiredSubscriptionLevel));
        }
    }
}
