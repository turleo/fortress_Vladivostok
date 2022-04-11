using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Data.Shower
{
    public class TextChanger : MonoBehaviour
    {
        private SavedController _controller;
        private Text _text;
        public UnityEngine.UI.Dropdown dropdown;

        private void OnEnable()
        {
            _text = GetComponent<Text>();
            _controller = FindObjectOfType<SavedController>();

            _text.text = _controller.GetDataText(0);
        }

        public void OnDataChanged()
        {
            _text.text = _controller.GetDataText(dropdown.value);
        }
    }
}
