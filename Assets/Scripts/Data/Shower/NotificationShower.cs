using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Data.Shower
{
    public class NotificationShower : MonoBehaviour
    {
        private SavedController _controller;
        public UnityEngine.UI.Dropdown dropdown;
        [Range(0, 10)] public int seconds = 5;
        private int lastId;

        public Text text;

        private void OnEnable ()
        {
            _controller = FindObjectOfType<SavedController>();
        }

        public void ShowData(int id)
        {
            text.text = _controller.GetDataTitle(id) + " - открыто";
            StartCoroutine(Hide());
            lastId = id;
        }

        public void ShowBigData()
        {
            dropdown.value = lastId;
        }

        IEnumerator Hide()
        {
            yield return new WaitForSeconds(seconds);
            gameObject.SetActive(false);
        }
    }
}
