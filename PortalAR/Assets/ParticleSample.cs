using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSample : MonoBehaviour
{

    private ParticleSystem ps; //reference to particle system gameObjects

    // Use this for initialization
    void Start()
    {
        ps = GetComponent<ParticleSystem>(); //reference to ps component
        StartCoroutine(SampleParticleRoutine()); //starts this function

    }
    IEnumerator SampleParticleRoutine() //simulation speed set to very fast then to what we want which is much slower
    {									//code plays ps with initial fast speed, waita for 10th of a second and then slows down
        var main = ps.main; //reference to main component to ps
        main.simulationSpeed = 1000f; //speed set to 1000
        ps.Play();
        yield return new WaitForSeconds(.1f);
        main.simulationSpeed = .05f; //set back to .05 which is what we want when it slows down
    }
}