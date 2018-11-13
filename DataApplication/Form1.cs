using DataApplication.ApplicationManager;
using DataApplication.Devices;
using DataApplication.Dialogs;
using DataApplication.Peripherals;
using DataApplication.Peripherals.MockDevices;
using DataApplication.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataApplication
{
    public partial class Form1 : Form
    {
        SessionManager sm;
        IViewUpdater vu;
        IPeripheralInterface sp;
        public Form1()
        {
            InitializeComponent();
            var cg = new ConfigurationManager();
            cg.ParseConfigXML();
            sp = new PG250Mock();//new SerialPeripheral(9600, Parity.Even, StopBits.None, "COM2");
            vu = new FormUpdater( panel1 );
            sm = new SessionManager();
            sm.OnTick += SessionManager_Tick;
            /*activeDevice = new PG250(sp, vu, null);
           
            sm.SetDevice(activeDevice);*/
        }

        private void SessionManager_Tick(object sender, EventArgs e)
        {
            var ee = (OnTickEventArgs)e;
            if( lastReadLbl.InvokeRequired)
            {
                lastReadLbl.Invoke( new MethodInvoker(()=>
                {
                    lastReadLbl.Text = ee.TimeReached.ToString();
                }));
            }
            else
            {
                lastReadLbl.Text = ee.TimeReached.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click( object sender, EventArgs e)
        {
            //IUDPDevice udpDevice = devFactory.createUDPDevice("PG300");
            //label1.Text = udpDevice.GetInformation();
        }

        private void yeniKayıtCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newRecDialog = new NewRecordDialog( ConfigurationManager.config );
            var dialogResult = newRecDialog.ShowDialog();
            if( dialogResult == DialogResult.OK )
            {
                var dm = newRecDialog.GetActiveDevice();
                if( dm != null )
                {
                    var lb = (ListBox)activeChannelsCbList;
                    lb.DataSource = newRecDialog.GetActiveChannels();
                    lb.DisplayMember = "name";
                    for (int i = 0; i < activeChannelsCbList.Items.Count; i++)
                    {
                        activeChannelsCbList.SetItemChecked(i, true);
                    }

                    fileNameLbl.Text = newRecDialog.GetFileName();
                    sm.SetFilename( newRecDialog.GetFileName() );
                    vu.initialize( newRecDialog.GetActiveChannels() );
                    activeDeviceNameLbl.Text = dm.GetModel().DisplayName;
                    dm.SetViewUpdater(vu);
                    dm.Begin();
                }
                else
                {

                }

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if( sm.IsRunning() )
            {
                button3.Text = "Başlat";
                readPeriodTb.Enabled = true;
                sm.StopTimer();
            }
            else
            {
                button3.Text = "Bitir";
                readPeriodTb.Enabled = false;
                sm.SetReadPeriod(Convert.ToDouble(readPeriodTb.Text));
                sm.StartTimer();
            }
        }

        private void kayıtAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramParameters prgParamsPage = new ProgramParameters();
            DialogResult dialogResult = prgParamsPage.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }
        }

        private void eskiKayıttanDevamEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void activeChannelsCbList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            /*You can use the ItemCheck event, if you also check the new state of the item
             *  which is being clicked. This is available in the event args, as e.NewValue. 
             *  If NewValue is checked, include the current item along with the collection proper in your logic:
             */
            List<string> checkedItems = new List<string>();
            foreach (var item in activeChannelsCbList.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
            {
                //checkedItems.Add(activeChannelsCbList.Items[e.Index].ToString());
                vu.addChannel((ChannelModel)activeChannelsCbList.Items[e.Index]);
            }
            else
            {
                vu.removeChannel((ChannelModel)activeChannelsCbList.Items[e.Index]);
            }
                //checkedItems.Remove(activeChannelsCbList.Items[e.Index].ToString());
            


        }
    }
}
