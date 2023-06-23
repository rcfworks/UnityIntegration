using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;
using game.model;

namespace game.view
{
    public class LeaderboardView : MonoBehaviour
    {
        [Inject]
        private IUserModel _userModel;

        [SerializeField]
        private TMP_Text levelText;

        [SerializeField]
        private TMP_Text levelTextShadow;

        // Start is called before the first frame update
        void Start()
        {
            levelText.text = _userModel.Level.ToString();
            levelTextShadow.text = levelText.text;
        }

        // Update is called once per frame
        void Update() { }
    }
}
