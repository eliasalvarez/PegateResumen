//Modulo principal define toda la aplicacion
var angularTodo = angular.module('angularTodo', []);


//MAIN CONTROLLER controlador de la aplicación
function mainController($scope, $http){
    $scope.formData = {};
    
    //Cuando se cargue la página, pide del API todos los TODos
    $http.ger('/api/todos')
        .success(function(data) {
        $scope.todos = data;
        console.log(data)
    });
    .error(function(data) {
        console.log('Error: ' + data);
    });
    
    //Cuando se añade un nuevo TODO, manda el texto a la API