using System;
using RiepkinSharp02.Tools;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace RiepkinSharp02.Managers
{
    internal static class SerializationManager
    {
        internal static void Serialize<TObject>(TObject obj, string filePath)
        {
            try
            {
                FileFolderHelper.CheckAndCreateFile(filePath);
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, obj);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        internal static TObject Deserialize<TObject>(string filePath) where TObject : class
        {
            try
            {
                var formatter = new BinaryFormatter();
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    return (TObject)formatter.Deserialize(stream);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
