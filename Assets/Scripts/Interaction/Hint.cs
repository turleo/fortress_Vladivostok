using System;
using UnityEngine;
using UnityEngine.UI;

namespace Interaction
{
    public class Hint : MonoBehaviour
    {
        public Text hintText;
        public GameObject hint;
        private void FixedUpdate()
        {
            int layerMask = 1 << 8;
            layerMask = ~layerMask;
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 4, layerMask))
            {
                if (hit.collider.CompareTag("Interactable"))
                {
                    hint.SetActive(true);
                    hintText.text = "Нажмите, чтобы " + hit.collider.GetComponent<Interactable.Interactable>().Hint();
                    hint.GetComponent<Button>().onClick.RemoveAllListeners();
                    hint.GetComponent<Button>().onClick.AddListener(hit.collider.GetComponent<Interactable.Interactable>().Interact);
                }
                else
                {
                    hint.SetActive(false);
                }
            }
            else
            {
                hint.SetActive(false);
            }
        }
    }
}