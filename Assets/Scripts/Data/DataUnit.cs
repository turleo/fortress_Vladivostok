using UnityEngine;

namespace Data
{
    [CreateAssetMenu]
    public class DataUnit : ScriptableObject
    {
        public string title;
        [TextArea(3,10)] public string text;
    }
}
