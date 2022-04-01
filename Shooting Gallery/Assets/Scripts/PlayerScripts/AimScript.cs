using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour
{
    public float aimSpeed = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    [SerializeField] private float projectileSpeed;
    public Rigidbody projectile;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        MouseLook();

        if (Input.GetMouseButtonDown(0))
        {
            ShootProjectile();
        }
    }

    public void MouseLook()
    {
        float xAxis = Input.GetAxis("Mouse X") * aimSpeed * Time.deltaTime;
        float yAxis = Input.GetAxis("Mouse Y") * aimSpeed * Time.deltaTime;

        xRotation -= yAxis;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * xAxis);
    }

    void ShootProjectile()
    {
        Rigidbody projectileClone = (Rigidbody)Instantiate(projectile, transform.position, transform.rotation);
        projectileClone.velocity = transform.forward * projectileSpeed;
    }

}
