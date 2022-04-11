using System.Collections;
using UnityEngine;

namespace Interaction.Interactable.Cannon
{
    public class BallDestroyer : MonoBehaviour
    {
        [Range(0, 5)] public float waitFor;
        void Start()
        {
            StartCoroutine(DestroyLater());
        }

        IEnumerator DestroyLater()
        {
            yield return new WaitForSeconds(waitFor);
            Destroy(gameObject);
        }

    }
}
