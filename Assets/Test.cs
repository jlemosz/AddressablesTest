using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;
using UnityEngine.Assertions;

public class Test : MonoBehaviour
{
    //AddressableAssetSettings settings;


    // Start is called before the first frame update
    void Start()
    {
        //settings = AddressableAssetSettings.Create("Assets", "TestSettings", false, true);
        //settings.DisableCatalogUpdateOnStartup = true;
        //AddressableAssetSettingsDefaultObject.Settings = settings;
        CreateAddressableAssetSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Create a new AddressableAssetSettings object.
    /// </summary>
    void CreateAddressableAssetSettings()
    {
        AddressableAssetSettingsDefaultObject.Settings = AddressableAssetSettings.Create(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder, AddressableAssetSettingsDefaultObject.kDefaultConfigAssetName, true, true);
        string path = Path.Combine(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder, AddressableAssetSettingsDefaultObject.kDefaultConfigAssetName + ".asset");
        Assert.IsTrue(File.Exists(path), "File not found");
    }
}
