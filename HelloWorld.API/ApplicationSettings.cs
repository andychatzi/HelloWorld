using System.Configuration;

namespace HelloWorld.Api
{
    public class ApplicationSettings : ConfigurationSection
    {   
        [ConfigurationProperty("WriterType", DefaultValue = "", IsRequired = false)]
        public static string WriterType
        {
            get { return (ConfigurationManager.AppSettings["WriterType"].ToString()); }
            set { ConfigurationManager.AppSettings["WriterType"] = value; }
        }
    }
}
