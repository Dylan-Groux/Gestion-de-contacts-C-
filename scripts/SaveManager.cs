using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;


namespace MyContact
{
    public static class SaveManager
    {
        //Variables
        private const string filePath = "Data.bin";

        //Methodes pour sauvegarder les données
        public static void SaveData(List<Groupes> data)
        {
            FileStream fs = File.Create(filePath);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, data);

            fs.Close();
        }

        //Ouvre les données
        public static List<Groupes> Open()
        {
            List<Groupes> data = new List<Groupes>
            {
                new Groupes("Famille", "Famille"),
                new Groupes("Amis", "Amis"),
                new Groupes("Travail", "Travail"),
                new Groupes("Sport", "Sport")
            };

            //Ouvrir les données
            if (File.Exists(filePath))
            {
                FileStream fs = null;

                try
                {
                    fs = File.OpenRead(filePath);
                    BinaryFormatter bf = new BinaryFormatter();
                    data = (List<Groupes>)bf.Deserialize(fs);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }

            return data;

        }

    }
}
