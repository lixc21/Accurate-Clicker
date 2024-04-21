## 实现精确时间的鼠标点击  

一般电脑主板上的时钟一天能差一两秒，不够准，需要通过网络时间协议（NTP）进行校准。  
我首先写了个程序，用于检查当前系统时间和标准时间（从NTP得来）的差别，也就是Time_Analyzer.exe  
![e934a7d69458f1c27f0d61035cde4f5](https://github.com/lixc21/Accurate-Clicker/assets/95122124/9a998e3a-c54f-4fd5-873b-bf4bb3844704)  
第一行是NTP服务器地址，百度搜索可以搜到很多  

---
得到了这个之后，我又写了个程序 Accurate_Clicker.exe，能够实现精确的点击。  
上面时分秒就是期望点击的时间，最后一行可以输入上个程序分析出来的时间差，用来校准。   
然后点击run，这个程序就会在设定的时间点击。  
![37fbbeb1aa7a1b36faa8654e462de25](https://github.com/lixc21/Accurate-Clicker/assets/95122124/d6a73788-db77-40e8-9d1e-4308b8ef72f5)


