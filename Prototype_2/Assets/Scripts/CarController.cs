using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;




public class CarController : MonoBehaviour
{
    [Header("Movement Variables")]

    [SerializeField] float rotationSpeed = 5f;
    [SerializeField] float moveSpeed;

    float xRot;
    float yRot;

    Rigidbody RB;
   
    [SerializeField]
    Transform[] carWheels;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
        transform.DORotateQuaternion(Quaternion.Euler(0f, yRot, 0f), 0.15f);
        WheelsRotate();
        if (Input.GetMouseButtonDown(0))
        {
            return;
        }

        // handling rotation

        if (Input.GetMouseButton(0))
        {

            yRot += Input.GetAxis("Mouse X") * rotationSpeed;
            yRot = Mathf.Clamp(yRot, -20f, 20f);

        }
        else
        {

            yRot = 0f;

        }


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.3f, 2.3f), transform.position.y,
            transform.position.z);

    }

    private void WheelsRotate()
    {

        for (int i = 0; i < carWheels.Length; i++)
        {
            carWheels[i].Rotate(Vector3.right * rotationSpeed, rotationSpeed + 100f * Time.deltaTime);
        }
    }

}
