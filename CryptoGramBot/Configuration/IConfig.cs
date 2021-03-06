﻿namespace CryptoGramBot.Configuration
{
    public interface IConfig
    {
        bool BuyNotifications { get; set; }
        string DailyNotifications { get; set; }
        bool Enabled { get; set; }
        string Key { get; set; }
        bool OpenOrderNotification { get; set; }
        string Secret { get; set; }
        bool SellNotifications { get; set; }
        bool SendHourlyUpdates { get; set; }
    }
}