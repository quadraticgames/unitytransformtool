using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class TransformToolCycler
{
    static Tool[] tools = { Tool.Move, Tool.Rotate, Tool.Scale, Tool.Rect, Tool.Transform };
    static int currentToolIndex = 0;

    static TransformToolCycler()
    {
        SceneView.duringSceneGui += OnSceneGUI;
    }

    private static void OnSceneGUI(SceneView sceneView)
    {
        Event e = Event.current;
        if (e.type == EventType.KeyDown && e.keyCode == KeyCode.Space && !e.alt && !e.control && !e.command)
        {
            currentToolIndex = (currentToolIndex + 1) % tools.Length;
            Tools.current = tools[currentToolIndex];
            e.Use(); // Prevents default behavior
        }
    }
}
