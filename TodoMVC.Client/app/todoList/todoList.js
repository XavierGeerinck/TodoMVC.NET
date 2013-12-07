// ngRoute    = Routes
// ngResource = factory
var todoList = angular.module('todoList', ['ngRoute', 'ngResource']);

// Configure routes
todoList.config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            controller: 'ListCtrl',
            templateUrl: 'todoList/todoList-list.tpl.html'
        })
        .otherwise({
            redirectTo: '/'
        });
});

// Init load the list
todoList.factory('TodoList', ['$resource',
    function ($resource) {
        return $resource('http://localhost:9000/api/todolist', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });
    }
]);

// Controller
todoList.controller('ListCtrl', ['$scope', function ($scope) {
    $scope.todoLists = TodoList.query();
}]);