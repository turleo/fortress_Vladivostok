using DG.Tweening;
using UnityEngine;

namespace Data
{
    public class FloatingBall : MonoBehaviour
    {
        public Vector3 endValue;
        void Start()
        {
            transform.DOMove(endValue, 1).SetLoops(-1, LoopType.Yoyo);
        }
    }
}
