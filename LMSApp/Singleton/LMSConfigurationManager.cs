using System.ComponentModel;

namespace LMSApp.Singleton;

public class LMSConfigurationManager
{
    private static LMSConfigurationManager instance;

    public string InstituteName { get; set; }
    public string Version { get; set; }

    public string AdminContact { get; set; }

    private LMSConfigurationManager()
    {
        InstituteName = "LMS Institute";
        Version = "1.0.0";
        AdminContact = "9876543210";
    }

    public static LMSConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            instance = new LMSConfigurationManager();
        }
        return instance;
    }
}


