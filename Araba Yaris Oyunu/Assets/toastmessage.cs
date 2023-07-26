using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;//nesne y�nelimli animasyon motoru
public class toastmessage : MonoBehaviour
{
    [SerializeField]
     GameObject toestmPanel, btn;
    public Text toestText;
    float sayac;
    bool isToesting;
    // Start is called before the first frame update
    void Start()
    {
        TestMesaj("Ho�geldiniz!" + "A tu�u ile sola, D tu�u ile sol y�ne giderek engellerde �arpmaktan kurtulabilirsiniz." +"Ne kadar �ok alt�n toplarsan�z o kadar y�ksek puan elde edeceksiniz.Ba�ar�lar!", 10);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isToesting)
        {
            sayac -= Time.deltaTime;//zaman� azalt
            if (sayac < 0)
            {//k���k olursa de�rleri false et
                toestmPanel.SetActive(false);
                isToesting = false;
            }
          }
    }
    void TestMesaj(string mesaj, float sure)
    {//de�er atamalar�n� yapt�m
        toestText.text = mesaj;
        isToesting = true;
        sayac = sure;
        toestmPanel.SetActive(true);//paneli g�ster
       
    }
    public void oyunagec()
    {
        SceneManager.LoadScene("SampleScene");
    }
   
}
