using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrolcu : MonoBehaviour
{

    public UnityEngine.UI.Text zamanText, balonText;
    public float zamansayaci = 5;
    int patlayanBalon = 0;
    public GameObject patlama;
    void Start()
    {
        balonText.text = "Skor:" + patlayanBalon;
    }

    void Update()
    {
        if (zamansayaci > 0)
        {
            zamansayaci -= Time.deltaTime;
            zamanText.text = "Süre:" + (int)zamansayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for (int i= 0; i < go.Length; i++) {
                {
                    Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                    Destroy(go[i]);
                }
            }
        }

             
    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Skor:" + patlayanBalon;
    }
}
