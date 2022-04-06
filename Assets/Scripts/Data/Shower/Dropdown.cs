using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Data.Shower
{
    public class Dropdown : MonoBehaviour
    {
        private SavedController _controller;
        private TMP_Dropdown _dropdown;
        
        private void Start()
        {
            _controller = FindObjectOfType<SavedController>();
            _dropdown = GetComponent<TMP_Dropdown>();
            OnEnable();
        }

        void OnEnable()
        {
            _dropdown.options = new List<TMP_Dropdown.OptionData>();
            for (var i = 0; i < _controller.available.Length; i++)
            {
                if (_controller.available[i])
                {
                    _dropdown.options.Add(new TMP_Dropdown.OptionData(_controller.data[i].title));
                }
                else
                {
                    _dropdown.options.Add(new TMP_Dropdown.OptionData("[🔒] " + _controller.data[i].title));
                }
            }
        }
    }
}
