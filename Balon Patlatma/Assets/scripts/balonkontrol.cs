using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonkontrol : MonoBehaviour
{
    public GameObject patlama;
    oyunkontrolcu oyunkontrolcuScripti;

    void Start()
    {
        oyunkontrolcuScripti = GameObject.Find("_scripts").GetComponent<oyunkontrolcu>();
    }

    private void OnMouseDown()
    {
        GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        oyunkontrolcuScripti.BalonEkle();  // Balon patladýðýnda sayýyý artýr
        Destroy(this.gameObject);
        Destroy(go, 0.350f);
    }
}
