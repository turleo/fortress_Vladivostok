using UnityEngine;
using DG.Tweening;

namespace Interaction.Interactable
{
    public class Door : Interactable
    {

        private bool _rotated = false;

        public Vector3 startValue;
        public Vector3 endValue;
        public override void Interact()
        {
            print("Interact");
            if (_rotated)
                transform.DORotate(startValue, 1, 0);
            else
                transform.DORotate(endValue, 1, 0);
            _rotated = !_rotated;
        }
        public override string Hint()
        {
            return "открыть";
        }
    }
}
