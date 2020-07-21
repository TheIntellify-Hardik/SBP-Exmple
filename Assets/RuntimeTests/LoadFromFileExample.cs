using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadFromFileExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var myLoadedAssetBundle
                = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "prefabs"));
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }
       // var prefab = myLoadedAssetBundle.LoadAsset<GameObject>("Cube");
        var prefab  = Instantiate(myLoadedAssetBundle.mainAsset) as GameObject;
        Instantiate(prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
