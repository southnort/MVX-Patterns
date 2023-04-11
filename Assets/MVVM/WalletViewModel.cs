using System;
using Unity.VisualScripting;
using UnityEngine;

namespace MVVM
{
    public class WalletViewModel:ViewModel
    {
        [Model] private Wallet _wallet = new Wallet();

        [Project] public int Coins => _wallet.Coins;

        [Command] public void AddCoin() => _wallet.AddCoin();

    }
}
