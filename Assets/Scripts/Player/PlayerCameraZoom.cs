using UnityEngine;
using Cinemachine;

public class PlayerCameraZoom : MonoBehaviour
{
    [SerializeField]
    private float minZoom;
    [SerializeField]
    private float maxZoom;

    private CinemachineTransposer cinemachineTransposer;

    void Start()
    {
        cinemachineTransposer = gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTransposer>();
    }

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            cinemachineTransposer.m_FollowOffset.y += (Input.GetAxis("Mouse ScrollWheel") * -5);
            cinemachineTransposer.m_FollowOffset.y = Mathf.Clamp(cinemachineTransposer.m_FollowOffset.y, minZoom, maxZoom);
        }
    }
}
