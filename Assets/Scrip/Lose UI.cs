using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    [SerializeField] private GameObject loseUI; // 👈 ลาก UI มาใส่ตรงนี้
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        loseUI.SetActive(false); // เริ่มเกมยังไม่แพ้
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
        loseUI.SetActive(true); // แสดง UI

        Time.timeScale = 0f; // ❗ หยุดเกม
    }
}