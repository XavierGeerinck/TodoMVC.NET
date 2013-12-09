'use strict';

var controllers = angular.module('app.controllers', []);

// Controllers
controllers.controller('TodoList_ListCtrl', function ($scope, $location, TodoList) {
    // List
    $scope.todoLists = TodoList.query();

    // Delete
    $scope.removeFromTodoList = function (todoListId) {
        if (!confirm('Confirm delete')) {
            return;
        }

        // Remove
        TodoList.remove({ id: todoListId }, {}, function (data) {
            for (var i in $scope.todoLists) {
                if ($scope.todoLists[i].Id == todoListId) {
                    $scope.todoLists.splice(i, 1);
                }
            }
            $scope.todoLists = TodoList.query();
        });
    };
});

controllers.controller('TodoList_CreateCtrl', function ($scope, $location, TodoList) {
    $scope.addTodoList = function () {
        // Add + redirect to home
        TodoList.add({}, $scope.todoList, function (data) {
            $location.path('/');
        });
    };
});