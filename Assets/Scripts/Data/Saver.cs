using System;
using UnityEngine;

namespace Data
{
    public class Saver : MonoBehaviour
    {
        private SavedController _savedController;

        private void Start()
        {
            _savedController = FindObjectOfType<SavedController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Data"))
            {
                var a = other.GetComponent<DataHolder>();
                _savedController.Save(a.dataID);
            }
        }
    }
}
