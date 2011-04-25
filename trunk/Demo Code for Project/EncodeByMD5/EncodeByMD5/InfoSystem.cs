using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace EncodeByMD5
{
    public class InfoSystem
    {
    
        public string GetHDDSerialNumber(string drive)
        {
            if (drive == "" || drive == null)
            {
                drive = "C";
            }
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            disk.Get();
            return disk["VolumeSerialNumber"].ToString();
        }
        public double GetHDDFreeSpace(string drive)
        {
            if (drive == "" || drive == null)
            {
                drive = "C";
            }
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            disk.Get();
            return Convert.ToDouble(disk["FreeSpace"]);
        }
        public double getHDDSize(string drive)
        {
            if (drive == "" || drive == null)
            {
                drive = "C";
            }
            ManagementObject disk = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            disk.Get();
            return Convert.ToDouble(disk["Size"]);
        }
        public bool IsIPEnabled()
        {
            ManagementClass mgmt = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            bool enabled = false;
            foreach (ManagementObject obj in objCol)
            {
                enabled = (bool)obj["IPEnabled"];
                break;
                obj.Dispose();
            }
            return enabled;
        }
        public string FindMACAddress()
        {
            ManagementClass mgmt = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            string address = String.Empty;
            foreach (ManagementObject obj in objCol)
            {
                if (address == String.Empty) 
                {
                    if ((bool)obj["IPEnabled"] == true)
                    {
                        address = obj["MacAddress"].ToString();
                    }
                }
                obj.Dispose();
            }
            address = address.Replace(":", "");
            return address;
        }
        public string GetDefaultIPGateway()
        {
            ManagementClass mgmt = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            string gateway = String.Empty;
            foreach (ManagementObject obj in objCol)
            {
                if (gateway == String.Empty) 
                {
                    if ((bool)obj["IPEnabled"] == true)
                    {
                        gateway = obj["DefaultIPGateway"].ToString();
                    }
                }
                obj.Dispose();
            }
            gateway = gateway.Replace(":", "");
            return gateway;
        }
        public string GetCPUId()
        {
            string cpuInfo =  String.Empty;            
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            foreach(ManagementObject obj in objCol)
            {
                if(cpuInfo == String.Empty)
                {
                    cpuInfo = obj.Properties["ProcessorId"].Value.ToString();
                }            
            }
            return cpuInfo;        
        }
        public string GetCPUManufacturer()
        {
            string cpuMan = String.Empty;
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            foreach (ManagementObject obj in objCol)
            {
                if (cpuMan == String.Empty)
                {
                    cpuMan = obj.Properties["Manufacturer"].Value.ToString();
                }
            }
            return cpuMan;        
        }
        public string GetCPUStatus()
        {
            string cpuStatus = String.Empty;
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            foreach (ManagementObject obj in objCol)
            {
                if (cpuStatus == String.Empty)
                {
                    cpuStatus = obj.Properties["Status"].Value.ToString();
                }
            }
            return cpuStatus;    
        }
        public int GetCPUCurrentClockSpeed()
        {
            int cpuClockSpeed = 0;
            ManagementClass mgmt = new ManagementClass("Win32_Processor");
            ManagementObjectCollection objCol = mgmt.GetInstances();
            foreach (ManagementObject obj in objCol)
            {
                if (cpuClockSpeed == 0)
                {
                    cpuClockSpeed = Convert.ToInt32(obj.Properties["CurrentClockSpeed"].Value.ToString());
                }
            }
            return cpuClockSpeed;    
        }
    }
}
