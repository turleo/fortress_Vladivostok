using DG.Tweening;
using UnityEngine;

namespace Data
{
    public class FloatingBall : MonoBehaviour
    {
        public Vector3 endValue;
        void Start()
        {
            transform.DOMove(new Vector3(transform.position.x, endValue.y + 28, transform.position.z), 1).SetLoops(-1, LoopType.Yoyo);
        }
    }
}
