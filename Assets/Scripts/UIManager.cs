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
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        /*
        turismoMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        leyendasMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        mapaMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mapaMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        comidaTipicaMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        comidaTipicaMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        comidaTipicaMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        imperdiblesMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        imperdiblesMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        imperdiblesMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        sabiasQueMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        sabiasQueMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        sabiasQueMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        productoTuristicoMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        productoTuristicoMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        productoTuristicoMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        informacionAdicionalMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        informacionAdicionalMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        informacionAdicionalMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        //Ui de la Realidad Aumentada
        RATemploDeSantoDomingoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RATemploDeSantoDomingoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RATemploDeSantoDomingoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAJardinZaragozaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinZaragozaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinZaragozaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAHotelHidalgoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAHotelHidalgoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAHotelHidalgoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAMuseoMunicipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAMuseoMunicipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAMuseoMunicipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAJardinConstitucionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinConstitucionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinConstitucionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAPrecidenciaMunicipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPrecidenciaMunicipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPrecidenciaMunicipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAPlazuelaBelenMataCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPlazuelaBelenMataCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPlazuelaBelenMataCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RACasaDeCulturaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RACasaDeCulturaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RACasaDeCulturaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        //UI de scroll
        FantasmaPuente.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);


        CerroSombreretillo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        CatrinaItinerante.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        */
        DesactivateAll();
    }

    private void DesactivateAll()
    {
        turismoMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        turismoMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        leyendasMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        mapaMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mapaMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        comidaTipicaMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        comidaTipicaMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        comidaTipicaMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        imperdiblesMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        imperdiblesMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        imperdiblesMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        sabiasQueMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        sabiasQueMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        sabiasQueMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        productoTuristicoMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        productoTuristicoMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        productoTuristicoMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        informacionAdicionalMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        informacionAdicionalMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        informacionAdicionalMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        //Ui de la Realidad Aumentada
        RATemploDeSantoDomingoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RATemploDeSantoDomingoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RATemploDeSantoDomingoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAJardinZaragozaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinZaragozaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinZaragozaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAHotelHidalgoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAHotelHidalgoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAHotelHidalgoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAMuseoMunicipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAMuseoMunicipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAMuseoMunicipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAJardinConstitucionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinConstitucionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAJardinConstitucionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAPrecidenciaMunicipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPrecidenciaMunicipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPrecidenciaMunicipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAPlazuelaBelenMataCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPlazuelaBelenMataCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAPlazuelaBelenMataCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RACasaDeCulturaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RACasaDeCulturaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        RACasaDeCulturaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        //UI de scroll
        FantasmaPuente.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);


        CerroSombreretillo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        CatrinaItinerante.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

    }


        private void ActivateProductoTuristicoMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        productoTuristicoMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        productoTuristicoMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        productoTuristicoMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);

    }

    private void ActivateInformacionAdicionalMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        informacionAdicionalMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        informacionAdicionalMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        informacionAdicionalMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateImperdiblesMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        imperdiblesMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        imperdiblesMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        imperdiblesMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);

    }

    private void ActivateComidaTipicaMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        comidaTipicaMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        comidaTipicaMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        comidaTipicaMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateSabiasQueMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        sabiasQueMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        sabiasQueMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        sabiasQueMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateMapaMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        mapaMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        mapaMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateLeyendasMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        //Scrolls
        FantasmaPuente.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        FantasmaPuente.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);


        CerroSombreretillo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CerroSombreretillo.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        CatrinaItinerante.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        CatrinaItinerante.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        leyendasMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        leyendasMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        leyendasMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        leyendasMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        leyendasMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateTurismoMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        turismoMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        turismoMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        turismoMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        turismoMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        turismoMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    //Ui de la Realidad Aumentada
    private void ActivateRATemploDeSantoDomingo()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RATemploDeSantoDomingoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RATemploDeSantoDomingoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RATemploDeSantoDomingoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateRAJardinZaragoza()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAJardinZaragozaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAJardinZaragozaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAJardinZaragozaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateRAHotelHidalgo()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAHotelHidalgoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAHotelHidalgoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAHotelHidalgoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateRAParroquiaDeSanJuanButista()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAParroquiaDeSanJuanButistaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);

    }
    private void ActivateRAMuseoMunicipal()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAMuseoMunicipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAMuseoMunicipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAMuseoMunicipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateRAJardinConstitucion()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAJardinConstitucionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAJardinConstitucionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAJardinConstitucionCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateRAPrecidenciaMunicipal()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAPrecidenciaMunicipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAPrecidenciaMunicipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAPrecidenciaMunicipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateRAConjuntoArquitectonicoDeSanFrancisco()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAConjuntoArquitectonicoDeSanFranciscoCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateRAPlazuelaBelenMata()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAPlazuelaBelenMataCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAPlazuelaBelenMataCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAPlazuelaBelenMataCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateAConjuntoArquitectonicoDeLaSoledad()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RAConjuntoArquitectonicoDeLaSoledadCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }
    private void ActivateRACasaDeCultura()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        mainMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        RACasaDeCulturaCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RACasaDeCulturaCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        RACasaDeCulturaCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    //Metodos del scroll
    private void ActivateFantasmaPuente()
    {
        leyendasMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        FantasmaPuente.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        FantasmaPuente.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        FantasmaPuente.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        FantasmaPuente.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        FantasmaPuente.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        FantasmaPuente.transform.GetChild(5).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        FantasmaPuente.transform.GetChild(6).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateCerroSombreretillo()
    {
        leyendasMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        CerroSombreretillo.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CerroSombreretillo.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CerroSombreretillo.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CerroSombreretillo.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CerroSombreretillo.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CerroSombreretillo.transform.GetChild(5).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateCatrinaItinerante()
    {
        leyendasMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        leyendasMenuCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(5).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(6).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(7).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //leyendasMenuCanvas.transform.GetChild(8).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        CatrinaItinerante.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(5).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(6).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(7).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        CatrinaItinerante.transform.GetChild(8).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateUIRA(string txt)
    {
        DesactivateAll();
        UIRA.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        UIRA.GetComponentInChildren<GenRAScript>().setTitulo(txt);
    }





}

