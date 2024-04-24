## 实现精确时间的鼠标点击 (Precise Time Mouse Clicks)

下载地址 https://github.com/lixc21/Accurate-Clicker/releases/tag/v1.0

---
- 一般电脑主板上的时钟一天能差一两秒，不够准，需要通过网络时间协议（NTP）进行校准。我首先写了个程序，用于检查当前系统时间和标准时间（从NTP得来）的差别，也就是Time_Analyzer.exe。第一行是NTP服务器地址，百度搜索可以搜到很多  
- The clock on a typical computer motherboard can be off by one or two seconds per day, which is not precise enough. This can be corrected using the Network Time Protocol (NTP). The first line is the NTP server address, which can be found with a simple search on Google.

<p align="center">
<img src="https://github.com/lixc21/Accurate-Clicker/assets/95122124/418aa8a2-5ec2-489f-ac97-e805ceaae251" alt="alt text" width="45%" />
</p>

---
- 得到了这个之后，我又写了个程序 Accurate_Clicker.exe，能够实现精确的点击。上面时分秒就是期望点击的时间，最后一行可以输入上个程序分析出来的时间差，用来校准。然后点击run，这个程序就会在设定的时间点击。  
- After obtaining this, I wrote another program, Accurate_Clicker.exe, which can perform precise clicks. The hours, minutes, and seconds displayed above are the desired click time, and the last line allows you to input the time difference analyzed by the previous program for calibration. After clicking 'run', the program will perform a click at the specified time.

<p align="center">
<img src="https://github.com/lixc21/Accurate-Clicker/assets/95122124/4369b305-0800-4f3e-a13e-9f64aaecf45b" alt="alt text" width="35%" />
</p>


