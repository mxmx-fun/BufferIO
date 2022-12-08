using System.Linq;
using UnityEngine;
using UnityEditor.TestTools;
using NUnit.Framework;
using System;

namespace JackFrame.BufferIO.Tests {

    public class BufferIOTests {

        [Test]
        public void BufferIOTestsSimplePasses() {

            TestClass obj1 = TestClass.GenRandom();
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

            TestStruct vo1 = TestStruct.GenRandom();
            byte[] data2 = ReflectionSerializeUtil.Serialize(vo1);
            TestStruct vo2 = ReflectionSerializeUtil.Deserialize<TestStruct>(data2);

            Assert.That(vo1.boolValue == vo2.boolValue);
            Assert.That(vo1.boolArray.SequenceEqual(vo2.boolArray));

            Assert.That(vo1.byteValue == vo2.byteValue);
            Assert.That(vo1.byteArray.SequenceEqual(vo2.byteArray));

            Assert.That(vo1.charValue == vo2.charValue, $"{vo1.charValue} {vo2.charValue}");
            
            Assert.That(vo1.doubleValue == vo2.doubleValue);
            Assert.That(vo1.doubleArray.SequenceEqual(vo2.doubleArray));

            Assert.That(vo1.floatValue == vo2.floatValue);
            Assert.That(vo1.floatArray.SequenceEqual(vo2.floatArray));

            Assert.That(vo1.intValue == vo2.intValue);
            Assert.That(vo1.intArray.SequenceEqual(vo2.intArray));

            Assert.That(vo1.longValue == vo2.longValue);
            Assert.That(vo1.longArray.SequenceEqual(vo2.longArray));

            Assert.That(vo1.sbyteValue == vo2.sbyteValue);
            Assert.That(vo1.sbyteArray.SequenceEqual(vo2.sbyteArray));

            Assert.That(vo1.shortValue == vo2.shortValue);
            Assert.That(vo1.shortArray.SequenceEqual(vo2.shortArray));

            Assert.That(vo1.stringValue == vo2.stringValue);
            Assert.That(vo1.stringArray.SequenceEqual(vo2.stringArray));

            Assert.That(vo1.uintValue == vo2.uintValue);
            Assert.That(vo1.uintArray.SequenceEqual(vo2.uintArray));

            Assert.That(vo1.ulongValue == vo2.ulongValue);
            Assert.That(vo1.ulongArray.SequenceEqual(vo2.ulongArray));

            Assert.That(vo1.ushortValue == vo2.ushortValue);
            Assert.That(vo1.ushortArray.SequenceEqual(vo2.ushortArray));

        }

    }
}