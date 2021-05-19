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

    // Change les valeurs amplitude et frequency pour le top, mid et bot rig de la camera pour trembler la camera
    void degreeShake(float amplitude, float frequency)
    {
        camCinemachine.GetRig(0).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitude;
        camCinemachine.GetRig(1).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitude;
        camCinemachine.GetRig(2).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amplitude;
        camCinemachine.GetRig(0).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequency;
        camCinemachine.GetRig(1).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequency;
        camCinemachine.GetRig(2).GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequency;
    }
}
