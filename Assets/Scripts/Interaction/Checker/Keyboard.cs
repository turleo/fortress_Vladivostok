using System;
using UnityEngine;

namespace Interaction.Checker
{
    public class Keyboard : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                int layerMask = 1 << 8;
                layerMask = ~layerMask;
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10, layerMask))
                {
                    if (hit.collider.CompareTag("Interactable"))
                    {
                        hit.collider.GetComponent<Interactable.Interactable>().Interact();
                    }
                }
            }
        }
    }
}
