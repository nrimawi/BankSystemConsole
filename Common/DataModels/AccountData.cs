﻿

namespace Common
{

    public class AccountData
    {
        #region fields
        public Guid accountIBAN { get; set; }
        public string accountType { get; set; }
        public double accountBalance { get; set; }
        public bool active { get; set; }

        #endregion

        #region constructor

        public AccountData(Guid accountIBAN, string accountType, double accountBalance)
        {
            this.active = active;
            this.accountIBAN = accountIBAN;
            this.accountType = accountType;
            this.accountBalance = accountBalance;

        }
        #endregion 
    }
}