using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateCustomScript
{
    [MenuItem("Assets/Create/Custom C# Script", false, 80)]
    public static void CreateNewScript()
    {
        string path = GetSelectedPathOrFallback();
        string defaultName = "NewScript.cs";

        string filePath = EditorUtility.SaveFilePanelInProject(
            "Save Script",
            defaultName,
            "cs",
            "Please enter a file name to save the script to.",
            path
        );
    
        Debug.Log(filePath);

        if (string.IsNullOrEmpty(filePath))
        {
            // if cancelled, do nothing
            return;
        }

        string fileName = Path.GetFileName(filePath);

        string templatePath = "Assets/Editor/CustomScriptTemplates/CustomScriptTemplate.txt";

        string namespaceName = GetNamespaceFromPath(path);

        string templateContent = File.ReadAllText(templatePath);
        templateContent = templateContent.Replace("#NAMESPACE#", namespaceName);
        templateContent = templateContent.Replace("#SCRIPTNAME#", fileName.Replace(".cs", ""));

        // string filePath = Path.Combine(path, fileName);
        File.WriteAllText(filePath, templateContent);

        AssetDatabase.Refresh();
    }

    private static string GetSelectedPathOrFallback()
    {
        string path = "Assets";
        foreach (Object obj in Selection.GetFiltered(typeof(Object), SelectionMode.Assets))
        {
            path = AssetDatabase.GetAssetPath(obj);
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                path = Path.GetDirectoryName(path);
                break;
            }
        }
        return path;
    }

    private static string GetNamespaceFromPath(string path)
    {
        string scriptsFolder = "Assets/Scripts/";
        if (!path.Contains(scriptsFolder))
        {
            return "";
        }
        int startIndex = path.IndexOf(scriptsFolder) + scriptsFolder.Length;
        string namespaceName = path.Substring(startIndex).Replace("/", ".");
        return namespaceName;
    }
}