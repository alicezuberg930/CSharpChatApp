using ChatApplication.Model;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ChatApplication.Controller
{
    public static class MessageSerialization
    {
        private static byte[] SerializeText(string data)
        {
            return Encoding.UTF8.GetBytes(data.ToString());
        }

        private static string DeserializeText(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }

        private static byte[] SerializeImage(Image data)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(data, typeof(byte[]));
        }

        private static Bitmap DeserializeImage(byte[] data)
        {
            Bitmap bmp;
            using (var ms = new MemoryStream(data))
            {
                bmp = new Bitmap(ms);
            }
            return bmp;
        }

        private static byte[] SerializeFile(FileModel data)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, data);
                return ms.ToArray();
            }
        }

        private static FileModel DeserializeFile(byte[] data)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(data, 0, data.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return (FileModel)obj;
            }
        }
    }
}
