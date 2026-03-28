using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnHit : MonoBehaviour
{
    [Header("Scene Settings")]
    [SerializeField] private string Credit;

    [Header("Trigger Settings")]
    [SerializeField] private string targetTag = "Player"; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        if (!string.IsNullOrEmpty(Credit))
        {
            SceneManager.LoadScene(Credit);
        }

    }
}