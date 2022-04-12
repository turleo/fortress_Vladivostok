using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Data.Shower
{
    public class TextChanger : MonoBehaviour
    {
        public SavedController controller;
        public Text text;
        public UnityEngine.UI.Dropdown dropdown;

        private void OnEnable()
        {
            text = GetComponent<Text>();
            controller = FindObjectOfType<SavedController>();

            text.text = controller.GetDataText(0);
        }

        public void OnDataChanged()
        {
            text.text = controller.GetDataText(dropdown.value);
        }
    }
}
