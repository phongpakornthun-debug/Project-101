using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    public void LoadScene(string Main_Menu)
    {
        SceneManager.LoadScene(Main_Menu);
    }

}
