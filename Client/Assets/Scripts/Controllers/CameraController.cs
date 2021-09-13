using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float movementSpeed;
    public float zoomSpeed;
    public float zoomAmount;

    Transform cameraTransform;
    Transform followTransform;

    Vector3 newPosition;
    Vector3 newZoom;
    int     screenWidth;
    int     screenHeight;

    Vector3 zoomVec;
    Vector3 minZoom = new Vector3(0, 10, -10);
    Vector3 maxZoom = new Vector3(0, 80, -80);

    void Start()
    {
        cameraTransform = FindObjectOfType<Camera>().transform;
        newPosition     = transform.position;
        newZoom         = cameraTransform.localPosition;
        screenWidth     = Screen.width;
        screenHeight    = Screen.height;

        zoomVec.Set(0, zoomAmount, -zoomAmount);
    }

    void Update()
    {
        if(followTransform != null)
        {
            transform.position = followTransform.position;
        }
        else
        {
            HandleMouseInput();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            followTransform = null;
        }
    }

    void HandleMouseInput()
    {
        if(Input.mousePosition.x < 1)
        {
            newPosition -= transform.right * movementSpeed * Time.deltaTime;
        }
        if(Input.mousePosition.x > screenWidth - 1)
        {
            newPosition += transform.right * movementSpeed * Time.deltaTime;
        }
        if(Input.mousePosition.y < 1)
        {
            newPosition -= transform.forward * movementSpeed * Time.deltaTime;
        }
        if(Input.mousePosition.y > screenHeight - 1)
        {
            newPosition += transform.forward * movementSpeed * Time.deltaTime;
        }
        if(Input.mouseScrollDelta.y > 0)
        {
            newZoom -= zoomVec * zoomSpeed * Time.deltaTime;
            if (newZoom.y < minZoom.y) newZoom = minZoom;
        }
        if(Input.mouseScrollDelta.y < 0)
        {
            newZoom += zoomVec * zoomSpeed * Time.deltaTime;
            if (newZoom.y > maxZoom.y) newZoom = maxZoom;
        }
        transform.position = newPosition;
        cameraTransform.localPosition = newZoom;
    }
}
