using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Data
{
    public class DataHolder : MonoBehaviour
    {
        public int dataID;
        private SavedController _savedController;

        private void Start()
        {
            _savedController = FindObjectOfType<SavedController>();
            if (_savedController.CheckDataUnlocked(dataID))
                Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _savedController.Save(dataID);
                Destroy(gameObject);
            }
        }
    }
}