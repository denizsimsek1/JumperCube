using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Yonetici : MonoBehaviour
{
    public TMP_Text skor;
    public static float skorSayisi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skor.text = "Score: " + skorSayisi;
    }
}
