using Microsoft.EntityFrameworkCore;
using XRP.API.Models.Request.Admin.KeyGenerations;
using XRP.API.Models.Response.Accounts.AccountChannels;
using XRP.API.Models.Response.Accounts.AccountCurrencies;
using XRP.API.Models.Response.Accounts.AccountInfo;
using XRP.API.Models.Response.Accounts.AccountLine;
using XRP.API.Models.Response.Accounts.AccountObject;
using XRP.API.Models.Response.Accounts.AccountOffers;
using XRP.API.Models.Response.Accounts.AccountTx;
using XRP.API.Models.Response.Accounts.NorippleCheck;
using XRP.API.Models.Response.Admin.KeyGenerations.ValidationCreate;
using XRP.API.Models.Response.Admin.KeyGenerations.WalletPropose;
using XRP.API.Models.Response.Admin.Loggings.CrawlShards;
using XRP.API.Models.Response.Admin.Loggings.NodeShard;
using XRP.API.Models.Response.Admin.Peers.Connect;
using XRP.API.Models.Response.Admin.Signings.Sign;
using XRP.API.Models.Response.Admin.Signings.SignFor;
using XRP.API.Models.Response.Books.BookOffers;
using XRP.API.Models.Response.Books.DepositAuthorized;
using XRP.API.Models.Response.Books.RipplePathFind;
using XRP.API.Models.Response.ClioServers.ClioLedger;
using XRP.API.Models.Response.ClioServers.ClioServerInfo;
using XRP.API.Models.Response.Ledgers.Ledger;
using XRP.API.Models.Response.Ledgers.LedgerClosed;
using XRP.API.Models.Response.Ledgers.LedgerCurrent;
using XRP.API.Models.Response.Ledgers.LedgerData;
using XRP.API.Models.Response.Ledgers.LedgerEntry;
using XRP.API.Models.Response.PaymentChannel.ChannelAuthorize;
using XRP.API.Models.Response.PaymentChannel.ChannelVerify;
using XRP.API.Models.Response.Servers.Fee;
using XRP.API.Models.Response.Servers.Manifest;
using XRP.API.Models.Response.Servers.ServerInfo;
using XRP.API.Models.Response.Servers.ServerState;
using XRP.API.Models.Response.Transactions.Submit;
using XRP.API.Models.Response.Transactions.SubmitMultiSigned;
using XRP.API.Models.Response.Transactions.TransactionEntry;
using XRP.API.Models.Response.Transactions.Tx;
using XRP.API.Models.Response.Transactions.TxHistory;

namespace XRP.API.Context
{
    public class XRPContext:DbContext
    {
        public XRPContext(DbContextOptions<XRPContext> options):base(options)
        {
            
        }

        #region Accounts
        public DbSet<AccountInfoResponse> AccountInfos { get; set; }
        public DbSet<AccountChannelResponse> AccountChannels { get; set; }
        public DbSet<AccountCurrencyResponse> AccountCurrencies { get; set; }
        public DbSet<AccountLineResponse> AccountLines { get; set; }
        public DbSet<AccountObjectResponse> AccountObjects { get; set; }
        public DbSet<AccountOfferResponse> AccountOffers { get; set; }
        public DbSet<AccountTxResponse> AccountTxs { get; set; }
        public DbSet<NorippleCheckResponse> NorippleChecks { get; set; }
        #endregion

        #region Books
        public DbSet<BookOfferResponse> BookOffers { get; set; }
        public DbSet<DepositAuthorizedResponse> DepositAuthorizeds { get; set; }
        public DbSet<RipplePathFindResponse> RipplePathFinds { get; set; }
        #endregion

        #region Ledgers
        public DbSet<LedgerResponse> Ledgers { get; set; }
        public DbSet<LedgerClosedResponse> LedgerCloseds { get; set; }
        public DbSet<LedgerCurrentResponse> LedgerCurrents { get; set; }
        public DbSet<LedgerDataResponse> LedgerDatas { get; set; }
        public DbSet<LedgerEntryResponse> LedgerEntries { get; set; }
        #endregion

        #region Servers

        public DbSet<FeeResponse> Fees { get; set; }
        public DbSet<ManifestResponse> Manifests { get; set; }
        public DbSet<ServerInfoResponse> ServerInfos { get; set; }
        public DbSet<ServerStateResponse> ServerStates { get; set; }

        #endregion

        #region Transactions

        public DbSet<SubmitResponse> Submits { get; set; }
        public DbSet<SubmitMultiSignedResponse> SubmitMultiSigneds { get; set; }
        public DbSet<TxResponse> TxResponses { get; set; }
        public DbSet<TxHistoryResponse> TxHistories { get; set; }
        public DbSet<TransactionEntryResponse> TransactionEntries { get; set; }

        #endregion

        #region ClioServers

        public DbSet<ClioLedgerResponse> ClioLedgers { get; set; }
        public DbSet<ClioServerInfoResponse> ClioServerInfos { get; set; }

        #endregion

        #region PaymentChannel

       public DbSet<ChannelAuthorizeResponse> ChannelAuthorizes { get; set; }
       public DbSet<ChannelVerifyResponse> ChannelVerifys { get; set; }

        #endregion

        #region Admin

        #region KeyGenerations

        public DbSet<ValidationCreateResponse> ValidationCreates { get; set; }
        public DbSet<WalletProposeResponse> WalletProposes { get; set; }

        #endregion

        #region Loggings

        public DbSet<CrawlShardsResponse> CrawlShards { get; set; }
        public DbSet<NodeShardResponse> NodeShards { get; set; }

        #endregion

        #region Peers

        public DbSet<ConnectResponse> Connects { get; set; }

        #endregion

        #region Signings

        public DbSet<SignResponse> Signs { get; set; }
        public DbSet<SignForResponse> SignFors { get; set; }

        #endregion

        #endregion


    }
}
