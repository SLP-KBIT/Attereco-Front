using System.IO;
using System.Xml.Serialization;

namespace Attereco_Register.Model.Common
{
    /// <summary>
    /// XMLの操作
    /// </summary>
    public static class XMLFileManager
    {
        //--- 定数

        private static readonly string Path = System.AppDomain.CurrentDomain.BaseDirectory;

        //--- フィールド

        //--- private メソッド

        //--- static メソッド

        /// <summary>
        /// XMLの読み込み
        /// </summary>
        /// <typeparam name="T">ジェネリック</typeparam>
        /// <param name="fileName">対象ファイル名</param>
        /// <returns>生成されたオブジェクト</returns>
        public static T ReadXml<T>(string fileName) where T : new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader stream;
            T obj;
            try
            {
                stream = new StreamReader(Path + fileName);
                obj = (T)serializer.Deserialize(stream);
                stream.Close();
            }
            catch (System.Exception)
            {
                obj = new T();
            }
            return obj;
        }

        /// <summary>
        /// XMLの書き込み
        /// </summary>
        /// <typeparam name="T">ジェネリック</typeparam>
        /// <param name="fileName">対象ファイル名</param>
        /// <param name="obj">対象オブジェクト</param>
        public static void WriteXml<T>(string fileName, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamWriter stream = new StreamWriter(Path + fileName);
            System.Console.WriteLine(Path + fileName);
            serializer.Serialize(stream, obj);
            stream.Close();
        }
    }
}
