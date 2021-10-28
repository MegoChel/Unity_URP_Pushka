using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class CanonFire : MonoBehaviour
{
    public float CanonballVelocity;

    public GameObject FireButton;
    public GameObject Canonball;
    public GameObject Lever;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shoot()
    {
        //GameObject intantiateObject = Instantiate(Canonball, Barel_end.transform.position, Quaternion.LookRotation(transform.forward));
        //Rigidbody rigidbody = intantiateObject.GetComponent<Rigidbody>();
        //rigidbody.velocity = Barel_end.transform.up * CanonballVelocity;
        Rigidbody rigidbody = Canonball.GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * (Lever.GetComponent<LinearMapping>().value * 100);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
            Shoot();
        //if (FireButton.GetComponent<HoverButton>().buttonDown)
        //    Shoot();
        //if (Input.GetKey(KeyCode.DownArrow))
        //    if (transform.rotation.x > 0.41)
        //        transform.Rotate(0, -0.1f, 0);
        //if (Input.GetKey(KeyCode.UpArrow))
        //    if (transform.rotation.x < 0.707)
        //        transform.Rotate(0, 0.1f, 0);
        //Debug.Log(transform.rotation.eulerAngles.x);
        //if (Input.GetKeyUp(KeyCode.C))
        //    Debug.Log(Lever.GetComponent<LinearMapping>().value);
        //float value = Lever.GetComponent<LinearMapping>().value;
    }

    private void OnTriggerStay(Collider other)
    {
        Canonball = other.gameObject;
    }
    private void OnTriggerExit(Collider other)
    {
        Canonball = null;
    }
}
