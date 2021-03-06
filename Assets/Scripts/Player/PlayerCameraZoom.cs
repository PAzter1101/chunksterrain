using UnityEngine;
using Cinemachine;

public class PlayerCameraZoom : MonoBehaviour
{
    private CinemachineTransposer CinemachineTransposer;

    void Start()
    {
        CinemachineTransposer = gameObject.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineTransposer>();
    }

    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            CinemachineTransposer.m_FollowOffset.y += (Input.GetAxis("Mouse ScrollWheel") * -5);
        }
    }
}
