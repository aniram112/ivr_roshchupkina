using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AchievementDatabase))]
public class AchievementDatabaseEditor : Editor
{
    private AchievementDatabase database;
    private void OnEnable()
    {
        database = target as AchievementDatabase;

    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Generate enum",GUILayout.Height(30))){

            GenerateEnum();
        }
    }
    public void GenerateEnum(){
        string filePath = Path.Combine(Application.dataPath, "Achievements.cs");
        string code = "public enum Achievements {";
        foreach(Achievement achievement in database.achievements)
        {
            //TODO: validate the id is proper format
            code += achievement.id + ',';
        }
        code += '}';
        File.WriteAllText(filePath, code);
        AssetDatabase.ImportAsset("Assets/Achievements.cs");
    }
}
