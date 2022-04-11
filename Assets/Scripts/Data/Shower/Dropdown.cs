using System;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Shower
{
    public class Dropdown : MonoBehaviour
    {
        private SavedController _controller;
        private UnityEngine.UI.Dropdown _dropdown;
        
            void OnEnable()
        {
            _controller = FindObjectOfType<SavedController>();
            _dropdown = GetComponent<UnityEngine.UI.Dropdown>();
            _dropdown.ClearOptions();
            var options = new List<string>();
            for (var i = 0; i < _controller.available.Length; i++)
            {
                if (_controller.available[i])
                {
                    options.Add(_controller.data[i].title);
                }
                else
                {
                    options.Add("[Locked] " + _controller.data[i].title);
                }
            }
            _dropdown.AddOptions(options);
        }
    }
}
