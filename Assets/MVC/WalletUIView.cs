using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    public class WalletUIView : WalletView
    {
        [SerializeField] private Image _coinsIcon;
        [SerializeField] private TextMeshProUGUI _coinsText;

        protected override void OnInitedEnable()
        {
            try
            {
                Validate();
            }
            catch (Exception ex)
            {
                enabled = false;
                throw ex;
            }
        }

        private void Validate()
        {
            if (_coinsIcon == null)
                throw new InvalidOperationException();

            if (_coinsText == null)
                throw new InvalidOperationException();
        }

        public void OnCoinsChanged()
        {
            _coinsText.text = $"{Model.Coins}";
            _coinsIcon.color = Color.Lerp(Color.white, Color.red, Model.Coins / Model.MaxCoins);
        }

    }
}
