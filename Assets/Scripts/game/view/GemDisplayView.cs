using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;
using game.model;

namespace game.view
{
    public class GemDisplayView : MonoBehaviour
    {
        [Inject]
        private IUserModel _userModel;

        [SerializeField]
        public TMP_Text valueText;

        // Start is called before the first frame update
        void Start()
        {
            valueText.text = _userModel.Gems.ToString();
        }

        // Update is called once per frame
        void Update() { }
    }
}
