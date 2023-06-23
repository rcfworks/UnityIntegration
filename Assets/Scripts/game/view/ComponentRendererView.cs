using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using utils;
using TMPro;

namespace game.view
{
    public class ComponentRendererView : MonoBehaviour
    {
        [SerializeField]
        public Color colorA;

        [SerializeField]
        public Color colorB;

        [SerializeField]
        private string iconName;

        [SerializeField]
        private Image icon;

        [SerializeField]
        private Image cellA;

        [SerializeField]
        private Image cellB;

        [SerializeField]
        public string displayImageName;

        [SerializeField]
        public Image displayImage;

        [SerializeField]
        public bool hasTrophy;

        [SerializeField]
        public Image trophyImage;

        private bool _initialized = false;

        [SerializeField]
        private TMP_Text descriptionText;

        [SerializeField]
        private TMP_Text titleText;

        [SerializeField]
        private StatusBarView statusBar;

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                if (titleText != null)
                    titleText.text = _title;
            }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                if (descriptionText != null)
                    descriptionText.text = _description;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            if (!_initialized)
            {
                _initialized = true;
                Initialize();
            }
        }

        async void Initialize()
        {
            cellA.color = new Color(colorA.r, colorA.g, colorA.b, cellA.color.a);
            cellB.color = new Color(colorB.r, colorB.g, colorB.b, cellB.color.a);

            Sprite bgResult = await Utils.Instance.LoadSpriteFromFile(
                $"images/{this.displayImageName}"
            );
            displayImage.sprite = bgResult;

            Sprite iconResult = await Utils.Instance.LoadSpriteFromFile($"icons/{this.iconName}");
            Debug.Log("iconREsult: " + iconResult);
            icon.sprite = iconResult;
        }

        public void SetTrophy(bool value)
        {
            hasTrophy = value;
            trophyImage.gameObject.SetActive(hasTrophy);
        }

        public StatusBarView GetStatusBar()
        {
            return statusBar;
        }

        // Update is called once per frame
        void Update() { }
    }
}
