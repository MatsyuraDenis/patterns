using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public static class Prototype
    {
        public static T DeepCopy<T>(this T original)
        {
            if (!typeof(T).IsSerializable)
                throw new ArgumentException("type must be serializable!");


            BinaryFormatter formatter = new BinaryFormatter();

            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, original);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }

        }
    }
}
