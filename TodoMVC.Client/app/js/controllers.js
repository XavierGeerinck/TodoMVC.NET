'use strict';

var controllers = angular.module('app.controllers', []);

// Controllers
controllers.controller('TodoList_ListCtrl', function ($scope, TodoList) {
    $scope.todoLists = TodoList.query();
});

controllers.controller('TodoList_CreateCtrl', function ($scope, TodoList) {
    $scope.addTodoList = function () {
        TodoList.post($scope.todoList);
    };
});