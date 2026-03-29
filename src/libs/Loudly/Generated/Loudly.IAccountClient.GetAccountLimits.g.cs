#nullable enable

namespace Loudly
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Check usage limits<br/>
        /// Retrieves the usage limits, how much has been used, and how much is left,<br/>
        /// optionally filtered by a date range.
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loudly.UsageLimit>> GetAccountLimitsAsync(
            global::System.DateTime? dateFrom = default,
            global::System.DateTime? dateTo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}