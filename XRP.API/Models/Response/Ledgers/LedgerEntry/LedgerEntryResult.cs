﻿namespace XRP.API.Models.Response.Ledgers.LedgerEntry;

public class LedgerEntryResult
{
    public string index { get; set; }
    public string ledger_hash { get; set; }
    public int ledger_index { get; set; }
    public LedgerEntryNode node { get; set; }
    public string status { get; set; }
    public bool validated { get; set; }
    public List<Warning> warnings { get; set; }
}