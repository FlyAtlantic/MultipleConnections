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

            return result;
        }
    }
   
}
