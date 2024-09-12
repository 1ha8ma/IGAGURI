using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class igaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    public  int igagurinum;
    Vector3 hitposition;

    private void Start()
    {
        igagurinum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //ƒNƒŠƒbƒN‚ÅŸ{ŒI‚ğ¶¬‚µ‘±‚¯‚é(10ŒÂ‚Ü‚Å)
        if (Input.GetMouseButtonDown(0))
        {
            GameObject igaguri = Instantiate(igaguriPrefab);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            igaguri.GetComponent<igaguriController>().Shoot(worldDir.normalized * 2000);

            igagurinum++;
        }
    }

    public int GetIgagurinum()
    {
        return igagurinum;
    }
}