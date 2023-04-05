using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace MVC
{
    class WalletController
    {
        private readonly Wallet _wallet;

        public WalletController(Wallet wallet)
        {
            _wallet = wallet;
        }

        [MVCEvent]
        public void OnCoinsClick()
        {
            _wallet.AddCoin();
        }

        [MVCEvent]
        public void OnClickUpLevelButton()
        {
            _wallet.UpLevel();
        }
    }
}
