using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLoop : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicStart;
    


    // Start is called before the first frame update
    void Start()
    {
        musicSource.PlayOneShot(musicStart);
        Wait();
        Wait1();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void loop()
    {
        musicSource.PlayOneShot(musicStart);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(72);
        loop();
        
    }
    IEnumerator Wait1()
    {
        yield return new WaitForSeconds(144);
        loop();

    }
}
