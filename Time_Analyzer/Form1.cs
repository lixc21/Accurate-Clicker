using System.Net.Sockets;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace click_time_recorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.TimeOfDay.ToString();
            await Task.Run(() => get_ntp_time());
        }

        private void get_ntp_time()
        {
            try
            {
                DateTime NTPTime = GetNetworkTime();
                DateTime ComputerTime = DateTime.Now;
                this.Invoke(() => { label5.Text = NTPTime.TimeOfDay.ToString(); }, new object[] { });
                this.Invoke(() => { label3.Text = ComputerTime.TimeOfDay.ToString(); }, new object[] { });
                this.Invoke(() => { label7.Text = (ComputerTime - NTPTime).TotalSeconds.ToString(); }, new object[] { });

            }
            catch
            {
                this.Invoke(() => { label3.Text = "network error"; }, new object[] { });
                this.Invoke(() => { label5.Text = "network error"; }, new object[] { });
                this.Invoke(() => { label7.Text = "network error"; }, new object[] { });
            }
        }

        public DateTime GetNetworkTime()
        {
            //default Windows time server
            string ntpServer = this.textBox1.Text;

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            //Offset to get to the "Transmit Timestamp" field (time at which the reply 
            //departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }

        // stackoverflow.com/a/3294698/162671
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}