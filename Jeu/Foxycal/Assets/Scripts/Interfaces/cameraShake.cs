using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraShake : MonoBehaviour
{
    /// Auteur : Tristan Lapointe
    /// Description : Gère le shake de caméra quand c'est la nuit
    /// 

    public float shakeAmplitude;
    public float shakeFrequency;
    public float shakeTemps;

    public CinemachineFreeLook camCinemachine;

    public IEnumerator Shake()
    {
        degreeShake(shakeAmplitude, shakeFrequency);
        yield return new WaitForSeconds(shakeTemps);
        degreeShake(0, 0);
    }

    void degreeShake(float amplitude, float frequency)
    {
        camCinemachine.GetRig(0).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitude;
        camCinemachine.GetRig(1).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitude;
        camCinemachine.GetRig(2).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitude;
        camCinemachine.GetRig(0).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequency;
        camCinemachine.GetRig(1).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequency;
        camCinemachine.GetRig(2).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequency;
    }

   

   /* public IEnumerator Shake (float duree, float magnitude)
    {
        //Position orginale de la caméra
        Vector3 positionOriginale = transform.localPosition;

        //Temps écoulé
        float tempsPasse = 0.0f;

        //Pendant que le temps passe (avant la durée maximum), calculer des valeurs randoms pour le shake
        while (tempsPasse < duree)
        {
            // Valeurs aléatoires
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            // Shake
            transform.localPosition = new Vector3(x, y, positionOriginale.z);

            // Augmenter le temps écoulé avec les frames delta time
            tempsPasse += Time.deltaTime;

            // Attendre que la prochaine instance de while se passe
            yield return null;
        }

        // Remettre la position originale après le shake
        transform.localPosition = positionOriginale;

    }*/
}
