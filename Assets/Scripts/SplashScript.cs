using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{
    public Light dimLight;

    void Start ()
    {
		if(SceneManager.GetActiveScene().name == "Start")
        {
            StartCoroutine(Splash());
        }
	}

    IEnumerator Splash()
    {
        while(dimLight.intensity < 1)
        {
            dimLight.intensity += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(2);

        while(dimLight.intensity > 0)
        {
            dimLight.intensity -= Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        SceneManager.LoadScene(1);
    }
}
