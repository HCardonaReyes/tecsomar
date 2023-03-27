using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnTurismoMenu;
    public event Action OnLeyendasMenu;
    public event Action OnMapaMenu;
    public event Action OnComidaTipicaMenu;
    public event Action OnImperdiblesMenu;
    public event Action OnSabiasQueMenu;
    public event Action OnProductoTuristicoMenu;
    public event Action OnInformacionAdicionalMenu;

    //Ui de la Realidad Aumentada
    public event Action OnRATemploDeSantoDomingo;
    public event Action OnRAJardinZaragoza;
    public event Action OnRAHotelHidalgo;
    public event Action OnRAParroquiaDeSanJuanButista;
    public event Action OnRAMuseoMunicipal;
    public event Action OnRAJardinConstitucion;
    public event Action OnRAPrecidenciaMunicipal;
    public event Action OnRAConjuntoArquitectonicoDeSanFrancisco;
    public event Action OnRAPlazuelaBelenMata;
    public event Action OnRAConjuntoArquitectonicoDeLaSoledad;
    public event Action OnRACasaDeCultura;

    //Ui de scrolls
    public event Action OnRegresarLeyendas;
    public event Action OnFantasmaPuente;
    public event Action OnCerroSombreretillo;
    public event Action OnCatrinaItinerante;

    //UI de RA 
    public event Action<string, AudioClip> OnUIRA;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       // OnMainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Menu activado");
    }

    public void TurismoMenu() {
        OnTurismoMenu?.Invoke();
        Debug.Log("Turismo menu activado");
    }
    public void LeyendasMenu() {
        OnLeyendasMenu?.Invoke();
        Debug.Log("Leyendas menu activado");
    }
    public void MapaMenu() {
        OnMapaMenu?.Invoke();
        Debug.Log("Mapa menu activado");
    }
    public void ComidaTipicaMenu() {
        OnComidaTipicaMenu?.Invoke();
        Debug.Log("Comida menu activado");
    }
    public void ImperdiblesMenu() {
        OnImperdiblesMenu?.Invoke();
        Debug.Log("Imperdibles menu activado");
    }
    public void SabiasQueMenu() {
        OnSabiasQueMenu?.Invoke();
        Debug.Log("SabiasQue menu activado");
    }

    public void ProductoTuristicoMenu()
    {
        OnProductoTuristicoMenu?.Invoke();
        Debug.Log("ProductoTuristico menu activado");
    }
    public void InformacionAdicionalMenu() {
        OnInformacionAdicionalMenu?.Invoke();
        Debug.Log("InformacionAdicional menu activado");
    }

    //Ui de la Realidad Aumentada
    public void RATemploDeSantoDomingo()
    {
        OnRATemploDeSantoDomingo?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAJardinZaragoza()
    {
        OnRAJardinZaragoza?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAHotelHidalgo()
    {
        OnRAHotelHidalgo?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAParroquiaDeSanJuanButista()
    {
        OnRAParroquiaDeSanJuanButista?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAMuseoMunicipal()
    {
        OnRAMuseoMunicipal?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAJardinConstitucion()
    {
        OnRAJardinConstitucion?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAPrecidenciaMunicipal()
    {
        OnRAPrecidenciaMunicipal?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAConjuntoArquitectonicoDeSanFrancisco()
    {
        OnRAConjuntoArquitectonicoDeSanFrancisco?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAPlazuelaBelenMata()
    {
        OnRAPlazuelaBelenMata?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RAConjuntoArquitectonicoDeLaSoledad()
    {
        OnRAConjuntoArquitectonicoDeLaSoledad?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }
    public void RACasaDeCultura()
    {
        OnRACasaDeCultura?.Invoke();
        Debug.Log("RealidadAumentada menu activado");
    }



    //Ui de scrolls
    public void RegresarLeyendas()
    {
        OnRegresarLeyendas?.Invoke();
        Debug.Log("RegresarLeyendas menu activado");
    }

    public void FantasmaPuente()
    {
        OnFantasmaPuente?.Invoke();
        Debug.Log("FantasmaPuente menu activado");
    }

    public void CerroSombreretillo()
    {
        OnCerroSombreretillo?.Invoke();
        Debug.Log("CerroSombreretillo menu activado");
    }

    public void CatrinaItinerante()
    {
        OnCatrinaItinerante?.Invoke();
        Debug.Log("CatrinaItinerante menu activado");
    }

    //Ui de RA
    public void UIRA(string texto, AudioClip audioClip)
    {
        OnUIRA?.Invoke(texto, audioClip);
        Debug.Log("UIRA menu activado");
    }

    public void CloseApp()
    {
        Application.Quit();
    }

}