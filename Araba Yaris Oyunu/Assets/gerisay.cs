using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class gerisay : MonoBehaviour
{
   [SerializeField]
    TMP_Text kalansaniyetxt;
    bool gameoverr = false;
    [SerializeField]
    GameObject sonucpanel;

    public int kalanzaman = 8;
    
    private void Start()
    {
       StartCoroutine(GeriSayRoutine());
    }

    IEnumerator GeriSayRoutine()
    {
        while(kalanzaman>0)
        {
            yield return new WaitForSeconds(1f);
            kalansaniyetxt.text = kalanzaman.ToString() + "s";//text e kalan zamaný atýyoruz
            kalanzaman--;//1 azaltýyor.

            if(kalanzaman<=0)
            {
                gameoverr = true;
               
                StartCoroutine(OyunuBitirRoutine());//belirli bir zaman aralýðýnda bunu çalýþtýrmamýzý saðlýyor.
            }
        }
    }
    private void Update()
    {
        

    }
    IEnumerator OyunuBitirRoutine()
    {
        yield return new WaitForSeconds(1f);
        
        sonucpanel.GetComponent<CanvasGroup>().DOFade(1, 2f);
        sonucpanel.GetComponent<RectTransform>().DOScale(1, 2f).SetEase(Ease.OutBack);

    }
}
