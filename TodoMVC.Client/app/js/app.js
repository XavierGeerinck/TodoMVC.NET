// Enable ECMAScript to prevent certain actions and throw more exceptions
'use strict';

// Configure the app
var app = angular.module('app', [
    'ngRoute',
    'app.filters',
    'app.services',
    'app.directives',
    'app.controllers'
]);

// Configure routes
app.config(function ($routeProvider) {
    $routeProvider.when('/', { controller: 'TodoList_ListCtrl', templateUrl: 'partials/todoList-list.html' });
    $routeProvider.when('/create', { controller: 'TodoList_CreateCtrl', templateUrl: 'partials/todoList-create.html' });
    $routeProvider.otherwise({ redirectTo: '/' });
});