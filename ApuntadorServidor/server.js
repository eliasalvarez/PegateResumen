var express  = require ('express');
var app      = express();
var mongoose = require('mongoose');

//conexión con la base de datos
mongoose.connect('mongodb://localhost:27017/angular-todo');

//configuracioón
app.configure(function() {
    //Localización de los ficheros estáticos
    app.use(express.static(_dirname + '/public'));
    //muestra un log de todos los request en la consola
    app.use(express.logger('dev'));
    //permite cambiar el html con el método POST
    app.use(express.bodyParser());
    //simula DELETE y PUT
    app.use(express.methodOverride());
});

var todo = mongoose.model('todo', { text: String });

//Rutas de nuestro API
//GET de todos los TODOs
app.get('/api/todos', funtion(req, res) {
        Todo.find(function(err, todos) {
            if(err){
                res.send(err);
            }
            res.json(todos);
    });
});


//POST que crea un TODO y devuelve todos tras la creación
app.post('/api/todos', function(req, res) {
    Todo.create({
        text: req.body.text,
        done: false;
    }, function(err, todo) {
        if(err) {
            res.send(err);
        }
        
        Todo.find(function(err, todos){
            if(err){
                res.send(err);
            }
            res.json(todos);
        });
    });
});


//DELETE un TODO específico y devuelve todos tras borrarlo
app.delete('/api/todos/:todo', function(req,res) {
    Todo.remove({
        _id: req.params.todo
    }, function (err, todo) {
        if(err) {
            res.send(err);
        }
        
        Todo.find(function(err, todos) {
            if(err){
                res.send(err);
            }
            res.json(todos);
        });
    });
});


//carga una vista html simple donde irá nuestra Single App Page
//Angular manejará el Frontend
app.get('*', function(req,res) {
    res.sendfile('./public/index.html');
});

//escucha en el puerto 8080 y corre el server
app.listen(8080, function(){ 
    consolle.log('App listening on port 8080');
});