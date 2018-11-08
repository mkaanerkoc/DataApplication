﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Peripherals.MockDevices
{
    public class PG300Mock : MockDeviceBase, IPeripheralInterface
    {
        byte[] R200Response = new byte[] { 01, 70, 70, 65, 65, 66, 66, 82, 50, 48, 48, 48, 02, 48, 44, 48, 48, 44, 80, 50, 48, 48, 48, 55, 56, 56, 48, 48, 49, 69, 55, 50, 03 };
        byte[] R201Response = new byte[] {  01 ,70, 70, 65, 65, 66, 66, 82, 50, 48, 49, 02, 48, 48, 44, 50 ,48 ,49 ,55 ,
                                        48 ,56 ,48 ,57 ,49 ,57 ,48 ,55 ,49 ,48 ,44 ,48 ,49 ,32 ,50 ,53 ,48 ,48 ,48 ,
                                        48 ,43 ,48 ,46 ,48 ,48 ,48 ,48 ,48 ,48 ,69 ,43 ,48 ,48 ,48 ,44 ,48 ,50 ,32 ,
                                        50 ,53 ,48 ,48 ,48 ,48 ,43 ,48 ,46 ,48 ,48 ,48 ,48 ,48 ,48 ,69 ,43 ,48 ,48 ,
                                        48 ,44 ,48 ,51 ,32 ,50 ,53 ,48 ,48 ,48 ,48 ,45 ,50 ,46 ,49 ,56 ,53 ,52 ,49 ,
                                        51 ,69 ,45 ,48 ,48 ,52 ,44 ,48 ,52 ,32 ,50 ,53 ,48 ,48 ,48 ,48 ,45 ,49 ,46 ,
                                        48 ,57 ,50 ,55 ,48 ,55 ,69 ,45 ,48 ,48 ,51 ,44 ,48 ,57 ,45 ,45 ,45 ,45 ,45 ,
                                        45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,44 ,49 ,48 ,
                                        45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,
                                        45 ,45 ,44 ,49 ,49 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,
                                        45 ,45 ,45 ,45 ,45 ,45 ,45 ,44 ,49 ,50 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,
                                        45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,44 ,49 ,51 ,32 ,51 ,48 ,48 ,
                                        48 ,48 ,48 ,43 ,49 ,46 ,49 ,52 ,48 ,53 ,57 ,49 ,69 ,43 ,48 ,48 ,48 ,44 ,49 ,
                                        52 ,32 ,51 ,48 ,48 ,48 ,48 ,48 ,43 ,53 ,46 ,55 ,48 ,50 ,57 ,53 ,52 ,69 ,43 ,
                                        48 ,48 ,48 ,44 ,49 ,53 ,32 ,51 ,48 ,48 ,48 ,48 ,48 ,43 ,56 ,46 ,53 ,51 ,52 ,
                                        57 ,48 ,53 ,69 ,45 ,48 ,48 ,49 ,44 ,49 ,54 ,32 ,51 ,48 ,48 ,48 ,48 ,48 ,43 ,
                                        52 ,46 ,50 ,54 ,55 ,52 ,53 ,50 ,69 ,43 ,48 ,48 ,48 ,44 ,50 ,49 ,32 ,53 ,48 ,
                                        48 ,48 ,48 ,48 ,45 ,49 ,46 ,48 ,57 ,52 ,54 ,57 ,48 ,69 ,43 ,48 ,48 ,48 ,44 ,
                                        50 ,50 ,32 ,53 ,48 ,48 ,48 ,48 ,48 ,45 ,53 ,46 ,52 ,55 ,51 ,52 ,53 ,50 ,69 ,
                                        43 ,48 ,48 ,48 ,44 ,50 ,51 ,32 ,53 ,48 ,48 ,48 ,48 ,48 ,45 ,49 ,46 ,49 ,49 ,
                                        48 ,57 ,53 ,52 ,69 ,43 ,48 ,48 ,48 ,44 ,50 ,52 ,32 ,53 ,48 ,48 ,48 ,48 ,48 ,
                                        45 ,53 ,46 ,53 ,53 ,52 ,55 ,55 ,50 ,69 ,43 ,48 ,48 ,48 ,44 ,50 ,53 ,32 ,32 ,
                                        32 ,51 ,48 ,49 ,50 ,43 ,57 ,46 ,56 ,57 ,53 ,52 ,53 ,52 ,69 ,45 ,48 ,48 ,50 ,
                                        44 ,50 ,55 ,32 ,32 ,32 ,51 ,48 ,49 ,50 ,43 ,49 ,46 ,48 ,50 ,49 ,56 ,54 ,48 ,
                                        69 ,45 ,48 ,48 ,49 ,44 ,50 ,57 ,32 ,32 ,32 ,50 ,53 ,49 ,50 ,43 ,50 ,46 ,48 ,
                                        53 ,50 ,56 ,54 ,51 ,69 ,43 ,48 ,48 ,49 ,44 ,51 ,49 ,32 ,32 ,32 ,50 ,53 ,49 ,
                                        50 ,43 ,50 ,46 ,48 ,54 ,50 ,49 ,55 ,51 ,69 ,43 ,48 ,48 ,49 ,44 ,48 ,48 ,48 ,
                                        48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,
                                        48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,
                                        48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,
                                        48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,
                                        48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,48 ,54 ,70 ,03};

        byte[] R202Response = new byte[] {
                                        01 ,70 ,70 ,65 ,65 ,66 ,66 ,82 ,50 ,48 ,50 ,02 ,48 ,48 ,44 ,45 ,45 ,45 ,45 ,
                                        45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,44 ,49 ,43 ,52 ,46 ,55 ,56 ,55 ,
                                        57 ,49 ,48 ,69 ,43 ,48 ,48 ,49 ,44 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,
                                        45 ,45 ,45 ,45 ,45 ,44 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,45 ,
                                        45 ,45 ,44 ,49 ,43 ,53 ,46 ,52 ,57 ,48 ,56 ,51 ,49 ,69 ,43 ,48 ,48 ,49 ,44 ,
                                        49 ,43 ,54 ,46 ,54 ,55 ,56 ,53 ,48 ,56 ,69 ,43 ,48 ,48 ,49 ,44 ,49 ,43 ,52 ,
                                        46 ,53 ,56 ,49 ,54 ,56 ,53 ,69 ,43 ,48 ,48 ,49 ,44 ,49 ,43 ,52 ,46 ,57 ,55 ,
                                        48 ,51 ,56 ,57 ,69 ,43 ,48 ,48 ,48 ,44 ,48 ,43 ,57 ,46 ,49 ,49 ,57 ,49 ,50 ,
                                        55 ,69 ,43 ,48 ,48 ,50 ,44 ,49 ,43 ,53 ,46 ,50 ,48 ,56 ,57 ,51 ,56 ,69 ,45 ,
                                        48 ,48 ,49 ,49 ,52 ,03};
        public int close()
        {
            throw new NotImplementedException();
        }

        public int open()
        {
            throw new NotImplementedException();
        }

        public int read(int size, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int read(byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            throw new NotImplementedException();
        }

        public int read(byte[] cmd, int size, ref byte[] outbuffer, int timeout = 500)
        {
            
            throw new NotImplementedException();
        }

        public int readUntil(byte[] cmd, byte endbyte, ref byte[] outbuffer, int timeout = 500)
        {
            if (cmd.Length != 12)
            {
                return 0;
            }
            if (cmd[0] == 'R' && cmd[1] == '2' && cmd[2] == '0' && cmd[3] == '0')
            {
                for (int k = 0; k < R200Response.Length; k++)
                {
                    outbuffer[k] = (byte)R200Response[k];
                }
            }
            else if (cmd[0] == 'R' && cmd[1] == '2' && cmd[2] == '0' && cmd[3] == '1')
            {
                for (int k = 0; k < R201Response.Length; k++)
                {
                    outbuffer[k] = (byte)R201Response[k];
                }
            }
            else if (cmd[0] == 'R' && cmd[1] == '2' && cmd[2] == '0' && cmd[3] == '2')
            {
                for (int k = 0; k < R202Response.Length; k++)
                {
                    outbuffer[k] = (byte)R202Response[k];
                }
            }
            else
            {
                return 0;
            }
            return 1;
        }

        public int readAsync(byte[] cmd, ref byte[] outbuffer)
        {
            throw new NotImplementedException();
        }

        public int write(byte[] param)
        {
            throw new NotImplementedException();
        }

        public int writeAsync(byte[] param)
        {
            throw new NotImplementedException();
        }
    }
}
