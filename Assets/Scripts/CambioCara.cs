using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioCara : MonoBehaviour
{
    /*esto le aumente de codigo par el botn */
    private Button btnSiguiente;
    /*esto le aumente de codigo par el botn */



    public Texture[] texturas;
    public float intervaloCambio = 3.21f, tActual, tInicial;
    private Renderer rend;
    private int indice = 0;

    void Start()
    {



        rend = GetComponent<Renderer>();
        rend.material.mainTexture = texturas[0];
        tInicial = Time.time;


        btnSiguiente = GetComponent<Button>();
        btnSiguiente.onClick.AddListener(BtnSiguiente);
    }


    /*esto le aumente de codigo par el botn */
    public void BtnSiguiente()
    {
        indice++;
        cambiarTextura();
    }
    /*esto le aumente de codigo par el botn */

    public void cambiarTextura()
    {
        switch (indice)
        {
            case 1://cara 1
                rend.material.mainTexture = texturas[0];
                break;
            case 2://cara 1
                rend.material.mainTexture = texturas[1];
                break;
            case 3://cara 1
                rend.material.mainTexture = texturas[2];
                break;
            case 4://cara 1
                rend.material.mainTexture = texturas[3];
                break;
        }
    }



    /**
      void Update(){
          if (texturas.Length == 0) return;
          if (tActual <= intervaloCambio) {
              tActual = Time.time - tInicial;
          }else{ //Fin de ciclo
              tInicial = Time.time;
              tActual = 0;
              if (indice < texturas.Length - 1){
                  indice++;
              }else{
                  indice = 0;
              }
          }
          rend.material.mainTexture = texturas[indice];
      }
    */

}
