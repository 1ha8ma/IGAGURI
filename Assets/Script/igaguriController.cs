using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class igaguriController : MonoBehaviour
{
    Vector3 position;

    //“Š‚°‚é
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce (dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
}
