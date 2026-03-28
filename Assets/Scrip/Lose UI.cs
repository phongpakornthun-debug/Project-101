using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerLose : MonoBehaviour
{
    [SerializeField] private GameObject loseUI;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private float timeLeft = 60f;

    private Rigidbody rb;
    private bool isGameOver = false;

    void Start()
    {
        Time.timeScale = 1f;

        rb = GetComponent<Rigidbody>();

        if (loseUI != null)
            loseUI.SetActive(false);
    }
    void Update()
    {
        if (isGameOver) return;

        
        timeLeft -= Time.deltaTime;

      
        timerText.text = "Time: " + Mathf.Ceil(timeLeft).ToString();

        
        if (timeLeft <= 0)
        {
            Lose();
        }
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            Lose();
        }
    }

    void Lose()
    {
        if (loseUI != null)
        {
            loseUI.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Lose UI ยังไม่ได้ใส่ใน Inspector");
        }

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}