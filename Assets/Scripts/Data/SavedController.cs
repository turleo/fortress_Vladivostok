using UnityEngine;

namespace Data
{
    public class SavedController : MonoBehaviour
    {
        public DataUnit[] data;
        public bool[] available;
        void Start()
        {
            DontDestroyOnLoad(gameObject);

            for (int i = 0; i < data.Length; i++)
            {
                if (PlayerPrefs.GetInt(i.ToString(), 0) == 1)
                {
                    available[i] = true;
                }
            }
        }

        public void Save(int id)
        {
            PlayerPrefs.SetInt(id.ToString(), 1);
            PlayerPrefs.Save();
            available[id] = true;
        }
    }
}
