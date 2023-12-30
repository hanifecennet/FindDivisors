using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    private void Awake() //hepsinden once gelir
    {

    }
    float [] liste = {2f, 2.2f, 5f, 10f, 10.5f}; //soradan liste elemanlari degismesi cok iyi degil
    // Start is called before the first frame update
    void Start()
    {
        liste[0] = 22.4f;
        string listeString = "";
        foreach (float eleman in liste)
        {
            listeString += " " + eleman;
        }
        print(" tum liste elemanlari : " +listeString);

        //daha dinamik
        ArrayList myList = new ArrayList();
        myList.Add(22);
        myList.Add(56);


        foreach (int eleman in myList)
        {
            print(eleman);
        }
    }

    // Update is called once per frame
    void Update() //30/60 defa, fps(saniyedeki cerceve sayisi) sayisi kadar icindeki islemleri yapar
    {              //cpu daki isinmalar sonucu islemler gecikebiliyor
        
    }

    private void FixedUpdate() //sabit olarak 60 defa sn de islemleri yapar, donanimsal olarak bir sikintisi yok, hassas islemlerde kullanilami
    {

    }
    private void LateUpdate() //gecikmeli, kosma update'te, skor burada tutulur
    {

    }
}
