using UnityEngine;
using System.Collections;
using UnityEditor;
 
public static class Exporter {
 
    [MenuItem("Export/Export with project settings")]
    public static void ExportPackage()
    {
        string[] projectContent = new string[] {
            "Assets/Examples",
            "Assets/Your Scenes",
            "Assets/Your Scripts",
            "ProjectSettings/EditorBuildSettings.asset",
            "ProjectSettings.asset",
        };
        AssetDatabase.ExportPackage( 
            projectContent,
            "Graphing Exercise.unitypackage",
            ExportPackageOptions.Interactive | ExportPackageOptions.Recurse | ExportPackageOptions.IncludeDependencies
        );

        Debug.Log("Project Exported");
    }
 
}