using IdentityModel.Client;
using ImageGallery.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;

namespace ImageGallery.Client.PostConfigurationOptions
{
    public class OpenIdConnectOptionsPostConfigurationOptions : IPostConfigureOptions<OpenIdConnectOptions>
    {
        private readonly IHttpClientFactory _clientFactory;

        public OpenIdConnectOptionsPostConfigurationOptions(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
        }

        public void PostConfigure(string name, OpenIdConnectOptions options)
        {
            options.Events = new OpenIdConnectEvents
            {
                OnTicketReceived = async context =>
                {
                    var subject = context.Principal.Claims.FirstOrDefault(c => c.Type == "sub").Value;

                    var apiClient = _clientFactory.CreateClient("BasicAPIClient");

                    var request = new HttpRequestMessage(
                        HttpMethod.Get,
                        $"/api/applicationuserprofiles/{subject}");
                    request.SetBearerToken(context.Properties.GetTokenValue("access_token"));

                    var response = await apiClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

                    response.EnsureSuccessStatusCode();

                    var userProfile = new ApplicationUserProfile();
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        userProfile = await JsonSerializer.DeserializeAsync<ApplicationUserProfile>(responseStream);
                    }

                    var newClaimsIdentity = new ClaimsIdentity();
                    newClaimsIdentity.AddClaim(new Claim("subscriptionlevel", userProfile.SubscriptionLevel));

                    context.Principal.AddIdentity(newClaimsIdentity);
                }
            };
        }
    }
}
