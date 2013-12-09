'use strict';

var controllers = angular.module('app.controllers', []);

// Controllers
controllers.controller('HeaderCtrl', function ($scope, $location) {
    $scope.isActive = function (viewLocation) {
        return viewLocation == $location.path();
    };
});

controllers.controller('TodoList_ListCtrl', function ($scope, $location, TodoListFactory) {
    $scope.viewLoading = true;

    // List
    $scope.todoLists = TodoListFactory.getAll(function (data) {
        $scope.viewLoading = false;
    });

    // Delete
    $scope.removeFromTodoList = function (todoListId) {
        if (!confirm('Confirm delete')) {
            return;
        }

        // Remove
        TodoListFactory.remove({ id: todoListId }, {}, function (data) {
            // Remove from view
            for (var i in $scope.todoLists) {
                if ($scope.todoLists[i].Id == todoListId) {
                    $scope.todoLists.splice(i, 1);
                }
            }
        });
    };
});

controllers.controller('TodoList_CreateCtrl', function ($scope, $location, TodoListFactory) {
    $scope.addTodoList = function () {
        // Add + redirect to home
        TodoListFactory.add({}, $scope.todoList, function (data) {
            $location.path('/');
        });
    };
});

controllers.controller('TodoList_EditCtrl', function ($scope, $location, $routeParams, TodoListFactory) {
    $scope.todoList = TodoListFactory.getOne({ id: $routeParams.id });

    $scope.editTodoList = function () {
        // Add + redirect to home
        TodoListFactory.edit({ id: $scope.todoList.Id }, $scope.todoList, function (data) {
            $location.path('/');
        });
    };
});

controllers.controller('TodoItem_CreateCtrl', function ($scope, $location, TodoListFactory, TodoItemFactory, StateFactory) {
    // Get todolists
    $scope.loadingTodoLists = true;
    $scope.todoLists = TodoListFactory.getAll(function (data) {
        $scope.loadingTodoLists = false;
    });

    // Get States
    $scope.loadingStates = true;
    $scope.states = StateFactory.getAll(function (data) {
        $scope.loadingStates = false;
    });


    $scope.addTodoList = function () {
        // Add + redirect to home
        TodoListFactory.add({}, $scope.todoList, function (data) {
            $location.path('/');
        });
    };
});