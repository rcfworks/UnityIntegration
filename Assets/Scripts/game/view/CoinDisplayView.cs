using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;
using game.model;

namespace game.view
{
    public class CoinDisplayView : GemDisplayView
    {
        [Inject]
        private IUserModel _userModel;

        // Start is called before the first frame update
        void Start()
        {
            valueText.text = _userModel.Coins.ToString();
        }

        // Update is called once per frame
        void Update() { }
    }
}
