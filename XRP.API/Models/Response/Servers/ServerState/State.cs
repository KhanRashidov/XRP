namespace XRP.API.Models.Response.Servers.ServerState;

public class State
{
    public string build_version { get; set; }
    public string complete_ledgers { get; set; }
    public string initial_sync_duration_us { get; set; }
    public int io_latency_ms { get; set; }
    public LastClose last_close { get; set; }
    public string pubkey_node { get; set; }
    public string published_ledger { get; set; }
    public Reporting reporting { get; set; }
    public string server_state { get; set; }
    public string server_state_duration_us { get; set; }
    public StateAccounting state_accounting { get; set; }
    public string time { get; set; }
    public int uptime { get; set; }
    public ValidatedLedger validated_ledger { get; set; }
    public int validation_quorum { get; set; }
}