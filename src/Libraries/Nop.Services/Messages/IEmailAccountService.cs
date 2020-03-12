using System.Collections.Generic;
using Nop.Core.Domain.Messages;

namespace Nop.Services.Messages
{
    /// <summary>
    /// Email account service
    /// </summary>
    public partial interface IEmailAccountService
    {
        /// <summary>
        /// Inserts an email account
        /// </summary>
        /// <param name="emailAccount">Email account</param>
        void InsertEmailAccount(EmailAccount emailAccount);

        /// <summary>
        /// Updates an email account
        /// </summary>
        /// <param name="emailAccount">Email account</param>
        void UpdateEmailAccount(EmailAccount emailAccount);

        /// <summary>
        /// Deletes an email account
        /// </summary>
        /// <param name="emailAccount">Email account</param>
        void DeleteEmailAccount(EmailAccount emailAccount);

        /// <summary>
        /// Gets an email account by identifier
        /// </summary>
        /// <param name="emailAccountId">The email account identifier</param>
        /// <returns>Email account</returns>
        EmailAccount GetEmailAccountById(int emailAccountId);

        /// <summary>
        /// Gets all email accounts
        /// </summary>
        /// <returns>Email accounts list</returns>
        IList<EmailAccount> GetAllEmailAccounts();

        /// <summary>
        /// Delete email accounts
        /// </summary>
        /// <param name="emailAccounts">Email accounts</param>
        void DeleteEmailAccounts(IList<EmailAccount> emailAccounts);

        /// <summary>
        /// Get email accounts
        /// </summary>
        /// <param name="emailAccountIds">Email accounts identifiers</param>
        /// <returns>Email accounts</returns>
        IList<EmailAccount> GetEmailAccountsByIds(int[] emailAccountIds);
    }
}
