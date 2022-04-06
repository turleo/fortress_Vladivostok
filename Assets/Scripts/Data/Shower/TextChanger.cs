using System;
using TMPro;
using UnityEngine;

namespace Data.Shower
{
    public class TextChanger : MonoBehaviour
    {
        private SavedController _controller;
        private TextMeshProUGUI _text;
        public TMP_Dropdown dropdown;

        private void Start()
        {
            _text = GetComponent<TextMeshProUGUI>();
            _controller = FindObjectOfType<SavedController>();

            _text.text = _controller.GetDataText(0);
        }

        public void OnDataChanged()
        {
            _text.text = _controller.GetDataText(dropdown.value);
        }
    }
}
