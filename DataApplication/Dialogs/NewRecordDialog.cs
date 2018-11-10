using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataApplication.ApplicationManager;
using DataApplication.Devices;
using DataApplication.Models;
using DataApplication.Views;
using DataApplication.StaticInformations;
using DataApplication.Factories;
using DataApplication.Peripherals;
using DataApplication.DataWriter;

namespace DataApplication.Dialogs
{
    public partial class NewRecordDialog : Form
    {
        ConfigurationModel config;
        DeviceConfigModel dcm;
        BaseDevice currentDevice;
        string fileExtension = "";

        public NewRecordDialog( ConfigurationModel configParam)
        {
            InitializeComponent();
            dcm = new DeviceConfigModel();
            config = configParam;
            allDevicesCb.DataSource = config.devices;
            allDevicesCb.DisplayMember = "DisplayName";

            facilitiesCb.DataSource = config.facilities;
            facilitiesCb.DisplayMember = "ListDisplay";

            operatorsCb.DataSource = config.operators;
            operatorsCb.DisplayMember = "Fullname";

            fileTypeSelectionCb.DataSource = StorageInformations.storageOptions;
            fileTypeSelectionCb.DisplayMember = "Name";
           
        }

  

        public BaseDevice GetActiveDevice()
        {
            return currentDevice;
        }

        public List<ChannelModel> GetActiveChannels()
        {
            List<ChannelModel> activeChannels = new List<ChannelModel>();
            List<ChannelModel> listTemp = ((DeviceModel)(allDevicesCb.SelectedItem)).Channels;
            //activeChannels = (List<ChannelModel>) channelsCbList.CheckedItems;
            for (int k = 0; k<channelsCbList.Items.Count;k++)
            {
                if( channelsCbList.GetItemChecked(k) == true )
                {
                    activeChannels.Add(listTemp[k]);
                }
            }
            return activeChannels;
        }
        public string GetFileName()
        {
            return fileNameTb.Text;
        }

        private void allDevicesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviceModel selectedDevice = ((DeviceModel)(allDevicesCb.SelectedItem));
            UserControl devConfigMenu;
            ListBox tempList = (ListBox)channelsCbList;
            tempList.DataSource = selectedDevice.Channels;
            tempList.DisplayMember = "name";
            for (int i = 0; i < channelsCbList.Items.Count; i++)
            {
                channelsCbList.SetItemChecked(i, true);
            }
            deviceSettingsContainer.Controls.Clear();

            if ( selectedDevice.Interface == DeviceInterface.SERIAL_INTERFACE)
            {
                devConfigMenu = new SerialDeviceConfig( dcm );
                devConfigMenu.Location = new Point( 5, 20 );
                deviceSettingsContainer.Controls.Add( devConfigMenu );
            }
            else if ( selectedDevice.Interface == DeviceInterface.UDP_INTERFACE )
            {
                devConfigMenu = new UDPDeviceConfig( dcm );
                devConfigMenu.Location = new Point( 5, 20 );
                deviceSettingsContainer.Controls.Add( devConfigMenu );
            }
            else if( selectedDevice.Interface == DeviceInterface.TCP_INTERFACE )
            {
                throw new NotImplementedException("TCP INTERFACE NOT Implemented yet");
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            var selectedDevice = ((DeviceModel)(allDevicesCb.SelectedItem));
            var storageModel = (DataStorageConfigModel)fileTypeSelectionCb.SelectedItem;
            var configBox = (IDeviceConfigControl)deviceSettingsContainer.Controls[0];
            var devConfig = configBox.GetDeviceConfig();
            if( devConfig != null && selectedDevice != null && storageModel != null)
            {
                this.DialogResult = DialogResult.OK;
                currentDevice = DeviceFactory.CreateDevice(selectedDevice);
                var peripheralInterface = PeripheralFactory.CreatePeripheral(devConfig);
                var dataWriter = DataWriterFactory.CreateDataWriter(fileNameTb.Text, storageModel.Type);
                var errorHandler = new FileErrorHandler("application_errors.txt");

                currentDevice.SetDataWriter(dataWriter);
                currentDevice.SetPeripheralInterface(peripheralInterface);
                currentDevice.SetErrorHandler(errorHandler);

                this.Close();
            }
        }

        private void facilitiesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileNameTb.Text = "";
            DateTime dt = DateTime.Now;
            FacilityModel facilityModel = (FacilityModel)facilitiesCb.SelectedItem;
            StringBuilder sb  = new StringBuilder();
            sb.Append(facilityModel.Name);
            sb.Append("_");
            sb.Append(facilityModel.City);
            sb.Append("__");
            sb.Append(dt.Day);
            sb.Append("-");
            sb.Append(dt.Month);
            sb.Append("-");
            sb.Append(dt.Year);
            sb.Append(fileExtension);
            fileNameTb.Text = sb.ToString();
        }

        private void fileTypeSelectionCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacilityModel facilityModel = (FacilityModel)facilitiesCb.SelectedItem;
            DataStorageConfigModel storageModel = (DataStorageConfigModel)fileTypeSelectionCb.SelectedItem;
            fileExtension = storageModel.Extension;
            DateTime dt = DateTime.Now;
            StringBuilder sb = new StringBuilder();
            sb.Append(facilityModel.Name);
            sb.Append("_");
            sb.Append(facilityModel.City);
            sb.Append("__");
            sb.Append(dt.Day);
            sb.Append("-");
            sb.Append(dt.Month);
            sb.Append("-");
            sb.Append(dt.Year);
            sb.Append(fileExtension);
            fileNameTb.Text = sb.ToString();
        }   
    }
}
