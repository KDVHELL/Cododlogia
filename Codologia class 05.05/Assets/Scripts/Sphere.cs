using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 10f;
    public float speedcam = 10f;
    public float jump = 10f;

    float vertical = 0;
    float horizontal = 0;
    float up = 0;

    void Update()
    {
        vertical = Mathf.Lerp(vertical, Input.GetAxis("Vertical"), Time.deltaTime * 8); //W & S  1 & -1 -> 0    -1..0..1
        horizontal = Mathf.Lerp(horizontal, Input.GetAxis("Horizontal"), Time.deltaTime * 8);
        up = Mathf.Lerp(up, Input.GetAxis("Jump"), Time.deltaTime * 8);

        Vector3 direction = new Vector3(horizontal, up, vertical);
        direction = transform.TransformDirection(direction);
        direction *= speed * Time.deltaTime;

        GetComponent<Rigidbody>().MovePosition(transform.position + direction);
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        
            Debug.Log("Минус!");
        
    }
}
