using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
   	static public void SaveGame(MoneyState money)
   	{
   		BinaryFormatter formatter = new BinaryFormatter();
   		
         string path = Application.persistentDataPath + "/player.fun";
   		
         FileStream stream = new FileStream(path, FileMode.Create);

   		JerryData data = new JerryData(money);

   		formatter.Serialize(stream ,data);

   		stream.Close();
   	}

   	public static JerryData LoadGame ()
   	{
   		string path = Application.persistentDataPath + "/player.fun";

   		if(File.Exists(path))
   		{
   			BinaryFormatter formatter = new BinaryFormatter();

   			FileStream stream = new FileStream(path, FileMode.Open);

   			JerryData data = formatter.Deserialize(stream) as JerryData;

   			stream.Close();

   			return data;
   		}

   		else
   		{
   			Debug.LogError("Save file not found in" + path);
   			return null;
   		}
   	}
}
