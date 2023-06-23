using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using game.model;
using game.voData;

namespace game.view.viewmodel
{
    public class GameManagerViewModel : MonoBehaviour
    {
        [Inject]
        private IUserModel _userModel;

        [Inject]
        public void Construct()
        {
            Debug.Log("I am in the construct of GameManagerViewModel!");

            _userModel.UserName = "Romeo";
            _userModel.Coins = 800;
            _userModel.Gems = 250;
            _userModel.Level = 8;

            vORendererData dataA = new vORendererData();
            dataA.Collected = 0;
            dataA.Title = "SMASH & GRAB";
            dataA.Description = "Temple Catacombs";
            dataA.Min = 0;
            dataA.Max = 20;
            dataA.HasTrophy = true;
            dataA.ElapsedTime = "1hr 20m";

            vORendererData dataB = new vORendererData();
            dataB.Collected = 1;
            dataB.Title = "BOUNTY";
            dataB.Description = "Star Gulch";
            dataB.Min = 30;
            dataB.Max = 30;
            dataB.HasTrophy = false;
            dataB.ElapsedTime = "3hr";

            vORendererData dataC = new vORendererData();
            dataC.Collected = 0;
            dataC.Title = "HEIST";
            dataC.Description = "Bandit Stash";
            dataC.Min = 0;
            dataC.Max = 40;
            dataC.HasTrophy = true;
            dataC.ElapsedTime = "1hr 20m";

            _userModel.DataRenderer.Add(dataA);
            _userModel.DataRenderer.Add(dataB);
            _userModel.DataRenderer.Add(dataC);
        }

        // Start is called before the first frame update
        void Start() { }

        // Update is called once per frame
        void Update() { }
    }
}
