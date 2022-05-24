using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float cameraSpeed = 3;
    public Vector3 cameraOffset;
    GameObject mainCamera;

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void LateUpdate()
    {
        CameraOffSet();
    }

    void CameraOffSet()
    {
        var pos = transform.position - mainCamera.transform.forward * cameraOffset.z
            + mainCamera.transform.up * cameraOffset.y
            + mainCamera.transform.right * cameraOffset.x;

        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, pos, cameraSpeed * Time.deltaTime);
    }
}
