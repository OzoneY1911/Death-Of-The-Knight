using UnityEngine;

public class MainMenu : SingletonMono<MainMenu>
{
    protected override void Awake()
    {
        base.Awake();
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}