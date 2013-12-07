// ngRoute    = Routes
// ngResource = factory
var todoList = angular.module('todoList', ['ngRoute', 'ngResource']);

// Configure routes
todoList.config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            controller: 'TodoList_ListCtrl',
            templateUrl: 'app/todoList/todoList-list.html'
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
todoList.controller('TodoList_ListCtrl', ['$scope', 'TodoList', function ($scope, TodoList) {
    $scope.todoLists = TodoList.query();
}]);