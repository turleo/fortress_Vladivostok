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

        public Text text;

        private void OnEnable()
        {
            _controller = FindObjectOfType<SavedController>();
        }

        public void ShowData(int id)
        {
            text.text = _controller.GetDataTitle(id) + " - открыто";
            StartCoroutine(Hide());
        }

        IEnumerator Hide()
        {
            yield return new WaitForSeconds(5);
            gameObject.SetActive(false);
        }
    }
}
