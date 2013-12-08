'use strict';

var controllers = angular.module('app.controllers', []);

// Controllers
controllers.controller('TodoList_ListCtrl', ['$scope', 'TodoList', function ($scope, TodoList) {
    $scope.todoLists = TodoList.query();
}]);