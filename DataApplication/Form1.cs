using DataApplication.ApplicationManager;
using DataApplication.Devices;
using DataApplication.Dialogs;
using DataApplication.Peripherals;
using DataApplication.Peripherals.MockDevices;
using DataApplication.View;
using System;
using System.Windows.Forms;

namespace DataApplication
{
    public partial class Form1 : Form
    {
        BaseDevice activeDevice;
        SessionManager sm;
        IViewUpdater vu;
        IPeripheralInterface sp;
        public Form1()
        {
            InitializeComponent();
            sp = new PG250Mock();//new SerialPeripheral(9600, Parity.Even, StopBits.None, "COM2");
            vu = new FormUpdater(mainContainer);
            sm = new SessionManager();
            sm.OnTick += SessionManager_Tick;
            activeDevice = new PG250("COM1", sp, vu);
            ConfigurationManager cg = new ConfigurationManager();
            cg.ParseConfigXML();
            sm.SetDevice(activeDevice);
        }

        private void SessionManager_Tick(object sender, EventArgs e)
        {
            OnTickEventArgs ee = (OnTickEventArgs)e;
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
            activeDevice.ReadDataChannels();
        }

        private void button2_Click( object sender, EventArgs e)
        {
            //IUDPDevice udpDevice = devFactory.createUDPDevice("PG300");
            //label1.Text = udpDevice.GetInformation();
        }

        private void yeniKayıtCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecordDialog newRecDialog = new NewRecordDialog( ConfigurationManager.config );
            DialogResult dialogResult = newRecDialog.ShowDialog();
            if( dialogResult == DialogResult.OK )
            {
                // burasi onemli configler, creationlar v.s. burada yapılacak hep
                //BaseDevice dm = newRecDialog.GetActiveDevice();
                sm.SetFilename( newRecDialog.GetFileName() );
                vu.initialize( newRecDialog.GetActiveChannels() );
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if( sm.IsRunning() )
            {
                button3.Text = "Başlat";
                sm.StopTimer();
            }
            else
            {
                button3.Text = "Bitir";
                sm.SetReadPeriod(Convert.ToDouble(readPeriodTb.Text));
                sm.StartTimer();
            }
        }
    }
}
