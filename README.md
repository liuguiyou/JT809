# JT809协议开发

## 瞎逼逼：

&emsp;&emsp;现在有了[JT808](https://github.com/SmallChi/GPSPlatform/blob/master/JT808.md)的基础，对JT809就只剩搬砖了。

> 该JT809协议是参考[MessagePack-CSharp](https://github.com/neuecc/MessagePack-CSharp)一款二进制序列化器，站在巨人的肩膀上搬砖就是爽歪歪。

> 这GB的文档不得不说，太坑了。。。

## JT809协议消息对照表

### 链路管理类

|序号|消息ID|完成情况|消息体名称|
|:------:|:------:|:------:|:------:|
|  1   | 0x1001  |  √  | 主链路登录请求消息 |  
|  2   | 0x1002  |  √  | 主链路登录应答消息 |  
|  3   | 0x1003  |  √  | 主链路注销请求消息 |  
|  4   | 0x1004  |  √  | 主链路注销应答消息 |  
|  5   | 0x1005  |  √  | 主链路连接保持请求消息 |
|  6   | 0x1006  |  √  | 主链路连接保持应答消息 |
|  7   | 0x1007  |  √  | 主链路断开通知消息  |
|  8   | 0x1008  |  √  | 下级平台主动关闭链路通知消息  |
|  9   | 0x9001  |  √  | 从链路连接请求消息  |
|  10  | 0x9002  |  √  | 从链路连接应答消息  |
|  11  | 0x9003  |  √  | 从链路注销请求消息  |
|  12  | 0x9004  |  √  | 从链路注销应答消息  |
|  13  | 0x9005  |  √  | 从链路连接保持请求消息  |
|  14  | 0x9006  |  √  | 从链路连接保持应答消息  |
|  15  | 0x9007  |  √  | 从链路断开通知消息 |
|  16  | 0x9008  |  √  | 上级平台主动关闭链路通知消息 |

### 信息统计类

|序号|消息ID|完成情况|消息体名称|
|:------:|:------:|:------:|:------:|
|  1  | 0x9101  |  √  |接收定位信息数量通知消息  |

### 车辆动态信息交换

#### 主链路动态信息交换消息

|序号|消息ID|完成情况|消息体名称|
|:------:|:------:|:------:|:------:|
|  1  | 0x1200  |  √   |  主链路动态信息交换消息  |
|  2  | 0x1201  |  √   |  上传车辆注册信息  |
|  3  | 0x1202  |  √   |  实时上传车辆定位信息  |
|  4  | 0x1203  |  √   |  车辆定位信息自动补报  |
|  5  | 0x1205  |  √   |  启动车辆定位信息交换应答消息  |
|  6  | 0x1206  |  √   |  结束车辆定位信息交换应答消息  |
|  7  | 0x1207  |  √   |  申请交换指定车辆定位信息请求消息  |
|  8  | 0x1208  |  √   |  取消交换指定车辆定位信息请求  |
|  9  | 0x1209  |  √   |  补发车辆定位信息请求  |
|  10 | 0x120A  |  √   |  上报车辆驾驶员身份识别信息应答  |
|  11 | 0x120B  |  √   |  上报车辆电子运单应答  |
|  12 | 0x120C  |  √   |  主动上报驾驶员身份信息  |
|  13 | 0x120D  |  √   |  主动上报车辆电子运单信息  |