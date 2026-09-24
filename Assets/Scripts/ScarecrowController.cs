using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ScarecrowController : MonoBehaviour
{

    public Camera mainCamera;
    public Transform rotationPivot;
    public float rotationSpeed = 5f;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray mouseRay = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        if (Physics.Raycast(mouseRay, out hit))
        {
            Vector3 aimDirection = hit.point - transform.position;
            aimDirection.y = 0;

            Quaternion targetRotation = Quaternion.LookRotation(aimDirection);
            rotationPivot.rotation = Quaternion.Slerp(rotationPivot.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        }

    }
}
