var net = require('net');

var client = new net.Socket();

client.connect(7000, "127.0.0.1");

//Anytime the client gets data do something
client.on('data', function(data){
    console.log("Data: " + data);
    client.destroy();
});

//Add a close event handler for the client Socket
client.on('close', function(){
    console.log('Connection closed');
});