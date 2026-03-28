using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public void LoadScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }

}
