using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

private IConnection connection;

private IModel _channel;

private IModel channel => _channel ?? (_channel = CreateChannel());






private IModel CreateChannel()
{
    
}