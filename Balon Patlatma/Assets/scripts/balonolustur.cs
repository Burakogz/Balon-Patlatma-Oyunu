using UnityEngine;

public class balonolustur : MonoBehaviour
{
    public GameObject balon;

    float BalonOlusturmaSuresi = 1f; 
    float ZamanSayaci = 0f;
    oyunkontrolcu oyunkontrolcuscripti;

    // Minimum balon oluþturma süresi
    public float MinBalonOlusturmaSuresi = 0.3f; 

    // Balon oluþturma süresini azaltma hýzýný kontrol etmek için bir çarpan
    public float AzalmaHizi = 0.002f; 

    void Start()
    {
        oyunkontrolcuscripti = GameObject.Find("_scripts").GetComponent<oyunkontrolcu>();
    }

    void Update()
    {
        ZamanSayaci -= Time.deltaTime;
        int katsayi = (int)(oyunkontrolcuscripti.zamansayaci / 20) - 3; 
        katsayi *= -1;

        // Zamanla BalonOlusturmaSuresi'ni azalt
        BalonOlusturmaSuresi = Mathf.Max(MinBalonOlusturmaSuresi, BalonOlusturmaSuresi - AzalmaHizi);

        if (ZamanSayaci < 0 && oyunkontrolcuscripti.zamansayaci > 0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.6f, 2.6f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f * katsayi, 150f * katsayi), 0));
            ZamanSayaci = BalonOlusturmaSuresi;
        }
    }
}
