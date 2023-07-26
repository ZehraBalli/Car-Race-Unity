using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SplashScreen : MonoBehaviour
{
    [SerializeField]
    GameObject logoimages, altin, altin1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ElemanlariGetir());
    }

   IEnumerator ElemanlariGetir()//x, y deðerlerine göre resimlerin ana ekrana kayarak gelmesi
    {
        logoimages.GetComponent<CanvasGroup>().DOFade(1, 1f);
        logoimages.GetComponent<RectTransform>().DOLocalMoveY(-45, 1f).SetEase(Ease.OutBack);

        yield return new WaitForSeconds(.2f);

        altin1.GetComponent<CanvasGroup>().DOFade(1, 1f);
        altin1.GetComponent<RectTransform>().DOLocalMoveY(-71, 1f).SetEase(Ease.OutBack);
        altin1.GetComponent<RectTransform>().DOLocalMoveX(280, 1f).SetEase(Ease.OutBack);

        yield return new WaitForSeconds(.2f);

        altin.GetComponent<CanvasGroup>().DOFade(1, 1f);
        altin.GetComponent<RectTransform>().DOLocalMoveY(72, 1f).SetEase(Ease.OutBack);
        altin.GetComponent<RectTransform>().DOLocalMoveX(-271, 1f).SetEase(Ease.OutBack);

        yield return new WaitForSeconds(3);//açýlýþ ekraaný gelmesi için 3 s beklettim

        SceneManager.LoadScene("AnaMenu");

    }
   
    


}
