using System.Net;
using UnityEngine;
using System.IO;
public static  class ApiHelper 
{

    public static Joke getnewjoke()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.chucknorris.io/jokes/random");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json =  reader.ReadToEnd();
        return JsonUtility.FromJson<Joke>(json);

    }
}
