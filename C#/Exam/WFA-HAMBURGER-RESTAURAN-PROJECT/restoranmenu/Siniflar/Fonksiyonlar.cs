using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace restoranmenu.Siniflar
{
    /*
     * Açıkçası bu sınıfı istediğiniz için açıyorum.
     * Çok fazla işe yarayacağını düşünmüyorum.
     * Elimden geleni yapmaya çalışacağım
     */
    public static class Fonksiyonlar
    {
        /*
         * İşe yaradı.
         * Metotlar internetten kopya.
         * Generic type benden.
         */

        //public static void SerializeObject<T>(this List<T> list, string fileName)
        //{
        //    var serializer = new XmlSerializer(typeof(List<T>));
        //    using (var stream = File.OpenWrite(fileName))
        //    {
        //        serializer.Serialize(stream, list);
        //    }
        //}

        //public static void Deserialize<T>(this List<T> list, string fileName)
        //{
        //    var serializer = new XmlSerializer(typeof(List<T>));
        //    using (var stream = File.OpenRead(fileName))
        //    {
        //        var other = (List<T>)(serializer.Deserialize(stream));
        //        list.Clear();
        //        list.AddRange(other);
        //    }
        //}

        //public static void Serialize<T>(this List<T> list, string path)
        //{
        //    BinaryFormatter formatter = new BinaryFormatter();

        //    using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
        //    {
        //        formatter.Serialize(fStream, list);
        //    }
        //}

        //public static List<T> Deserialize<T>(string path)
        //{
        //    if (!System.IO.File.Exists(path))
        //    {

        //    }

        //    BinaryFormatter formatter = new BinaryFormatter();

        //    using (Stream fStream = File.OpenRead(path))
        //    {
        //        return (List<T>)formatter.Deserialize(fStream);
        //    }

        //}

        /*
         * Çok uğraştım hocam ama ben bu dersi tekrar etmeden bunu yapamayacağım.
         * Hiçbir şekilde veriyi kaydedip geri okumayı başaramadım.
         * Kırık parmak
         * Sınav olduğunu akşam 11 de etütte anlamak
         * 2 saat giden elektrikten sonra 
         * Artık pes.
         */
    }
}
