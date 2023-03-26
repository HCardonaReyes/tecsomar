using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenuCanvas;
    [SerializeField]
    private GameObject turismoMenuCanvas;
    [SerializeField]
    private GameObject leyendasMenuCanvas;
    [SerializeField]
    private GameObject mapaMenuCanvas;
    [SerializeField]
    private GameObject comidaTipicaMenuCanvas;
    [SerializeField]
    private GameObject imperdiblesMenuCanvas;
    [SerializeField]
    private GameObject sabiasQueMenuCanvas;
    [SerializeField]
    private GameObject productoTuristicoMenuCanvas;
    [SerializeField]
    private GameObject informacionAdicionalMenuCanvas;

    //Ui de la Realidad Aumentada
    [SerializeField]
    private GameObject RATemploDeSantoDomingoCanvas;
    [SerializeField]
    private GameObject RAJardinZaragozaCanvas;
    [SerializeField]
    private GameObject RAHotelHidalgoCanvas;
    [SerializeField]
    private GameObject RAParroquiaDeSanJuanButistaCanvas;
    [SerializeField]
    private GameObject RAMuseoMunicipalCanvas;
    [SerializeField]
    private GameObject RAJardinConstitucionCanvas;
    [SerializeField]
    private GameObject RAPrecidenciaMunicipalCanvas;
    [SerializeField]
    private GameObject RAConjuntoArquitectonicoDeSanFranciscoCanvas;
    [SerializeField]
    private GameObject RAPlazuelaBelenMataCanvas;
    [SerializeField]
    private GameObject RAConjuntoArquitectonicoDeLaSoledadCanvas;
    [SerializeField]
    private GameObject RACasaDeCulturaCanvas;

    //Ui de Scrolls 

    [SerializeField]
    private GameObject FantasmaPuente;
    [SerializeField]
    private GameObject CerroSombreretillo;
    [SerializeField]
    private GameObject CatrinaItinerante;

    //Ui de Scrolls 
    [SerializeField]
    private GameObject UIRA;




    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnTurismoMenu += ActivateTurismoMenu;
        GameManager.instance.OnLeyendasMenu += ActivateLeyendasMenu;
        GameManager.instance.OnMapaMenu += ActivateMapaMenu;
        GameManager.instance.OnComidaTipicaMenu += ActivateComidaTipicaMenu;
        GameManager.instance.OnImperdiblesMenu += ActivateImperdiblesMenu;
        GameManager.instance.OnSabiasQueMenu += ActivateSabiasQueMenu;
        GameManager.instance.OnProductoTuristicoMenu += ActivateProductoTuristicoMenu;
        GameManager.instance.OnInformacionAdicionalMenu += ActivateInformacionAdicionalMenu;

        //Ui de la Realidad Aumentada
        GameManager.instance.OnRATemploDeSantoDomingo += ActivateRATemploDeSantoDomingo;
        GameManager.instance.OnRAJardinZaragoza += ActivateRAJardinZaragoza;
        GameManager.instance.OnRAHotelHidalgo += ActivateRAHotelHidalgo;
        GameManager.instance.OnRAParroquiaDeSanJuanButista += ActivateRAParroquiaDeSanJuanButista;
        GameManager.instance.OnRAMuseoMunicipal += ActivateRAMuseoMunicipal;
        GameManager.instance.OnRAJardinConstitucion += ActivateRAJardinConstitucion;
        GameManager.instance.OnRAPrecidenciaMunicipal += ActivateRAPrecidenciaMunicipal;
        GameManager.instance.OnRAConjuntoArquitectonicoDeSanFrancisco += ActivateRAConjuntoArquitectonicoDeSanFrancisco;
        GameManager.instance.OnRAPlazuelaBelenMata += ActivateRAPlazuelaBelenMata;
        GameManager.instance.OnRAConjuntoArquitectonicoDeLaSoledad += ActivateAConjuntoArquitectonicoDeLaSoledad;
        GameManager.instance.OnRACasaDeCultura += ActivateRACasaDeCultura;

        //Ui de scrolls
        GameManager.instance.OnRegresarLeyendas += ActivateLeyendasMenu;
        GameManager.instance.OnFantasmaPuente += ActivateFantasmaPuente;
        GameManager.instance.OnCerroSombreretillo += ActivateCerroSombreretillo;
        GameManager.instance.OnCatrinaItinerante += ActivateCatrinaItinerante;

        //Ui de scrolls
        GameManager.instance.OnUIRA += ActivateUIRA;

        ActivateMainMenu();
    }


    private void ActivateMainMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, true);
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(leyendasMenuCanvas, false);
        ActivarDesactivarMenu(mapaMenuCanvas, false);
        ActivarDesactivarMenu(comidaTipicaMenuCanvas, false);
        ActivarDesactivarMenu(imperdiblesMenuCanvas, false);
        ActivarDesactivarMenu(sabiasQueMenuCanvas, false);
        ActivarDesactivarMenu(productoTuristicoMenuCanvas, false);
        ActivarDesactivarMenu(informacionAdicionalMenuCanvas, false);
        ActivarDesactivarMenu(FantasmaPuente, false);
        ActivarDesactivarMenu(CerroSombreretillo, false);
        ActivarDesactivarMenu(CatrinaItinerante, false);
    }

    private void DesactivateAll()
    {
        ActivarDesactivarMenu(turismoMenuCanvas, false);
        ActivarDesactivarMenu(leyendasMenuCanvas, false);
        ActivarDesactivarMenu(mapaMenuCanvas, false);
        ActivarDesactivarMenu(comidaTipicaMenuCanvas, false);
        ActivarDesactivarMenu(imperdiblesMenuCanvas, false);
        ActivarDesactivarMenu(sabiasQueMenuCanvas, false);
        ActivarDesactivarMenu(productoTuristicoMenuCanvas, false);
        ActivarDesactivarMenu(informacionAdicionalMenuCanvas, false);
        //UI de scroll
        ActivarDesactivarMenu(FantasmaPuente, false);
        ActivarDesactivarMenu(CerroSombreretillo, false);
        ActivarDesactivarMenu(CatrinaItinerante, false);
    }


        private void ActivateProductoTuristicoMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(productoTuristicoMenuCanvas, true);
    }

    private void ActivateInformacionAdicionalMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(informacionAdicionalMenuCanvas, true);
    }

    private void ActivateImperdiblesMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(imperdiblesMenuCanvas, true);

    }

    private void ActivateComidaTipicaMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(comidaTipicaMenuCanvas, true);
    }

    private void ActivateSabiasQueMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(sabiasQueMenuCanvas, true);
    }

    private void ActivateMapaMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(mapaMenuCanvas, true);
    }

    private void ActivateLeyendasMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        //Scrolls 
        ActivarDesactivarMenu(FantasmaPuente, false);
        ActivarDesactivarMenu(CerroSombreretillo, false);
        ActivarDesactivarMenu(CatrinaItinerante, false);
        ActivarDesactivarMenu(leyendasMenuCanvas, true);
    }

    private void ActivateTurismoMenu()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(turismoMenuCanvas, true);
    }

    //Ui de la Realidad Aumentada
    private void ActivateRATemploDeSantoDomingo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(RATemploDeSantoDomingoCanvas, true);
    }
    private void ActivateRAJardinZaragoza()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(RAJardinZaragozaCanvas, true);
    }
    private void ActivateRAHotelHidalgo()
    {

    }
    private void ActivateRAParroquiaDeSanJuanButista()
    {

    }
    private void ActivateRAMuseoMunicipal()
    {

    }
    private void ActivateRAJardinConstitucion()
    {

    }
    private void ActivateRAPrecidenciaMunicipal()
    {

    }
    private void ActivateRAConjuntoArquitectonicoDeSanFrancisco()
    {

    }

    private void ActivateRAPlazuelaBelenMata()
    {

    }
    private void ActivateAConjuntoArquitectonicoDeLaSoledad()
    {

    }
    private void ActivateRACasaDeCultura()
    {

    }

    //Metodos del scroll
    private void ActivateFantasmaPuente()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(FantasmaPuente, true);
    }

    private void ActivateCerroSombreretillo()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(CerroSombreretillo, true);
    }

    private void ActivateCatrinaItinerante()
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(CatrinaItinerante, true);
    }

    private void ActivateUIRA(string txt)
    {
        ActivarDesactivarMenu(mainMenuCanvas, false);
        ActivarDesactivarMenu(CatrinaItinerante, true);

        DesactivateAll();
        UIRA.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.GetComponentInChildren<GenRAScript>().setTitulo(txt);
    }


    private void ActivarDesactivarMenu(GameObject menu, bool activarDesactivar)
    {
        for (int i = 0; i < menu.transform.childCount; i++)
        {
            Transform child = menu.transform.GetChild(i);
            if (activarDesactivar == true)
            {
                child.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
            }
            else
            {
                child.transform.DOScale(new Vector3(0, 0, 0), 0.5f);
            }
        }

        Debug.Log(menu.name + " " + menu.transform.childCount + " " + activarDesactivar.ToString());
    }


}

