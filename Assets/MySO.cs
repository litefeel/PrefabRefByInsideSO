using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MySO : ScriptableObject
{

    public GameObject prefab;


#if UNITY_EDITOR
    [MenuItem("Tools/AddSOToPrefab")]
    public static void AddSOToPrefab()
    {
        var prefab = Selection.activeObject as GameObject;
        if (prefab)
        {
            var so = CreateInstance<MySO>();
            so.name = "MySo";
            so.prefab = prefab;
            Debug.Log(prefab, prefab);
            var path = AssetDatabase.GetAssetPath(prefab);
            AssetDatabase.AddObjectToAsset(so, path);
            AssetDatabase.SaveAssets();
        }
    }

#endif
}
