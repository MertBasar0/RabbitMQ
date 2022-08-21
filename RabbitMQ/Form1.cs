using RabbitMQ.Client;

namespace RabbitMQ
{
    public partial class Form1 : Form
    {

        #region Variables

        private bool _isConnectionOpen;

        private bool isConnectionOpen
        {
            get
            {
                return _isConnectionOpen;
            }

            set
            {
                _isConnectionOpen = value;
            }
        }

        private IConnection connection;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionStateChanged();
            Init();
        }


        private void btn_Connection_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection == null)
            {
                connection = GetConnection();
            }
            else
                connection.Close();

            isConnectionOpen = !isConnectionOpen; 
        }


        private void btn_Publish_Click(object sender, EventArgs e)
        {

        }


        private void btn_queueDeclare_Click(object sender, EventArgs e)
        {

        }


        private void btn_exchanceDeclare_Click(object sender, EventArgs e)
        {

        }


        private void btn_bindQueue_Click(object sender, EventArgs e)
        {

        }


        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }


        #region App Methods


        private void ConnectionStateChanged()
        {
            btn_Connection.Text = isConnectionOpen ? "Disconnected" : "Connect";

            UpdateConnectionStatus();

            pnlMain.Enabled = gbQueueExchange.Enabled = isConnectionOpen;
        }


        private void UpdateConnectionStatus()
        {
            string state = $"{(isConnectionOpen ? "" : "Not ")}Connected";
            tslbl_ConnectionStatus.Text = $"Connection State: {state}";
            AddLog($"Connection state is {state}");
        }


        private void AddLog(string logStr)
        {
            logStr = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] - {logStr}";
            txtMessage.AppendText($"{logStr}\n");

            // set the cursor to end

            txtMessage.SelectionStart = txtMessage.Text.Length;
            txtMessage.ScrollToCaret();
        }
        

        private void Init()
        {
            #region Fill exchange types to combos

            // ExchangeTypes

            foreach (var item in Enum.GetNames(typeof(exchangeTypes)))
            {
                cbExchangeType.Items.Add(item);
                cbExchangeDeclareType.Items.Add(item);
            }

            cbExchangeDeclareType.SelectedIndex = cbExchangeType.SelectedIndex = 0;
            #endregion
        }



        private enum exchangeTypes
        {
            direct,fanout,headers,topic
        }


        #endregion

      
    }
}