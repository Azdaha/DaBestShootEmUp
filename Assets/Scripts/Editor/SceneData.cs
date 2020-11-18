public class SceneData
{
    public string m_sceneName;
    public string m_path;
    public bool m_isActive;
    public bool m_activeForNextFrame;

    public SceneData(string pSceneName, string pPath, bool pIsActive, bool pActiveForNextFrame)
    {
        m_sceneName = pSceneName;
        m_path = pPath;
        m_isActive = pIsActive;
        m_activeForNextFrame = pActiveForNextFrame;
    }
}
