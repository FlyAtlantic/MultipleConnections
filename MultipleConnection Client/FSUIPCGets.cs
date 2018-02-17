using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSUIPC;

namespace MultipleConnection_Client
{
    class FSUIPCOffsets
    {
        static public Offset<long> longitude = new Offset<long>(0x0568);
        static public Offset<long> latitude = new Offset<long>(0x0560);
        static public Offset<Double> compass = new Offset<double>(0x02CC);
        static public Offset<int> groundspeed = new Offset<int>(0x02B4);
        static public Offset<Double> altitude = new Offset<Double>(0x6020);
        static public Offset<byte[]> AiTfraffic = new Offset<byte[]>(0xD000, 2048);
        static public Offset<byte[]> AiTfrafficInsert = new Offset<byte[]>(0x1F80, 32);

    }

    public class FSUIPCGets
    {
        /// <summary>
        /// Offset for Lon features
        /// </summary>
        public double Longitude;
        /// <summary>
        /// Offset for Lat features
        /// </summary>
        public double Latitude;
        /// <summary>
        /// Offset for Compass
        /// </summary>
        public Double Compass;
        /// <summary>
        /// GroundSpeed
        /// </summary>
        public double GroundSpeed;
        /// <summary>
        /// Altitude? MSL AGL ... ?, in ft most likely
        /// </summary>
        public double Altitude;
        /// <summary>
        /// SimTime
        /// </summary>
        public byte[] AiTfraffic;
        /// <summary>
        /// SimTime
        /// </summary>
        public byte[] AiTfrafficInsert;

        public static FSUIPCGets GetCurrent()
        {
            FSUIPCGets result = new FSUIPCGets();

            // snapshot data
            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception crap)
            {
                // failed to connect to the sim?
                return null;
            }

            // capture values
            result.Latitude = FSUIPCOffsets.latitude.Value * (90.0 / (10001750.0 * 65536.0 * 65536.0));
            result.Longitude = FSUIPCOffsets.longitude.Value * (360.0 / (65536.0 * 65536.0 * 65536.0 * 65536.0));
            result.Compass = FSUIPCOffsets.compass.Value;
            result.GroundSpeed = (FSUIPCOffsets.groundspeed.Value / 65536) * 1.94384449;
            result.Altitude = (FSUIPCOffsets.altitude.Value * 3.2808399);
            result.AiTfraffic = FSUIPCOffsets.AiTfraffic.Value;
            result.AiTfrafficInsert = FSUIPCOffsets.AiTfrafficInsert.Value;

            return result;
        }

        public static void SetValue(Offset<byte[]> offset, byte[] value)
        {
            offset.Value = value;

            FSUIPCConnection.Process();

        }
    }
   
}
