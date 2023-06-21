#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace Scenes
{
    public class Build : MonoBehaviour
    {
        [MenuItem("Build/Build Android")]
        public static void BuildAndroid()
        {
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.IL2CPP);
            var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
            {
                scenes = new[] {"Assets/Scenes/SampleScene.unity"},
                locationPathName = "Builds/Android",
                target = BuildTarget.Android,
                options = BuildOptions.None
            });
            Debug.Log(report.summary);
        }

        [MenuItem("Build/Build LinuxServer")]
        public static void BuildLinuxServer()
        {
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.IL2CPP);
            var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
            {
                scenes = new[] {"Assets/Scenes/SampleScene.unity"},
                locationPathName = "Builds/LinuxServer",
                target = BuildTarget.StandaloneLinux64,
                subtarget = (int)StandaloneBuildSubtarget.Server
            });
            Debug.Log(report.summary);
        }
    }
}

#endif