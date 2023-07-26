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
{   //puan alt�n demek.Kazanilanpuan elde edilen toplam say� demek.Etiketleri bu �rkilde verdim.
    bool gameover = false;//oyun bitmesine a��l�nca false olsun diye
    public int kazanilanpuan = 0;//puan tutacak 
    public Text basaritxt;//ba�ar� text ine de�er atama
   
    [SerializeField]
    GameObject sonucpanel, btntekraroyna,btncikis,basarisonucu;//oyundaki btn ile atama i�in
    
   
    
   

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
       

        sonucpanel.GetComponent<CanvasGroup>().DOFade(1, 5f);//sonu� panelindeki canvas 1 de g�r�n�r yap�yoruz.
        sonucpanel.GetComponent<RectTransform>().DOScale(1, 5f).SetEase(Ease.OutBack);//objenin boyutlar�n� de�i�tiriyor.setease de�i�kenin de�erinin hedef de�ere ne tarz bir yumu�akl�kta hareket edece�ini belirliyor.

    }
   
    public void oyunsonubasari()
    {
        if (kazanilanpuan < 15)
        {
            basaritxt.text = "Ba�ar� D�zeyi:D���k";
        }
        else 
        {
            basaritxt.text = "Ba�ar� D�zeyi:Y�ksek";
        }

    }



    public void Update()
    {
        if (gameover == false)
            GetComponent<Rigidbody>().AddForce(Vector3.left * 10, ForceMode.Force);//Arabaya s�rekli bir hareketlilik kazand�rd�m.
        else if (gameover == true)//oyun bittiyse
            GetComponent<Rigidbody>().velocity = Vector3.zero;//araban�n h�z�n� s�f�r yap�yor


        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 4, ForceMode.Force);//tu�a bas�ld���nda y�nlere ne kadarl�k a��yla gidece�i.direksiyonun ne kadar h�zl� d�nmesi gibi.
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
    

    private void OnCollisionEnter(Collision collision)//herhangi bir �arp��ma an�nda �a��r�lacak metot
    {
        if(collision.collider.tag == "Engel")//�arp��ma var m� diye olu�turdu�um tag a bak�yor.
        {
           gameover = true;
           GetComponent<Rigidbody>().velocity = Vector3.zero;
           
           bitir();
           
        }
        if(collision.collider.tag == "Puan")//alt�n alma k�sm� 
        {
           kazanilanpuan++;
           Destroy(collision.gameObject);//�arp�nca yok et
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
