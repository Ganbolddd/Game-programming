using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform weapon;
    public Transform bairshil;
    float xErgelt;
    float yErgelt;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {


        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yErgelt += mouseX;
        xErgelt -= mouseY;

        xErgelt = Mathf.Clamp(xErgelt, -90f, 90f);
        transform.rotation = Quaternion.Euler(xErgelt, yErgelt, 0);
        bairshil.rotation = Quaternion.Euler(0, yErgelt, 0);
    }
    private void LateUpdate()
    {
        weapon.position = transform.position;
        weapon.rotation = transform.rotation;
    }
}