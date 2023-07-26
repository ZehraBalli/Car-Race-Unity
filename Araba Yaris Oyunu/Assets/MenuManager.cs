using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    GameObject btnbasla, btnnasiloynanir, btnhakkimda, btnhikaye;

   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BaslangicHareket());
    }

    

    IEnumerator BaslangicHareket()//Baþlangçtaki btn larýn hareketli gelmesini saðlattým.Butonlarýn açýlýnca sýrayla hareketli gelmesi.
    {
         btnbasla.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);
         btnbasla.GetComponent<CanvasGroup>().DOFade(1, 0.4f);

         yield return new WaitForSeconds(0.5f);//aralarýna 0.5 lik zaman koyuyor

         btnnasiloynanir.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);//önce arka kýsým geliyor
         btnnasiloynanir.GetComponent<CanvasGroup>().DOFade(1, 0.4f);//sonra canvastaki butonlar.Görünr oluyorlar.

         yield return new WaitForSeconds(0.5f);

         btnhakkimda.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);
         btnhakkimda.GetComponent<CanvasGroup>().DOFade(1, 0.4f);

         yield return new WaitForSeconds(0.5f);

         btnhikaye.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);
         btnhikaye.GetComponent<CanvasGroup>().DOFade(1, 0.4f);
    }


    public void oyunuac()
    {
        SceneManager.LoadScene(3);
    }

    public void nasiloynanirbtn()
    {
        SceneManager.LoadScene("NasilOynanir");
    }
    public void hakkimdasayfasi()
    {
        SceneManager.LoadScene("Hakkimda");
    }
    public void hikayesayfasi()
    {
        SceneManager.LoadScene("Hikaye");
    }

    
}
