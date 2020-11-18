using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEditor.SceneManagement;
using System.Linq;
using System;

public class ScenesManager : EditorWindow
{
    private List<SceneData> sceneDatas = new List<SceneData>();
    

    [MenuItem("Tools/ScenesManager")]
    public static void ShowWindow()
    {
        GetWindow<ScenesManager>();
    }

    [MenuItem("Assets/Scene/Add to build", false)]
    public static void AddToBuild()
    {
        SceneAsset sceneAsset = (SceneAsset)Selection.activeObject;
        //faire en une ligne si on est des vrais boss
        foreach(EditorBuildSettingsScene e in EditorBuildSettings.scenes)
        {
            if (Path.GetFileNameWithoutExtension(e.path) == sceneAsset.name)
            {
                Debug.Log("Cette scene est déjà dans le build");
                return;
            }
        }

        List<EditorBuildSettingsScene> scenesList = EditorBuildSettings.scenes.ToList();
        scenesList.Add(new EditorBuildSettingsScene(AssetDatabase.GetAssetPath(sceneAsset), true));
        EditorBuildSettings.scenes = scenesList.ToArray();
    }

    [MenuItem("Assets/Scene/Add to build", true)]
    public static bool AdToBuild()
    {
        return Selection.activeObject is SceneAsset;
    }

    private void OnGUI()
    {
        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal();
        GUILayout.Label("Check the scenes in the build");
        if (GUILayout.Button("Check build"))
            EditorWindow.GetWindow(Type.GetType("UnityEditor.BuildPlayerWindow, UnityEditor"));
        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();
        GUILayout.Label("Select scenes to load/unload :");
        if (GUILayout.Button("Refresh scenes list"))
            RefreshContent();
        GUILayout.EndHorizontal();

        Vector2 scrollPosition = new Vector2(200.0f,300.0f);
        scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(200), GUILayout.Height(300));

        foreach(SceneData sceneData in sceneDatas)
        {
            sceneData.m_activeForNextFrame = GUILayout.Toggle(sceneData.m_activeForNextFrame, sceneData.m_sceneName);
            if(sceneData.m_activeForNextFrame != sceneData.m_isActive && sceneData.m_activeForNextFrame == true)
            {
                EditorSceneManager.OpenScene(sceneData.m_path, OpenSceneMode.Additive);
                sceneData.m_isActive = true;
            }
            else if(sceneData.m_activeForNextFrame != sceneData.m_isActive && sceneData.m_activeForNextFrame == false)
            {
                if(EditorSceneManager.sceneCount > 1)
                {
                    EditorSceneManager.CloseScene(EditorSceneManager.GetSceneByName(sceneData.m_sceneName), true);
                    sceneData.m_isActive = false;
                }
                else
                {
                    Debug.Log("UNITY DOIT TOUJOURS AVOIR UNE SCENE CHARGÉE ABRUTIMAN");
                    sceneData.m_activeForNextFrame = true;
                }
            }
        }

        GUILayout.EndScrollView();
        GUILayout.EndVertical();
    }

    private void RefreshContent()
    {
        sceneDatas.Clear();
        foreach(EditorBuildSettingsScene e in EditorBuildSettings.scenes)
        {
            sceneDatas.Add(new SceneData(Path.GetFileNameWithoutExtension(e.path), e.path, false, false));
        }

        for(int i = 0; i < SceneManager.sceneCount; i++)
        {
            sceneDatas.ElementAt(SceneManager.GetSceneAt(i).buildIndex).m_isActive = true;
            sceneDatas.ElementAt(SceneManager.GetSceneAt(i).buildIndex).m_activeForNextFrame = true;
        }
    }
}
