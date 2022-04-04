using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace Info
{
    public class GetFlyingData : MonoBehaviour
    {
        public GameObject infoData;
        public TextMeshProUGUI title;
        public TextMeshProUGUI text;
        public void OnTriggerEnter(Collider c)
        {
            var info = c.GetComponent<FlyingData>();
            if (info != null)
            {
                infoData.SetActive(true);
                title.text = info.title;
                text.text = info.info;
            }
        }
    }
}
