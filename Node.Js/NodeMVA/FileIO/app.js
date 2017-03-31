var fs = require('fs');

fs.readFile('package.jsoncd..', function(err, data){
    console.log(data.toString());
});