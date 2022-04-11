using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class ChangeScene : MonoBehaviour
    {
        public void NextLevel(string _scenename)
        {
            SceneManager.LoadScene(_scenename);
        }
    }
}