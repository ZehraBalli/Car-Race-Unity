using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;//nesne yönelimli animasyon motoru
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
        TestMesaj("Hoþgeldiniz!" + "A tuþu ile sola, D tuþu ile sol yöne giderek engellerde çarpmaktan kurtulabilirsiniz." +"Ne kadar çok altýn toplarsanýz o kadar yüksek puan elde edeceksiniz.Baþarýlar!", 10);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isToesting)
        {
            sayac -= Time.deltaTime;//zamaný azalt
            if (sayac < 0)
            {//küçük olursa deðrleri false et
                toestmPanel.SetActive(false);
                isToesting = false;
            }
          }
    }
    void TestMesaj(string mesaj, float sure)
    {//deðer atamalarýný yaptým
        toestText.text = mesaj;
        isToesting = true;
        sayac = sure;
        toestmPanel.SetActive(true);//paneli göster
       
    }
    public void oyunagec()
    {
        SceneManager.LoadScene("SampleScene");
    }
   
}
