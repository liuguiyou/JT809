﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JT809.Protocol;
using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809MessageBody;
using JT809.Protocol.JT809Exceptions;

namespace JT809.Protocol.Test.JT809MessageBody
{
    public class JT809_0x1001Test
    {
        [Fact]
        public void Test1()
        {
            JT809_0x1001 jT809_0X1001 = new JT809_0x1001();
            jT809_0X1001.UserId = 20180920;
            jT809_0X1001.Password = "20180920";
            jT809_0X1001.DownLinkIP = "127.0.0.1";
            jT809_0X1001.DownLinkPort = 809;
            var hex = JT809Serializer.Serialize(jT809_0X1001).ToHexString();
            //"01 33 EF B8 32 30 31 38 30 39 32 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 31 32 37 2E 30 2E 30 2E 31 03 29"
        }

        [Fact]
        public void Test2()
        {
            var bytes = "01 33 EF B8 32 30 31 38 30 39 32 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 30 31 32 37 2E 30 2E 30 2E 31 03 29".ToHexBytes();
            JT809_0x1001 jT809_0X1001 = JT809Serializer.Deserialize<JT809_0x1001>(bytes);
            Assert.Equal((uint)20180920, jT809_0X1001.UserId);
            Assert.Equal("20180920", jT809_0X1001.Password);
            Assert.Equal("127.0.0.1", jT809_0X1001.DownLinkIP);
            Assert.Equal((ushort)809,jT809_0X1001.DownLinkPort);
        }
    }
}
