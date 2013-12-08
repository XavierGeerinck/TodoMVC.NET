'use strict';

var controllers = angular.module('app.controllers', []);

// Controllers
controllers.controller('TodoList_ListCtrl', ['$scope', 'TodoList', function ($scope, TodoList) {
    $scope.todoLists = TodoList.query();
}]);

controllers.controller('TodoList_CreateCtrl', ['$scope', function ($scope) {
    $scope.toDoListName;
    $scope.text = "Geef hier de naam in van de nieuwe todolist";
    $scope.setTodoList = function(name) {
        //TODO post to server
        $scope.toDoListName = name;   
    }
}]);