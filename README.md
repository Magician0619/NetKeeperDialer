# NetKeeperDialer

![NetKeeper](https://github.com/lmgy/NetKeeper/blob/master/icon.ico)  
截取NetKeeper拨号时的真实账号，并自动post到路由器，实现路由器上网。  

CQUPT,TP-Link TL-WR842N测试可以使用。

## 使用方法

1. 使用创翼的4.7.9.589版本（其他版本未测试）
2. 打开创翼，但不登录
3. 打开NetKeeper.exe，在设置里面填好相关内容，然后点击“开始截取”，此时程序可能会假死，正常情况
4. 登录创翼，如果正常，会截取到真实的账号并自动提交到路由器，并且自动验证是否能联网

## Ps

如果不能用，可能是创翼客户端的问题或者是路由器的问题，目前只试过TP-Link TL-WR842N，其他型号路由器可以自己去抓包，然后自己写。