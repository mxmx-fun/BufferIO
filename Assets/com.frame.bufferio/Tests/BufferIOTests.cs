using System.Linq;
using UnityEngine;
using UnityEditor.TestTools;
using NUnit.Framework;
using System;

namespace JackFrame.BufferIO.Tests {

    public class BufferIOTests {

        class TestClass {
            // All Base Types && String && Array
            public bool boolValue;
            public bool[] boolArray;
            public byte byteValue;
            public byte[] byteArray;
            public char charValue;
            public double doubleValue;
            public double[] doubleArray;
            public float floatValue;
            public float[] floatArray;
            public int intValue;
            public int[] intArray;
            public long longValue;
            public long[] longArray;
            public sbyte sbyteValue;
            public sbyte[] sbyteArray;
            public short shortValue;
            public short[] shortArray;
            public string stringValue;
            public string[] stringArray;
            public uint uintValue;
            public uint[] uintArray;
            public ulong ulongValue;
            public ulong[] ulongArray;
            public ushort ushortValue;
            public ushort[] ushortArray;
        }

        [Test]
        public void BufferIOTestsSimplePasses() {

            TestClass obj1 = Gen();
            byte[] data = ReflectionSerializeUtil.Serialize(obj1);
            TestClass obj2 = ReflectionSerializeUtil.Deserialize<TestClass>(data);

            Assert.That(obj1.boolValue == obj2.boolValue);
            Assert.That(obj1.boolArray.SequenceEqual(obj2.boolArray));

            Assert.That(obj1.byteValue == obj2.byteValue);
            Assert.That(obj1.byteArray.SequenceEqual(obj2.byteArray));

            Assert.That(obj1.charValue == obj2.charValue, $"{obj1.charValue} {obj2.charValue}");

            Assert.That(obj1.doubleValue == obj2.doubleValue);
            Assert.That(obj1.doubleArray.SequenceEqual(obj2.doubleArray));

            Assert.That(obj1.floatValue == obj2.floatValue);
            Assert.That(obj1.floatArray.SequenceEqual(obj2.floatArray));

            Assert.That(obj1.intValue == obj2.intValue);
            Assert.That(obj1.intArray.SequenceEqual(obj2.intArray));

            Assert.That(obj1.longValue == obj2.longValue);
            Assert.That(obj1.longArray.SequenceEqual(obj2.longArray));

            Assert.That(obj1.sbyteValue == obj2.sbyteValue);
            Assert.That(obj1.sbyteArray.SequenceEqual(obj2.sbyteArray));

            Assert.That(obj1.shortValue == obj2.shortValue);
            Assert.That(obj1.shortArray.SequenceEqual(obj2.shortArray));

            Assert.That(obj1.stringValue == obj2.stringValue);
            Assert.That(obj1.stringArray.SequenceEqual(obj2.stringArray));

            Assert.That(obj1.uintValue == obj2.uintValue);
            Assert.That(obj1.uintArray.SequenceEqual(obj2.uintArray));

            Assert.That(obj1.ulongValue == obj2.ulongValue);
            Assert.That(obj1.ulongArray.SequenceEqual(obj2.ulongArray));

            Assert.That(obj1.ushortValue == obj2.ushortValue);
            Assert.That(obj1.ushortArray.SequenceEqual(obj2.ushortArray));

        }

        TestClass Gen() {

            TestClass obj = new TestClass();

            obj.boolValue = UnityEngine.Random.Range(0, 2) == 1;
            obj.boolArray = Enumerable.Range(0, 10).Select(x => UnityEngine.Random.Range(0, 2) == 1).ToArray();

            obj.byteValue = (byte)UnityEngine.Random.Range(byte.MinValue, byte.MaxValue);
            obj.byteArray = Enumerable.Range(0, 10).Select(x => (byte)UnityEngine.Random.Range(byte.MinValue, byte.MaxValue)).ToArray();

            obj.charValue = (char)UnityEngine.Random.Range(char.MinValue, char.MaxValue);

            obj.doubleValue = (double)UnityEngine.Random.Range(float.MinValue, float.MaxValue);
            obj.doubleArray = Enumerable.Range(0, 10).Select(x => (double)UnityEngine.Random.Range(float.MinValue, float.MaxValue)).ToArray();

            obj.floatValue = (float)UnityEngine.Random.Range(float.MinValue, float.MaxValue);
            obj.floatArray = Enumerable.Range(0, 10).Select(x => (float)UnityEngine.Random.Range(float.MinValue, float.MaxValue)).ToArray();

            obj.intValue = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
            obj.intArray = Enumerable.Range(0, 10).Select(x => UnityEngine.Random.Range(int.MinValue, int.MaxValue)).ToArray();

            obj.longValue = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
            obj.longArray = Enumerable.Range(0, 10).Select(x => (long)UnityEngine.Random.Range(int.MinValue, int.MaxValue)).ToArray();

            obj.sbyteValue = (sbyte)UnityEngine.Random.Range(sbyte.MinValue, sbyte.MaxValue);
            obj.sbyteArray = Enumerable.Range(0, 10).Select(x => (sbyte)UnityEngine.Random.Range(sbyte.MinValue, sbyte.MaxValue)).ToArray();

            obj.shortValue = (short)UnityEngine.Random.Range(short.MinValue, short.MaxValue);
            obj.shortArray = Enumerable.Range(0, 10).Select(x => (short)UnityEngine.Random.Range(short.MinValue, short.MaxValue)).ToArray();

            obj.stringValue = Guid.NewGuid().ToString();
            obj.stringArray = Enumerable.Range(0, 10).Select(x => Guid.NewGuid().ToString()).ToArray();

            obj.uintValue = (uint)UnityEngine.Random.Range(uint.MinValue, uint.MaxValue);
            obj.uintArray = Enumerable.Range(0, 10).Select(x => (uint)UnityEngine.Random.Range(uint.MinValue, uint.MaxValue)).ToArray();

            obj.ulongValue = (ulong)UnityEngine.Random.Range(ulong.MinValue, ulong.MaxValue);
            obj.ulongArray = Enumerable.Range(0, 10).Select(x => (ulong)UnityEngine.Random.Range(ulong.MinValue, ulong.MaxValue)).ToArray();

            obj.ushortValue = (ushort)UnityEngine.Random.Range(ushort.MinValue, ushort.MaxValue);
            obj.ushortArray = Enumerable.Range(0, 10).Select(x => (ushort)UnityEngine.Random.Range(ushort.MinValue, ushort.MaxValue)).ToArray();

            return obj;

        }

    }
}