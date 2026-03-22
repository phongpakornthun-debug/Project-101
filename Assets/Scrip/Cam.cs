using UnityEngine;

public class SideCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(10, 2, 0);

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}