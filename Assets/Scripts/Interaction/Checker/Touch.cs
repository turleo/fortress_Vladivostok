using System;
using UnityEngine;

namespace Interaction.Checker
{
    public class Touch : MonoBehaviour
    {
        void Update()
        {
            RaycastHit2D hit;
            Vector2[] touches = new Vector2[5];
            if (Input.touchCount > 0)
            {
                if (Input.touchCount > 0)
                {
                    foreach (UnityEngine.Touch t in Input.touches)
                    {
                        if (Camera.main != null)
                            touches[t.fingerId] = Camera.main.ScreenToWorldPoint(Input.GetTouch(t.fingerId).position);
                        if (Input.GetTouch(t.fingerId).phase == TouchPhase.Began)
                        {
                            hit = Physics2D.Raycast(touches[t.fingerId], Vector2.zero);
                            if (hit.collider.CompareTag("Interactable"))
                            {
                                hit.collider.GetComponent<Interactable.Interactable>().Interact();
                            }
                        }
                    }
                }
            }
        }
    }
}