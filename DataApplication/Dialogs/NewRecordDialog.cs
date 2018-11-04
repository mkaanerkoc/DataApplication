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

namespace DataApplication.Dialogs
{
    public partial class NewRecordDialog : Form
    {
        ConfigurationModel config;

        public NewRecordDialog( ConfigurationModel configParam)
        {
            InitializeComponent();
            config = configParam;
            comboBox1.DataSource = config.devices;
            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox tempList = (ListBox)channelsCbList;
            tempList.DataSource = ((DeviceModel)(comboBox1.SelectedItem)).Channels;
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

        public List<ChannelModel> GetActiveChannels()
        {
            List<ChannelModel> activeChannels = new List<ChannelModel>();
            List<ChannelModel> listTemp = ((DeviceModel)(comboBox1.SelectedItem)).Channels;
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
    }
}
