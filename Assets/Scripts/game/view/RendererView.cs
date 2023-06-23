using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game.voData;
using game.model;
using Zenject;

namespace game.view
{
    public class RendererView : MonoBehaviour
    {
        [Inject]
        private IUserModel _userModel;

        [SerializeField]
        public List<ComponentRendererView> components = new List<ComponentRendererView>();

        void Start()
        {
            SetUpData();
        }

        private void SetUpData()
        {
            // List<string> titles = new List<string> { "SMASH & GRAB", "BOUNTY", "HEIST" };
            // List<string> descriptions = new List<string>
            // {
            //     "Temple Catacombs",
            //     "Star Gulch",
            //     "Bandits Stash"
            // };

            List<vORendererData> rendererData = _userModel.DataRenderer;

            for (int i = 0; i < components.Count; i++)
            {
                vORendererData data = rendererData[i];

                ComponentRendererView component = components[i] as ComponentRendererView;
                component.Title = data.Title;
                component.Description = data.Description;
                component.SetTrophy(data.HasTrophy);

                StatusBarView statusBar = component.GetStatusBar();
                statusBar.Min = data.Min;
                statusBar.Max = data.Max;
                statusBar.UpdateTextDisplay();
                statusBar.SetBarValue(data.Min);
            }
        }
    }
}
