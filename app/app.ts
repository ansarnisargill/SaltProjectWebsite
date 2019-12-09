import express = require('express');

// Create a new express application instance
const app: express.Application = express();

app.set("view engine", "vash")

app.get('/', function (req, res) {

    res.render('index', {
        title: 'Vash Template Demo',
        content: 'This is dummy paragraph.'
    });

});

app.listen(3000, function () {
    console.log('listening on port 3000!');
});