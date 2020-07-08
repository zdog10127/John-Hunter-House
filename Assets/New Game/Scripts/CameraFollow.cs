using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiderPosition = target.position + offset;
        Vector3 smootherdPosition = Vector3.Lerp(transform.position, desiderPosition, smoothSpeed);
        transform.position = smootherdPosition;

        transform.LookAt(target);
    }
}
