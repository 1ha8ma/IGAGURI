using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class igaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    GameObject igaguri;
    Vector3 hitposition;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //ÉNÉäÉbÉNÇ≈ü{åIÇê∂ê¨Çµë±ÇØÇÈ
        if (Input.GetMouseButtonDown(0))
        {
            igaguri = Instantiate(igaguriPrefab);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            igaguri.GetComponent<igaguriController>().Shoot(worldDir.normalized * 2000);
        }
    }
}