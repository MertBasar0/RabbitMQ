using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMQ
{
    public partial class Form1 : Form
    {

        #region Variables

        private bool _isConnectionOpen;

        private bool isConnectionOpen
        {
            get { return _isConnectionOpen; }

            set
            {
                _isConnectionOpen = value;
                ConnectionStateChanged();
            }

        }


        private IConnection connection;


        private IModel _channel;

        private IModel channel => _channel ?? (_channel = CreateChannel());



        #endregion
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Connection_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection == null)
            {
                connection = GetConnection();
            }
            else
                connection.Close();

            isConnectionOpen = connection.IsOpen;


        }


        private void btn_Publish_Click(object sender, EventArgs e)
        {
            
        }


        private void btn_queueDeclare_Click(object sender, EventArgs e)
        {
            channel.QueueDeclare(txtDeclareQueueName.Text,true,false,false);
            AddLog($"Queue Name: {txtDeclareQueueName.Text}");

        }


        private void btn_exchanceDeclare_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtDeclareExchanceName.Text, cbExchangeDeclareType.SelectedItem.ToString());
            AddLog($"Exchange Name: {txtDeclareExchanceName.Text} Exchange Type: {cbExchangeDeclareType.SelectedItem.ToString()}");
        }

        private void btn_bindQueue_Click(object sender, EventArgs e)
        {
            channel.QueueBind(txtDeclareQueueName.Text, txtDeclareExchanceName.Text, txtBindRoutingKey.Text);
            AddLog($"Bind declare. Queue Name: {txtDeclareQueueName.Text}, Exchange Name: {txtDeclareExchanceName.Text} Routing Key: {txtBindRoutingKey.Text}");
        }



        private void btn_Publish_Click_1(object sender, EventArgs e)
        {
            WriteToQueue(txtExchangeName.Text, txtRoutingKey.Text, txtMessage.Text);
        }


        private IModel CreateChannel()
        {
            return connection.CreateModel();
        }


        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };

            return factory.CreateConnection();
        }


        private void WriteToQueue(string exchangeName,string routingKey,string message)
        {
            var messageArr = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));
            channel.BasicPublish(exchangeName, routingKey, null, messageArr);
            AddLog("Message published.");
        }


        #region App Methods


        private void ConnectionStateChanged()
        {
            btn_Connection.Text = isConnectionOpen ? "Disconnect" : "Connect";

            UpdateConnectionStatus();

            Init();

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
            txtLog.AppendText($"{logStr}\n");

            // set the cursor to end

            txtMessage.SelectionStart = txtMessage.Text.Length;
            txtMessage.ScrollToCaret();
        }
        

        private void Init()
        {
            #region Fill exchange types to combos

            // ExchangeTypes

            if (isConnectionOpen)
            {
                foreach (var item in Enum.GetNames(typeof(exchangeTypes)))
                {
                    cbExchangeDeclareType.Items.Add(item);
                }

                cbExchangeDeclareType.SelectedIndex = 0;
            }
            else
            {
                cbExchangeDeclareType.Items.Clear();
                cbExchangeDeclareType.Items.Clear();
            }
                
            
            #endregion
        }



        private enum exchangeTypes
        {
            direct,fanout,headers,topic
        }




        #endregion

       
    }
}