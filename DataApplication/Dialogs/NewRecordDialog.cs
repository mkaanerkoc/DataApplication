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

namespace DataApplication.Dialogs
{
    public partial class NewRecordDialog : Form
    {
        ConfigurationModel config;

        public NewRecordDialog( ConfigurationModel configParam)
        {
            InitializeComponent();
            config = configParam;
            allDevicesCb.DataSource = config.devices;
            allDevicesCb.DisplayMember = "DisplayName";

            facilitiesCb.DataSource = config.facilities;
            facilitiesCb.DisplayMember = "ListDisplay";

            operatorsCb.DataSource = config.operators;
            operatorsCb.DisplayMember = "Fullname";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tempList = (ListBox)channelsCbList;
            tempList.DataSource = ((DeviceModel)(allDevicesCb.SelectedItem)).Channels;
            tempList.DisplayMember = "name";
            for (int i = 0; i < channelsCbList.Items.Count; i++)
            {
                channelsCbList.SetItemChecked(i, true);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public BaseDevice GetActiveDevice()
        {
            return null;
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
    }
}
