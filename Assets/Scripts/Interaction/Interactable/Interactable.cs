using UnityEngine;

namespace Interaction.Interactable
{
    public class Interactable : MonoBehaviour
    {
        public virtual string Hint()
        {
            return "взаимодействовать";
        }
        public virtual void Interact() {}
    }
}
