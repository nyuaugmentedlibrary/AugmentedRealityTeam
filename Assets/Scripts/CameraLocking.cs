using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLocking : MonoBehaviour
{
    private Camera mainCamera;
    private bool isZoomed = false;
    private GameObject selectedRoom;

    void Start()
    {
        mainCamera = Camera.main;
        ResetCamera();
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Indeed clicked");
            // Raycast to detect the object clicked
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the clicked object is a room (you can replace this condition with your own logic)
                if (hit.collider.CompareTag("Room"))
                {
                    // Toggle between zoomed-in and default view
                    if (isZoomed && selectedRoom != null)
                    {
                        // Reset the camera to default view
                        ResetCamera();
                    }
                    else
                    {
                        // Select the room and move the camera to lock on it
                        SelectRoom(hit.collider.gameObject);
                    }
                }
            }
        }
    }

    void SelectRoom(GameObject room)
    {
        // Store the selected room
        selectedRoom = room;

        // Move the camera to lock on the selected room
        LockCameraOnRoom(room);

        // Toggle the zoomed-in state
        isZoomed = true;
    }

    void ResetCamera()
    {
        // Reset the camera to its default view
        // You can adjust the default camera position and rotation as needed
        mainCamera.transform.position = new Vector3(0, 30, -10);
        mainCamera.transform.rotation = Quaternion.Euler(70, 0, 0);

        // Reset any other camera-related settings
        isZoomed = false;
    }

    void LockCameraOnRoom(GameObject room)
    {
        // Adjust the camera's position or target to focus on the selected room
        // For example, you can set the camera's position to the center of the selected room
        mainCamera.transform.position = room.transform.position + new Vector3(0, 5, 0); // Adjust the values as needed
        mainCamera.transform.LookAt(room.transform.position);
    }
}
