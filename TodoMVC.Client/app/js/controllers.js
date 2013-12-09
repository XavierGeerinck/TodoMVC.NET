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

        // Remove + redirect to home
        TodoList.remove({ id: todoListId }, {}, function (data) {
            for (i in $scope.todoLists) {
                if ($scope.contacts[i].id == id) {
                    $scope.contacts.splice(i, 1);
                    $scope.newcontact = {};
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