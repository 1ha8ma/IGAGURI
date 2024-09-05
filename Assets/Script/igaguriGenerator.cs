using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class igaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    int igagurinum;

    private void Start()
    {
        igagurinum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //ÉNÉäÉbÉNÇ≈ü{åIÇê∂ê¨Çµë±ÇØÇÈ
        if (Input.GetMouseButtonDown(0) && igagurinum < 10)
        {
            GameObject igaguri = Instantiate(igaguriPrefab);
            //igaguri.GetComponent<igaguriController>().Shoot(new Vector3(0, 200, 2000));

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            igaguri.GetComponent<igaguriController>().Shoot(worldDir.normalized * 2000);

            igagurinum++;
        }
    }
}
