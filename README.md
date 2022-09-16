# BufferIO
二进制数据序列化函数库

# 如何使用
```
int src = 3;
byte[] dst = new byte[1024];
int offset = 0;
BufferWriter.WriteInt32(dst, src, offset);
```
