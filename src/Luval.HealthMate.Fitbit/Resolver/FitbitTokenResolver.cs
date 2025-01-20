using Luval.AuthMate.Core.Interfaces;
using Luval.AuthMate.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luval.HealthMate.Fitbit.Resolver
{
    /// <summary>
    /// Resolves the Fitbit token for the authenticated user.
    /// </summary>
    public class FitbitTokenResolver
    {
        private readonly IUserResolver _userResolver;
        private readonly AppConnectionService _appConnectionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FitbitTokenResolver"/> class.
        /// </summary>
        /// <param name="userResolver">The user resolver to get the username.</param>
        /// <param name="appConnectionService">The app connection service to resolve the access token.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="userResolver"/> or <paramref name="appConnectionService"/> is null.</exception>
        public FitbitTokenResolver(IUserResolver userResolver, AppConnectionService appConnectionService)
        {
            _userResolver = userResolver ?? throw new ArgumentNullException(nameof(userResolver));
            _appConnectionService = appConnectionService ?? throw new ArgumentNullException(nameof(appConnectionService));
        }

        /// <summary>
        /// Asynchronously gets the Fitbit token for the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the Fitbit token.</returns>
        public async Task<string> GetTokenAsync(CancellationToken cancellationToken = default)
        {
            var userName = _userResolver.GetUserName();
            return await _appConnectionService.ResolveAccessTokenAsync("Fitibt", userName, cancellationToken);
        }
    }
}
