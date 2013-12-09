'use strict';

var services = angular.module('app.services', ['ngResource']);

// Init load the list
services.factory('TodoListFactory', ['$resource',
    function ($resource) {
        return $resource('http://localhost:9000/api/todolist/:id', {}, {
            getAll: { method: 'GET', params: {}, isArray: true },
            getOne: { method: 'GET' },
            add:    { method: 'POST' },
            remove: { method: 'DELETE' },
            edit:   { method: 'PUT' }
        });
    }
]);