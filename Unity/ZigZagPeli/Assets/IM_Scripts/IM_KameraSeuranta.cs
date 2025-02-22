using UnityEngine;

public class IM_KameraSeuranta : MonoBehaviour
{
    // Luodaan olio.
    public GameObject IM_pallo;

    // Pitää kameran vakiovälimatkan päässä pallosta.
    Vector3 IM_offset;
    
    // Pallon sijainti suhteessa alustaan.
    public float IM_tarinaVaihe;

    // Pelin loppu.
    public bool IM_peliLoppu;

    // Alustetaan vakiovälimatka, kun peli käynnistetään.
    void Start()
    {
        IM_offset = IM_pallo.transform.position - transform.position;
        IM_peliLoppu = false;
    }

    // Päivitetään ruutu jokaisella kuvataajuudella.
    void Update()
    {
        // Jos peli ei ole loppu, seurataan palloa.
        if (!IM_peliLoppu)
            IMSeuraaPalloa();
    }

    // Kuvaruutua siirretään lerpin avulla tietyllä nopeudella pallon mukana. 
    void IMSeuraaPalloa()
    {
        Vector3 IM_paikka = transform.position; 
        Vector3 IM_tavoitePaikka = IM_pallo.transform.position - IM_offset;
        IM_paikka = Vector3.Lerp(IM_paikka, IM_tavoitePaikka, IM_tarinaVaihe * Time.deltaTime);
        transform.position = IM_paikka;
    }
}
