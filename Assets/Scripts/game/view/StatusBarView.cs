using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace game.view
{
    public class StatusBarView : MonoBehaviour
    {
        [SerializeField]
        GameObject movableBar;

        [SerializeField]
        private TMP_Text titleText;

        public int Min { get; set; } = 0;

        public int Max { get; set; } = 0;

        private Vector3 _initialPosition;

        // Start is called before the first frame update
        void Start()
        {
            _initialPosition = movableBar.transform.localPosition;
        }

        // Update is called once per frame
        void Update() { }

        public void UpdateTextDisplay()
        {
            titleText.text = $"{Min}/{Max}";
        }

        public void SetBarValue(int value)
        {
            Min = value;

            if (Min == Max)
            {
                Vector3 _mPos = movableBar.transform.localPosition;
                _mPos.x = 0;
                movableBar.transform.localPosition = _mPos;
                return;
            }

            float minMax = Min / Max;
            float posResult = Mathf.Abs(_initialPosition.x) * minMax;

            Vector3 pos = movableBar.transform.localPosition;
            pos.x = posResult;
            movableBar.transform.localPosition = pos;
        }
    }
}
