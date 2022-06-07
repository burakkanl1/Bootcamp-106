using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    public string Url;
    // Start is called before the first frame update
    public void OpenURL()
    {
        Application.OpenURL(Url);
    }

    
}
