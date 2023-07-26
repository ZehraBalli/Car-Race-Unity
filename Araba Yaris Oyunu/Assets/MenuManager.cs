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

    

    IEnumerator BaslangicHareket()//Ba�lang�taki btn lar�n hareketli gelmesini sa�latt�m.Butonlar�n a��l�nca s�rayla hareketli gelmesi.
    {
         btnbasla.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);
         btnbasla.GetComponent<CanvasGroup>().DOFade(1, 0.4f);

         yield return new WaitForSeconds(0.5f);//aralar�na 0.5 lik zaman koyuyor

         btnnasiloynanir.GetComponent<RectTransform>().DOScale(1, 0.4f).SetEase(Ease.OutBack);//�nce arka k�s�m geliyor
         btnnasiloynanir.GetComponent<CanvasGroup>().DOFade(1, 0.4f);//sonra canvastaki butonlar.G�r�nr oluyorlar.

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
