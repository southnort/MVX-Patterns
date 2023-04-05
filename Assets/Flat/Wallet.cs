using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
namespace Flat
{
    public class Wallet : MonoBehaviour
    {
        private const int MaxCoins = 100;

        [SerializeField] private Image _coinsIcon;
        [SerializeField] private TextMeshProUGUI _coinsText;
        [SerializeField] private Transform _coinsHeapParent;
        [SerializeField] private GameObject _coinInHeapTemplate;
        [SerializeField] private bool _presentInUi;
        [SerializeField] private bool _presentInHeap;

        private int _coins;

        private void OnEnable()
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
            if (_presentInUi)
            {
                if (_coinsIcon == null)
                    throw new InvalidOperationException();

                if( _coinsText == null)
                    throw new InvalidOperationException();
            }

            if (_presentInHeap)
            {
            if(_coinsHeapParent == null)
                    throw new InvalidOperationException();

            if(_coinInHeapTemplate== null)
                    throw new InvalidOperationException();            
            }
        }

        public void AddCoin()
        {
            if(_coins+1>MaxCoins) 
                throw new InvalidOperationException();

            _coins += 1;

            if (_presentInHeap)
            {
                _coinsText.text = $"{_coins}";
                _coinsIcon.color = Color.Lerp(Color.white, Color.red, _coins / MaxCoins);
            }

            if (_presentInHeap)
            {
                GameObject newCoin = Instantiate(_coinInHeapTemplate, _coinsHeapParent);
                newCoin.transform.Translate(Vector3.up * 10);
            }
        }
    }
}


