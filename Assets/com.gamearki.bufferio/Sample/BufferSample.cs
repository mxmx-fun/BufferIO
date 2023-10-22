using UnityEngine;
using BufferIO.Helper;
using BufferIO.Content;

namespace BufferIO.Sample
{
    public class BufferSample : MonoBehaviour
    {

        public void Awake()
        {
            byte[] des = new byte[1024];
            int indexWrite = 0;
            int indexRead = 0;

            uint a = uint.MaxValue;
            int b = int.MaxValue;
            bool c = true;
            short d = short.MaxValue;
            byte e = byte.MaxValue;
            sbyte f = sbyte.MaxValue;
            float g = float.MaxValue;
            long h = long.MaxValue;
            double i = double.MaxValue;
            char j = 'a';
            string k = "Hello";
            int[] l = { 1, 2, 3 };
            bool[] m = { true, false };
            short[] n = { 3, 2, 1 };
            byte[] o = { 1, 4, 7 };
            float[] p = { 1.24f, 4.24f };
            long[] q = { long.MaxValue, long.MinValue };
            double[] r = { double.MaxValue, double.MinValue };
            char[] s = { 's', 't' };
            string[] t = { "hello", "world" };

            //Write
            BufferWriter.WriteUInt32(des, a, ref indexWrite);
            BufferWriter.WriteInt32(des, b, ref indexWrite);
            BufferWriter.WriteBool(des, c, ref indexWrite);
            BufferWriter.WriteShort(des, d, ref indexWrite);
            BufferWriter.WriteByte(des, e, ref indexWrite);
            BufferWriter.WriteSbyte(des, f, ref indexWrite);
            BufferWriter.WriteSingle(des, g, ref indexWrite);
            BufferWriter.WriteInt64(des, h, ref indexWrite);
            BufferWriter.WriteDouble(des, i, ref indexWrite);
            BufferWriter.WriteChar(des, j, ref indexWrite);
            BufferWriter.WriteUTF8String(des, k, ref indexWrite);
            BufferWriter.WriteIntArr(des, l, ref indexWrite);
            BufferWriter.WriteBoolArr(des, m, ref indexWrite);
            BufferWriter.WriteShortArr(des, n, ref indexWrite);
            BufferWriter.WriteByteArr(des, o, ref indexWrite);
            BufferWriter.WriteSingleArr(des, p, ref indexWrite);
            BufferWriter.WriteLongArr(des, q, ref indexWrite);
            BufferWriter.WriteDoubleArr(des, r, ref indexWrite);
            BufferWriter.WriteCharArr(des, s, ref indexWrite);
            BufferWriter.WriteUTF8StringArr(des, t, ref indexWrite);

            //Read
            uint res = BufferReader.ReadUInt32(des, ref indexRead);
            int res1 = BufferReader.ReadInt32(des, ref indexRead);
            bool res2 = BufferReader.ReadBool(des, ref indexRead);
            short res3 = BufferReader.ReadInt16(des, ref indexRead);
            byte res4 = BufferReader.ReadUInt8(des, ref indexRead);
            sbyte res5 = BufferReader.ReadSbyte(des, ref indexRead);
            float res6 = BufferReader.ReadSingle(des, ref indexRead);
            long res7 = BufferReader.ReadInt64(des, ref indexRead);
            double res8 = BufferReader.ReadDouble(des, ref indexRead);
            char res9 = BufferReader.ReadChar(des, ref indexRead);
            string res10 = BufferReader.ReadUTF8String(des, ref indexRead);
            int[] res11 = BufferReader.ReadIntArray(des, ref indexRead);
            bool[] res12 = BufferReader.ReadBoolArray(des, ref indexRead);
            short[] res13 = BufferReader.ReadShortArray(des, ref indexRead);
            byte[] res14 = BufferReader.ReadByteArray(des, ref indexRead);
            float[] res15 = BufferReader.ReadSingleArray(des, ref indexRead);
            long[] res16 = BufferReader.ReadLongArray(des, ref indexRead);
            double[] res17 = BufferReader.ReadDoubleArray(des, ref indexRead);
            char[] res18 = BufferReader.ReadCharArray(des, ref indexRead);
            string[] res19 = BufferReader.ReadUTF8StringArray(des, ref indexRead);

            Debug.Log($"uint:{res}");
            Debug.Log($"int:{res1}");
            Debug.Log($"bool:{res2}");
            Debug.Log($"ushort:{res3}");
            Debug.Log($"byte:{res4}");
            Debug.Log($"Sbyte:{res5}");
            Debug.Log($"float:{res6}");
            Debug.Log($"long:{res7}");
            Debug.Log($"double:{res8}");
            Debug.Log($"char:{res9}");
            Debug.Log($"string:{res10}");
            foreach (var intValue in res11)
            {
                Debug.Log($"intArr:{intValue}");
            }
            foreach (var boolValue in res12)
            {
                Debug.Log($"boolArr:{boolValue}");
            }
            foreach (var shortValue in res13)
            {
                Debug.Log($"shortValue:{shortValue}");
            }
            foreach (var byteValue in res14)
            {
                Debug.Log($"byteValue:{byteValue}");
            }
            foreach (var floatValue in res15)
            {
                Debug.Log($"floatValue:{floatValue}");
            }
            foreach (var longValue in res16)
            {
                Debug.Log($"longValue:{longValue}");
            }
            foreach (var doubleValue in res17)
            {
                Debug.Log($"doubleValue:{doubleValue}");
            }
            foreach (var charValue in res18)
            {
                Debug.Log($"charValue:{charValue}");
            }
            foreach (var strngValue in res19)
            {
                Debug.Log($"strngValue:{strngValue}");
            }
        }

    }
}