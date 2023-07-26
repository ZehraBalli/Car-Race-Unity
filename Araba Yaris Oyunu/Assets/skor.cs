using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skor : MonoBehaviour
{
    public Text sc;
    public CarHareket carHareket;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sc.text = carHareket.kazanilanpuan.ToString();//puan deðerini text e atýyoruz.
    }
}
