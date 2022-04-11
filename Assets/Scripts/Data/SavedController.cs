using Data.Shower;
using UnityEngine;

namespace Data
{
    public class SavedController : MonoBehaviour
    {
        public DataUnit[] data;
        public bool[] available;

        public NotificationShower notification;
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
            notification.gameObject.SetActive(true);
            notification.ShowData(id);
        }

        public string GetDataText(int i)
        {
            if (available[i])
                return data[i].text;
            return "Ещё не открыто";
        }
        
        public string GetDataTitle(int i)
        {
            return data[i].title;
        }

        public bool CheckDataUnlocked(int id)
        {
            if (PlayerPrefs.GetInt(id.ToString(), 0) == 0)
                return false;
            return true;
        }
    }
}
