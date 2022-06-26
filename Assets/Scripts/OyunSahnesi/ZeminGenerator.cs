using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGenerator : MonoBehaviour
{
    public GameObject zemin;
    Transform tr;
    public int zeminSayisi;
    public float zeminGenislik;
    public float minimumY, maximumY;
    

    private void Start()
    {
      
    }
    private void Update()
    {
        tr = zemin.GetComponent<Transform>();
        Vector3 spawnKonumu = new Vector3();
        Vector2 yeniScale = new Vector2();

        for (int i = 0; i < zeminSayisi; i++)
        {
            yeniScale.x = Random.Range(0.9f, 1.1f);
            yeniScale.y = Random.Range(0.9f, 1.1f);
            tr.localScale = yeniScale;

            spawnKonumu.y += Random.Range(minimumY, maximumY);
            spawnKonumu.x = Random.Range(-zeminGenislik, zeminGenislik);

            Instantiate(zemin, spawnKonumu, Quaternion.identity);


        }

    }
}
