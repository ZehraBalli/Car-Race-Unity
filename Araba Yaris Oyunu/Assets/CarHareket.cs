using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarHareket : MonoBehaviour
{   //puan altýn demek.Kazanilanpuan elde edilen toplam sayý demek.Etiketleri bu þrkilde verdim.
    bool gameover = false;//oyun bitmesine açýlýnca false olsun diye
    public int kazanilanpuan = 0;//puan tutacak 
    public Text basaritxt;//baþarý text ine deðer atama
   
    [SerializeField]
    GameObject sonucpanel, btntekraroyna,btncikis,basarisonucu;//oyundaki btn ile atama için
    
   
    
   

    // Start is called before the first frame update
    void Start()
    {
    }

    
    // Update is called once per frame

    /*IEnumerator OyunuBitirRoutine()
    {
         yield return new WaitForSeconds(2f);

         
         sonucpanel.GetComponent<CanvasGroup>().DOFade(1, 2f);
         sonucpanel.GetComponent<RectTransform>().DOScale(1, 2f).SetEase(Ease.OutBack);
        
    }*/
    public void bitir()
    {
       

        sonucpanel.GetComponent<CanvasGroup>().DOFade(1, 5f);//sonuç panelindeki canvas 1 de görünür yapýyoruz.
        sonucpanel.GetComponent<RectTransform>().DOScale(1, 5f).SetEase(Ease.OutBack);//objenin boyutlarýný deðiþtiriyor.setease deðiþkenin deðerinin hedef deðere ne tarz bir yumuþaklýkta hareket edeceðini belirliyor.

    }
   
    public void oyunsonubasari()
    {
        if (kazanilanpuan < 15)
        {
            basaritxt.text = "Baþarý Düzeyi:Düþük";
        }
        else 
        {
            basaritxt.text = "Baþarý Düzeyi:Yüksek";
        }

    }



    public void Update()
    {
        if (gameover == false)
            GetComponent<Rigidbody>().AddForce(Vector3.left * 10, ForceMode.Force);//Arabaya sürekli bir hareketlilik kazandýrdým.
        else if (gameover == true)//oyun bittiyse
            GetComponent<Rigidbody>().velocity = Vector3.zero;//arabanýn hýzýný sýfýr yapýyor


        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 4, ForceMode.Force);//tuþa basýldýðýnda yönlere ne kadarlýk açýyla gideceði.direksiyonun ne kadar hýzlý dönmesi gibi.
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -4, ForceMode.Force);
        }

        //if (GetComponent<Rigidbody>().position.x <= -235)
        //{
        //    gameover = true;
        //    GetComponent<Rigidbody>().velocity = Vector3.zero;
        //   // bitir();
        //}
        
    }
    

    private void OnCollisionEnter(Collision collision)//herhangi bir çarpýþma anýnda çaðýrýlacak metot
    {
        if(collision.collider.tag == "Engel")//çarpýþma var mý diye oluþturduðum tag a bakýyor.
        {
           gameover = true;
           GetComponent<Rigidbody>().velocity = Vector3.zero;
           
           bitir();
           
        }
        if(collision.collider.tag == "Puan")//altýn alma kýsmý 
        {
           kazanilanpuan++;
           Destroy(collision.gameObject);//çarpýnca yok et
        }
        if (collision.collider.tag == "Agac")
        {
            gameover = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            
            bitir(); ;
            
        }
    }
   

   
    public void tekraroyna()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void btnoyundancik()
    {
        SceneManager.LoadScene(1);
    }
    

}
