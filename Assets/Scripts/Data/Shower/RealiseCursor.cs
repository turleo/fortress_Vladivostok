using System;
using UnityEngine;

namespace Data.Shower
{
    public class RealiseCursor : MonoBehaviour
    {
        private void OnEnable()
        {
            Cursor.lockState = CursorLockMode.None;
        }

        private void OnDisable()
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
